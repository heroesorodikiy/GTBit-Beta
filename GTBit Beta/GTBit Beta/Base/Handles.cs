﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace GTBit_Beta.Base
{
    public class HandleInfo
    {
        // Source: ?? Some Chinese website. I can't find it anymore.

        public IntPtr Handle { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public IntPtr Object { get; set; }
        public IntPtr UniqueProcessId { get; set; }
        public uint GrantedAccess { get; set; }
        public ushort CreatorBackTraceIndex { get; set; }
        public ushort ObjectTypeIndex { get; set; }
        public uint HandleAttributes { get; set; }
        public uint Reserved { get; set; }
    }

    public static class Handles
    {
        [DllImport("ntdll.dll")]
        static extern NT_STATUS NtDuplicateObject(
          IntPtr SourceProcessHandle,
          IntPtr SourceHandle,
          IntPtr TargetProcessHandle,
          out IntPtr TargetHandle,
          uint DesiredAccess, uint Attributes, uint Options);

        [DllImport("ntdll.dll")]
        static extern NT_STATUS NtQueryObject(
          IntPtr ObjectHandle,
          ObjectInformationClass ObjectInformationClass,
          IntPtr ObjectInformation,
          int ObjectInformationLength,
          out int returnLength);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern uint QueryDosDevice(
          string lpDeviceName,
          StringBuilder lpTargetPath,
          int ucchMax);
        [DllImport("kernel32.dll")]
        static extern int CloseHandle(IntPtr hObject);
        [DllImport("kernel32.dll")]
        static extern IntPtr OpenProcess(
          ProcessAccessFlags dwDesiredAccess,
          [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle,
          int dwProcessId);
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool DuplicateHandle(
          IntPtr hSourceProcessHandle,
          IntPtr hSourceHandle,
          IntPtr hTargetProcessHandle,
          out IntPtr lpTargetHandle,
          uint dwDesiredAccess,
          [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle,
          DuplicateOptions dwOptions);
        [Flags]
        enum DuplicateOptions : uint
        {
            DUPLICATE_CLOSE_SOURCE = (0x00000001),
            DUPLICATE_SAME_ACCESS = (0x00000002),
        }

        const uint PROCESS_DUP_HANDLE = 0x0040;
        const uint PROCESS_QUERY_INFORMATION = 0x0400U;
        const uint PROCESS_VM_READ = 0x0010U;
        const int MAX_PATH = 260;

        public static bool CloseHandleEx(int pid, IntPtr handle)
        {
            IntPtr hProcess = OpenProcess(ProcessAccessFlags.DupHandle, false, pid);
            IntPtr dupHandle = IntPtr.Zero;
            bool success = DuplicateHandle(hProcess, handle, IntPtr.Zero, out dupHandle, 0, false, DuplicateOptions.DUPLICATE_CLOSE_SOURCE);
            CloseHandle(hProcess);
            return success;
        }

        public enum ProcessAccessFlags : uint
        {
            All = 0x001F0FFF,
            Terminate = 0x00000001,
            CreateThread = 0x00000002,
            VMOperation = 0x00000008,
            PROCESS_VM_READ = 0x10,
            VMWrite = 0x00000020,
            DupHandle = 0x00000040,
            SetInformation = 0x00000200,
            QueryInformation = 0x00000400,
            Synchronize = 0x00100000
        }

        public static IEnumerable<HandleInfo> EnumProcessHandles(int pid)
        {
            using (var proc = Process.GetProcessById(pid))
            {
                IntPtr hProcess = OpenProcess(ProcessAccessFlags.DupHandle, false, pid);
                foreach (var shi in EnumHandles(pid))
                {
                    IntPtr hObj = IntPtr.Zero;
                    string hType = null;
                    string hName = null;
                    try
                    {
                        if (shi.HandleValue.ToInt32() == 1104)
                        {
                            Debug.Print("Debug");
                        }
                        if (!NT_SUCCESS(NtDuplicateObject(hProcess,
                                         shi.HandleValue,
                                         Process.GetCurrentProcess().Handle,
                                         out hObj, 0, 0, 0)))
                        {
                            continue;
                        }
                        using (var nto1 = new NtObject(hObj, ObjectInformationClass.ObjectTypeInformation, typeof(OBJECT_TYPE_INFORMATION)))
                        {
                            try
                            {
                                var oti = ObjectTypeInformationFromBuffer(nto1.Buffer);
                                hType = oti.Name.ToString();
                            }
                            catch (Exception e)
                            {
                                Debug.Print(e.Message);
                                Debug.Print(e.Source);
                                Debug.Print(e.StackTrace);
                            }
                        }
                        if (hType.Equals("File"))
                        {
                            if (shi.GrantedAccess == 0x0012019f
                              || shi.GrantedAccess == 0x001a019f
                              || shi.GrantedAccess == 0x00100000
                              || shi.GrantedAccess == 0x00160001
                              || shi.GrantedAccess == 0x00100001
                              || shi.GrantedAccess == 0x00100020)
                            {
                                continue;
                            }
                        }
                        else
                        {
                            using (var nto2 = new NtObject(hObj, ObjectInformationClass.ObjectNameInformation, typeof(OBJECT_NAME_INFORMATION)))
                            {
                                try
                                {
                                    var oni = ObjectNameInformationFromBuffer(nto2.Buffer);
                                    if (hType.Equals("File"))
                                    {
                                        hName = GetRegularFileNameFromDevice(oni.Name.ToString());
                                    }
                                    else
                                    {
                                        hName = oni.Name.ToString();
                                    }
                                }
                                catch (Exception e)
                                {
                                    Debug.Print(e.Message);
                                    Debug.Print(e.Source);
                                    Debug.Print(e.StackTrace);
                                }
                            }
                        }

                        HandleInfo hi = new HandleInfo();
                        hi.Handle = shi.HandleValue;
                        hi.Type = hType;
                        hi.Name = hName;
                        hi.CreatorBackTraceIndex = shi.CreatorBackTraceIndex;
                        hi.GrantedAccess = shi.GrantedAccess;
                        hi.HandleAttributes = shi.HandleAttributes;
                        hi.Object = shi.Object;
                        hi.ObjectTypeIndex = shi.ObjectTypeIndex;
                        hi.Reserved = shi.Reserved;
                        hi.UniqueProcessId = shi.UniqueProcessId;
                        yield return hi;
                    }
                    finally
                    {
                        CloseHandle(hObj);
                    }

                }
                CloseHandle(hProcess);
            }
        }

        static OBJECT_TYPE_INFORMATION ObjectTypeInformationFromBuffer(IntPtr buffer)
        {
            unsafe
            {
                return *(OBJECT_TYPE_INFORMATION*)buffer.ToPointer();
            }
        }

        static OBJECT_NAME_INFORMATION ObjectNameInformationFromBuffer(IntPtr buffer)
        {
            unsafe
            {
                return *(OBJECT_NAME_INFORMATION*)buffer.ToPointer();
            }
        }

        class NtObject : IDisposable
        {
            public NtObject(IntPtr hObj, ObjectInformationClass infoClass, Type type)
            {
                Init(hObj, infoClass, Marshal.SizeOf(type));
            }

            public NtObject(IntPtr hObj, ObjectInformationClass infoClass, int estimatedSize)
            {
                Init(hObj, infoClass, estimatedSize);
            }

            public void Init(IntPtr hObj, ObjectInformationClass infoClass, int estimatedSize)
            {
                Close();

                Buffer = Query(hObj, infoClass, estimatedSize);
            }

            public void Close()
            {
                if (Buffer != IntPtr.Zero)
                {
                    Marshal.FreeCoTaskMem(Buffer);
                    Buffer = IntPtr.Zero;
                }
            }

            public void Dispose()
            {
                Close();
            }

            public IntPtr Buffer { get; private set; }

            public static IntPtr Query(IntPtr hObj, ObjectInformationClass infoClass, int estimatedSize)
            {
                int size = estimatedSize;
                IntPtr buf = Marshal.AllocCoTaskMem(size);
                int retsize = 0;
                while (true)
                {
                    var ret = NtQueryObject(hObj, infoClass, buf, size, out retsize);
                    if (NT_SUCCESS(ret))
                        return buf;
                    if (ret == NT_STATUS.INFO_LENGTH_MISMATCH || ret == NT_STATUS.BUFFER_OVERFLOW)
                    {
                        buf = Marshal.ReAllocCoTaskMem(buf, retsize);
                        size = retsize;
                    }
                    else
                    {
                        Marshal.FreeCoTaskMem(buf);
                        return IntPtr.Zero;
                    }
                }
            }
        }

        static _SYSTEM_HANDLE_TABLE_ENTRY_INFO_EX SystemExtendedHandleFromPtr(IntPtr ptr, int offset)
        {
            unsafe
            {
                var p = (byte*)ptr.ToPointer() + offset;
                return *(_SYSTEM_HANDLE_TABLE_ENTRY_INFO_EX*)p;
            }
        }

        static int lastSizeUsed = 0x10000;

        static IEnumerable<_SYSTEM_HANDLE_TABLE_ENTRY_INFO_EX> EnumHandles(int processId)
        {
            int size = lastSizeUsed;
            IntPtr buffer = Marshal.AllocCoTaskMem(size);
            try
            {
                int required;
                while (NtQuerySystemInformation(SystemExtendedHandleInformation, buffer, size, out required) == NT_STATUS.INFO_LENGTH_MISMATCH)
                {
                    size = required;
                    buffer = Marshal.ReAllocCoTaskMem(buffer, size);
                }

                if (lastSizeUsed < size)
                    lastSizeUsed = size;

                int entrySize = Marshal.SizeOf(typeof(_SYSTEM_HANDLE_TABLE_ENTRY_INFO_EX));
                int offset = Marshal.SizeOf(typeof(IntPtr)) * 2;
                int handleCount = Marshal.ReadInt32(buffer);

                for (int i = 0; i < handleCount; i++)
                {
                    var shi = SystemExtendedHandleFromPtr(buffer, offset + entrySize * i);
                    if (shi.UniqueProcessId != new IntPtr(processId))
                        continue;

                    yield return shi;
                }
            }
            finally
            {
                if (buffer != IntPtr.Zero)
                    Marshal.FreeCoTaskMem(buffer);
            }
        }

        [DllImport("ntdll.dll")]
        static extern NT_STATUS NtQuerySystemInformation(
          int SystemInformationClass,
          IntPtr SystemInformation,
          int SystemInformationLength,
          out int ReturnLength);


        struct _SYSTEM_HANDLE_TABLE_ENTRY_INFO_EX
        {
            public IntPtr Object;
            public IntPtr UniqueProcessId;
            public IntPtr HandleValue;
            public uint GrantedAccess;
            public ushort CreatorBackTraceIndex;
            public ushort ObjectTypeIndex;
            public uint HandleAttributes;
            public uint Reserved;
        }

        const int SystemExtendedHandleInformation = 64;

        enum NT_STATUS : uint
        {
            SUCCESS = 0x00000000,
            BUFFER_OVERFLOW = 0x80000005,
            INFO_LENGTH_MISMATCH = 0xC0000004
        }

        static bool NT_SUCCESS(NT_STATUS status)
        {
            return ((uint)status & 0x80000000) == 0;
        }

        enum ObjectInformationClass : int
        {
            ObjectBasicInformation = 0,
            ObjectNameInformation = 1,
            ObjectTypeInformation = 2,
            ObjectAllTypesInformation = 3,
            ObjectHandleInformation = 4
        }

        [StructLayout(LayoutKind.Sequential)]
        struct OBJECT_NAME_INFORMATION
        {
            public UNICODE_STRING Name;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        struct UNICODE_STRING
        {
            private IntPtr reserved;
            public IntPtr Buffer;

            public ushort Length
            {
                get { return (ushort)(reserved.ToInt64() & 0xffff); }
            }
            public ushort MaximumLength
            {
                get { return (ushort)(reserved.ToInt64() >> 16); }
            }

            public override string ToString()
            {
                if (Buffer == IntPtr.Zero)
                    return "";
                return Marshal.PtrToStringUni(Buffer, Wcslen());
            }

            public int Wcslen()
            {
                unsafe
                {
                    ushort* p = (ushort*)Buffer.ToPointer();
                    for (ushort i = 0; i < Length; i++)
                    {
                        if (p[i] == 0)
                            return i;
                    }
                    return Length;
                }
            }

        }

        [StructLayout(LayoutKind.Sequential)]
        struct GENERIC_MAPPING
        {
            public int GenericRead;
            public int GenericWrite;
            public int GenericExecute;
            public int GenericAll;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        struct OBJECT_TYPE_INFORMATION
        {
            public UNICODE_STRING Name;
            public uint TotalNumberOfObjects;
            public uint TotalNumberOfHandles;
            public uint TotalPagedPoolUsage;
            public uint TotalNonPagedPoolUsage;
            public uint TotalNamePoolUsage;
            public uint TotalHandleTableUsage;
            public uint HighWaterNumberOfObjects;
            public uint HighWaterNumberOfHandles;
            public uint HighWaterPagedPoolUsage;
            public uint HighWaterNonPagedPoolUsage;
            public uint HighWaterNamePoolUsage;
            public uint HighWaterHandleTableUsage;
            public uint InvalidAttributes;
            public GENERIC_MAPPING GenericMapping;
            public uint ValidAccess;
            public byte SecurityRequired;
            public byte MaintainHandleCount;
            public ushort MaintainTypeList;
            public int PoolType;
            public int PagedPoolUsage;
            public int NonPagedPoolUsage;
        }

        static readonly string NETWORK_PREFIX = @"\Device\Mup\";

        static string GetRegularFileNameFromDevice(string strRawName)
        {
            if (strRawName.StartsWith(NETWORK_PREFIX))
                return @"\\" + strRawName.Substring(NETWORK_PREFIX.Length);

            string strFileName = strRawName;
            foreach (var drvPath in Environment.GetLogicalDrives())
            {
                var drv = drvPath.Substring(0, 2);
                var sb = new StringBuilder(MAX_PATH);
                if (QueryDosDevice(drv, sb, MAX_PATH) == 0)
                    return strRawName;

                string drvRoot = sb.ToString();
                if (strFileName.StartsWith(drvRoot))
                {
                    strFileName = drv + strFileName.Substring(drvRoot.Length);
                    break;
                }
            }
            return strFileName;
        }
    }
}
