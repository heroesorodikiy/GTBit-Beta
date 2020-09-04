using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

using static GTBit_Beta.Base.Imports;

namespace GTBit_Beta.Static
{
    static internal partial class Workflow
    {
        public static bool Active = false;

        public static int PerformClicks(List<ListViewItem> windowList, List<ListViewItem> clickList, int interval)
        {
            Active = true;
            while (Active)
            {
                foreach (ListViewItem click in clickList)
                {
                    if (!Active)
                    {
                        return 0;
                    }
                    else
                    {
                        foreach (ListViewItem window in windowList)
                        {
                            if (!Active)
                            {
                                return 0;
                            }
                            else
                            {
                                if (GetWindowHandle(window.SubItems[0].Text) != IntPtr.Zero)
                                {
                                    if (window.Checked)
                                    {
                                        SendMessage(GetWindowHandle(window.SubItems[0].Text), 0x201, 0x00000001, Coordinate(ToPoint(click)));
                                        SendMessage(GetWindowHandle(window.SubItems[0].Text), 0x202, 0x00000001, Coordinate(ToPoint(click)));
                                    }
                                }
                                else
                                {
                                    return 1;
                                }
                            }
                        }
                    }

                    Thread.Sleep(interval);
                }
            }

            return 0;
        }

        private static Point ToPoint(ListViewItem item)
        {
            return new Point(int.Parse(item.SubItems[0].Text), int.Parse(item.SubItems[1].Text));
        }
    }
}
