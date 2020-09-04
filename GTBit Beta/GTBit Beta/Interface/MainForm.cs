using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;

using GTBit_Beta.Static;
using GTBit_Beta.Base;

using static GTBit_Beta.Base.Imports;

namespace GTBit_Beta
{
    public partial class MainForm : Form
    {
        #region Variables

        private Mutex mutex = null;

        private MiniControl miniControl = new MiniControl();
        private MouseHook mouseHook = new MouseHook();

        private XMessageBox message = new XMessageBox();
        private XAbout about = new XAbout();

        private List<ListViewItem> windowList = new List<ListViewItem>();
        private List<ListViewItem> clickList = new List<ListViewItem>();

        private int ClickInterval = 200;
        private bool ShowMini = false;
        private bool Hotkeys = false;

        private Process primaryWindow = null;

        #endregion
       
        public MainForm()
        {
            InitializeComponent();

            mouseHook.MouseButtonDown += new MouseHook.MouseHookCallback(RecordMouseClick);
            RegisterHotKey(this.Handle, 1, 0x0000, (int)Keys.F1);
            RegisterHotKey(this.Handle, 2, 0x0000, (int)Keys.F2);

            miniControl.Owner = this;
            miniControl.Show();
            miniControl.Hide();

            miniControl.RecordEvent += (s, ee) => buttonRecord.PerformClick();
            miniControl.PlayEvent += (s, ee) => buttonPlay.PerformClick();

        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {
                if (tabControl1.SelectedIndex == 1 && !message.Visible && Hotkeys)
                {
                    if (m.WParam.ToInt32() == 1)
                    {
                        buttonRecord.PerformClick();
                    }
                    else if (m.WParam.ToInt32() == 2)
                    {
                        buttonPlay.PerformClick();
                    }
                }
            }
        }

        #region Form Functions

        private void Form1_Load(object sender, EventArgs e)
        {
            var webColors = Enum.GetValues(typeof(KnownColor)).Cast<KnownColor>().Where(kc => kc >= KnownColor.Transparent && kc < KnownColor.ButtonFace).Select(kc => Color.FromKnownColor(kc));
            foreach (var color in webColors)
            {
                if (!color.Name.Contains("Transparent") && !color.Name.Contains("White"))
                {
                    comboBoxColor.Items.Add(color.Name);
                }
            }

            Thread.Sleep(100);

            loadSettings();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            mouseHook.MouseButtonDown -= new MouseHook.MouseHookCallback(RecordMouseClick);
            mouseHook.Uninstall();

            UnregisterHotKey(this.Handle, 1);
            UnregisterHotKey(this.Handle, 2);

            saveSettings();

            Thread.Sleep(100);

            if (mutex != null)
            {
                mutex.Close();
                mutex.Dispose();
            }
           
            miniControl.Dispose();
            message.Dispose();
            about.Dispose();

            windowList.Clear();
            windowList = null;
            clickList.Clear();
            clickList = null;

            Thread.Sleep(100);

            foreach (Process proc in Process.GetProcessesByName("Growtopia"))
            {
                proc.Kill();
            }
        }

        private void ButtonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Form Styles

        #region MessageBox

        private void ShowMessage(string text)
        {
            if (this.TopMost)
            {
                message.TopMost = true;
            }
            else
            {
                message.TopMost = false;
            }

            message.content.Text = text;
            message.Owner = this;
            message.ShowDialog(Owner);
        }

        private void ShowAbout()
        {
            if (this.TopMost)
            {
                about.TopMost = true;
            }
            else
            {
                about.TopMost = false;
            }

            about.Owner = this;
            about.ShowDialog(Owner);
        }

        #endregion

        #region Color Related

        private void FrenzyMode_Tick(object sender, EventArgs e)
        {
            ChangeColor(ExtraColor.frenzyMode[ExtraColor.current++].Name);
            ExtraColor.current %= ExtraColor.frenzyMode.Count;
        }

        private void ChangeColor(string color)
        {
            Color newcolor = Color.FromName(color);

            this.BackColor = newcolor;
            buttonMinimize.ForeColor = newcolor;
            buttonClose.ForeColor = newcolor;
            labelLogo.ForeColor = newcolor;

            buttonTab1.ForeColor = newcolor;
            buttonTab2.ForeColor = newcolor;
            buttonTab3.ForeColor = newcolor;
            panelTabSelectorActive.BackColor = newcolor;

            // PAGE 1

            buttonLG.BackColor = newcolor;
            panelWL.BackColor = newcolor;
            labelWL.ForeColor = newcolor;
            listView1.ForeColor = newcolor;

            // PAGE 2

            if (buttonRecord.BackColor != Color.White)
            {
                buttonRecord.BackColor = newcolor;
            }

            if (buttonPlay.BackColor != Color.White)
            {
                buttonPlay.BackColor = newcolor;
            }

            panelML.BackColor = newcolor;
            labelMLX.ForeColor = newcolor;
            labelMLY.ForeColor = newcolor;
            listView2.ForeColor = newcolor;

            // PAGE 3

            labelCI.ForeColor = newcolor;
            TrackBarSlider.BackColor = newcolor;

            labelFC.ForeColor = newcolor;
            comboBoxColor.ForeColor = newcolor;

            labelSMC.ForeColor = newcolor;
            labelTM.ForeColor = newcolor;
            labelHK.ForeColor = newcolor;

            buttonAbout.BackColor = newcolor;

            if (ShowMini)
            {
                checkBoxSMC.BackColor = newcolor;
            }

            if (TopMost)
            {
                checkBoxTM.BackColor = newcolor;
            }

            if (Hotkeys)
            {
                checkBoxHK.BackColor = newcolor;
            }

            // MENU

            setAsPrimaryToolStripMenuItem.ForeColor = newcolor;
            closeToolStripMenuItem.ForeColor = newcolor;
            closeAllToolStripMenuItem.ForeColor = newcolor;
            removeToolStripMenuItem.ForeColor = newcolor;
            clearListToolStripMenuItem.ForeColor = newcolor;

            miniControl.updateStyle();
        }

        #endregion

        #region Move Form

        private int formX, formY = 0;
        private bool formDrag = false;

        private void PanelForm_MouseDown(object sender, MouseEventArgs e)
        {
            formDrag = true;
            formX = Cursor.Position.X - this.Left;
            formY = Cursor.Position.Y - this.Top;
        }

        private void PanelForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (formDrag)
            {
                this.Left = Cursor.Position.X - formX;
                this.Top = Cursor.Position.Y - formY;
            }
        }

        private void PanelForm_MouseUp(object sender, MouseEventArgs e)
        {
            formDrag = false;
        }

        private void Label1_MouseDown(object sender, MouseEventArgs e)
        {
            formDrag = true;
            formX = Cursor.Position.X - this.Left;
            formY = Cursor.Position.Y - this.Top;
        }

        private void Label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (formDrag)
            {
                this.Left = Cursor.Position.X - formX;
                this.Top = Cursor.Position.Y - formY;
            }
        }

        private void Label1_MouseUp(object sender, MouseEventArgs e)
        {
            formDrag = false;
        }

        #endregion

        #region Tab Selector

        private void lockTabs()
        {
            if (buttonRecord.Text == "Stop" || buttonPlay.Text == "Stop")
            {
                buttonTab1.ForeColor = Color.FromArgb(50, 50, 50);
                buttonTab3.ForeColor = Color.FromArgb(50, 50, 50);

                buttonTab1.Enabled = false;
                buttonTab3.Enabled = false;
            }
            else
            {
                buttonTab1.ForeColor = this.BackColor;
                buttonTab3.ForeColor = this.BackColor;

                buttonTab1.Enabled = true;
                buttonTab3.Enabled = true;
            }
        }

        private void ButtonTab1_Click(object sender, EventArgs e)
        {
            panelTabSelectorActive.Location = new Point(buttonTab1.Location.X, panelTabSelectorActive.Location.Y);

            tabControl1.SelectedIndex = 0;

            if (ShowMini)
            {
                if (miniControl.Visible)
                    miniControl.Hide();
            }
        }

        private void ButtonTab2_Click(object sender, EventArgs e)
        {
            panelTabSelectorActive.Location = new Point(buttonTab2.Location.X, panelTabSelectorActive.Location.Y);

            tabControl1.SelectedIndex = 1;

            if (ShowMini)
            {
                if (!miniControl.Visible)
                    miniControl.Show();
            }

            if (miniControl.DesktopLocation.X != 0 || miniControl.DesktopLocation.Y != 0)
            {
                miniControl.SetDesktopLocation(0, 0);
            }
        }

        private void ButtonTab3_Click(object sender, EventArgs e)
        {
            if (buttonRecord.Text != "Stop" && buttonPlay.Text != "Stop")
            {
                panelTabSelectorActive.Location = new Point(buttonTab3.Location.X, panelTabSelectorActive.Location.Y);

                tabControl1.SelectedIndex = 2;

                if (ShowMini)
                {
                    if (miniControl.Visible)
                        miniControl.Hide();
                }
            }
        }

        #endregion

        #region TrackBar

        private int sliderX = 0;
        private bool sliderDrag = false;

        private void TrackBarSlider_MouseDown(object sender, MouseEventArgs e)
        {
            sliderDrag = true;
            sliderX = Cursor.Position.X - TrackBarSlider.Left;
        }

        private void TrackBarSlider_MouseMove(object sender, MouseEventArgs e)
        {
            if (sliderDrag)
            {
                TrackBarSlider.Left = Cursor.Position.X - sliderX;

                if (TrackBarSlider.Location.X < 0)
                {
                    while (TrackBarSlider.Location.X < 0)
                    {
                        TrackBarSlider.Location = new Point(0, 0);
                    }
                }
                else if (TrackBarSlider.Location.X > 150)
                {
                    while (TrackBarSlider.Location.X > 150)
                    {
                        TrackBarSlider.Location = new Point(150, 0);
                    }
                }

                if (TrackBarSlider.Location.X < 25)
                {
                    labelCI.Text = "Click Interval : " + 200.ToString();
                }
                else if (TrackBarSlider.Location.X >= 25 && TrackBarSlider.Location.X < 50)
                {
                    labelCI.Text = "Click Interval : " + 250.ToString();
                }
                else if (TrackBarSlider.Location.X >= 50 && TrackBarSlider.Location.X < 75)
                {
                    labelCI.Text = "Click Interval : " + 300.ToString();
                }
                else if (TrackBarSlider.Location.X >= 75 && TrackBarSlider.Location.X < 100)
                {
                    labelCI.Text = "Click Interval : " + 350.ToString();
                }
                else if (TrackBarSlider.Location.X >= 100 && TrackBarSlider.Location.X < 125)
                {
                    labelCI.Text = "Click Interval : " + 400.ToString();
                }
                else if (TrackBarSlider.Location.X >= 125 && TrackBarSlider.Location.X < 150)
                {
                    labelCI.Text = "Click Interval : " + 450.ToString();
                }
                else if (TrackBarSlider.Location.X >= 150 && TrackBarSlider.Location.X < 160)
                {
                    labelCI.Text = "Click Interval : " + 500.ToString();
                }
            }
        }

        private void TrackBarSlider_MouseUp(object sender, MouseEventArgs e)
        {
            sliderDrag = false;

            if (TrackBarSlider.Location.X < 25)
            {
                ClickInterval = 200;
                TrackBarSlider.Location = new Point(0, 0);
            }
            else if (TrackBarSlider.Location.X >= 25 && TrackBarSlider.Location.X < 50)
            {
                ClickInterval = 250;
                TrackBarSlider.Location = new Point(25, 0);
            }
            else if (TrackBarSlider.Location.X >= 50 && TrackBarSlider.Location.X < 75)
            {
                ClickInterval = 300;
                TrackBarSlider.Location = new Point(50, 0);
            }
            else if (TrackBarSlider.Location.X >= 75 && TrackBarSlider.Location.X < 100)
            {
                ClickInterval = 350;
                TrackBarSlider.Location = new Point(75, 0);
            }
            else if (TrackBarSlider.Location.X >= 100 && TrackBarSlider.Location.X < 125)
            {
                ClickInterval = 400;
                TrackBarSlider.Location = new Point(100, 0);
            }
            else if (TrackBarSlider.Location.X >= 125 && TrackBarSlider.Location.X < 150)
            {
                ClickInterval = 450;
                TrackBarSlider.Location = new Point(125, 0);
            }
            else if (TrackBarSlider.Location.X >= 150 && TrackBarSlider.Location.X < 160)
            {
                ClickInterval = 500;
                TrackBarSlider.Location = new Point(150, 0);
            }
        }

        #endregion

        #endregion

        #region Settings

        private void loadSettings()
        {
            if (File.Exists("GTBitSettings.ini"))
            {
                var ini = new IniFile("GTBitSettings.ini");
                {
                    // Click interval & slider
                    ClickInterval = int.Parse(ini.Read("ClickInterval"));
                    labelCI.Text = "Click Interval : " + ClickInterval;

                    TrackBarSlider.Location = new Point(int.Parse(ini.Read("TrackBarSlider")), TrackBarSlider.Location.Y);

                    // Color
                    var color = ini.Read("FormColor");
                    if (color == "FrenzyMode 1x")
                    {
                        FrenzyMode.Interval = 100;
                        if (!FrenzyMode.Enabled)
                            FrenzyMode.Start();

                        comboBoxColor.SelectedIndex = comboBoxColor.FindString("FrenzyMode 1x");
                    }
                    else if (color == "FrenzyMode 2x")
                    {
                        FrenzyMode.Interval = 50;
                        if (!FrenzyMode.Enabled)
                            FrenzyMode.Start();

                        comboBoxColor.SelectedIndex = comboBoxColor.FindString("FrenzyMode 2x");
                    }
                    else if (color == "FrenzyMode 3x")
                    {
                        FrenzyMode.Interval = 25;
                        if (!FrenzyMode.Enabled)
                            FrenzyMode.Start();

                        comboBoxColor.SelectedIndex = comboBoxColor.FindString("FrenzyMode 3x");
                    }
                    else if (color == "FrenzyMode 4x")
                    {
                        FrenzyMode.Interval = 5;
                        if (!FrenzyMode.Enabled)
                            FrenzyMode.Start();

                        comboBoxColor.SelectedIndex = comboBoxColor.FindString("FrenzyMode 4x");
                    }
                    else
                    {
                        if (FrenzyMode.Enabled)
                            FrenzyMode.Stop();

                        ChangeColor(color);
                        comboBoxColor.SelectedIndex = comboBoxColor.FindString(color);
                    }

                    // Mini control
                    if (ini.Read("ShowMini") == "true")
                    {
                        ShowMini = true;
                    }
                    else
                    {
                        ShowMini = false;
                    }

                    // TopMost
                    if (ini.Read("TopMost") == "true")
                    {
                        this.TopMost = true;
                    }
                    else
                    {
                        this.TopMost = false;
                    }

                    // Hotkeys
                    if (ini.Read("Hotkeys") == "true")
                    {
                        Hotkeys = true;
                    }
                    else
                    {
                        Hotkeys = false;
                    }
                }
            }
            else
            {
                ClickInterval = 200;
                ShowMini = false;
                this.TopMost = false;

                FrenzyMode.Interval = 100;
                if (!FrenzyMode.Enabled)
                    FrenzyMode.Start();

                comboBoxColor.SelectedIndex = comboBoxColor.FindString("FrenzyMode 1x");
            }
        }

        private void saveSettings()
        {
            var ini = new IniFile("GTBitSettings.ini");
            {
                ini.Write("ClickInterval", ClickInterval.ToString());
                ini.Write("TrackBarSlider", TrackBarSlider.Location.X.ToString());

                // Color
                if (comboBoxColor.GetItemText(comboBoxColor.SelectedItem).Contains("FrenzyMode"))
                {
                    ini.Write("FormColor", comboBoxColor.GetItemText(comboBoxColor.SelectedItem));
                }
                else
                {
                    ini.Write("FormColor", this.BackColor.Name);
                }

                // Mini control
                if (ShowMini)
                {
                    ini.Write("ShowMini", "true");
                }
                else
                {
                    ini.Write("ShowMini", "false");
                }

                // Top Most
                if (this.TopMost)
                {
                    ini.Write("TopMost", "true");
                }
                else
                {
                    ini.Write("TopMost", "false");
                }

                // Hotkeys
                if (Hotkeys)
                {
                    ini.Write("Hotkeys", "true");
                }
                else
                {
                    ini.Write("Hotkeys", "false");
                }
            }
        }

        #endregion

        #region Page 1

        private void ButtonLaunchGrowtopia_Click(object sender, EventArgs e)
        {
            if (buttonLG.Enabled)
            {
                buttonLG.Text = "Wait...";
                buttonLG.Enabled = false;

                LaunchGrowtopia();

                buttonLG.Enabled = true;
                buttonLG.Text = "Launch Growtopia";
            }
            else
            {
                ShowMessage("Please wait!");
            }
        }

        private void LaunchGrowtopia()
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Growtopia");
            string path = (string)registryKey.GetValue("path", "null") + @"\Growtopia.exe";
            registryKey.Dispose();

            if (File.Exists(path))
            {
                // Suspend all Growtopia
                foreach (var procs in Process.GetProcessesByName("Growtopia"))
                {
                    SuspendProcess(procs.Id);
                }

                Thread.Sleep(100);

                // Close own mutex
                if (mutex != null)
                {
                    mutex.Close();
                }

                // Run Growtopia and wait to initialize
                Process proc = Process.Start(path);
                proc.WaitForInputIdle();
                proc.WaitForInputIdle();
                proc.WaitForInputIdle();

                Thread.Sleep(100);

                // Set own mutex value
                mutex = new Mutex(true, "Growtopia");

                Thread.Sleep(100);

                // Close Growtopia mutex
                foreach (HandleInfo hi in Handles.EnumProcessHandles(proc.Id))
                {
                    if (hi.Type == "Mutant" && hi.Name.EndsWith("Growtopia"))
                    {
                        Handles.CloseHandleEx(proc.Id, hi.Handle);
                    }
                }

                Thread.Sleep(100);

                // Resume all Growtopia
                foreach (var procs in Process.GetProcessesByName("Growtopia"))
                {
                    ResumeProcess(procs.Id);
                }

                // Add item to listview and sort
                SetWindowText(proc.MainWindowHandle, "Growtopia " + GetWindowNumber());
                listView1.Items.Add(proc.MainWindowTitle).Checked = true;
                SortList();

                // Detect process exit
                proc.EnableRaisingEvents = true;
                proc.Exited += (ss, ee) => Process_Exited(ss, ee, proc);
            }
            else
            {
                ShowMessage("Unable to locate Growtopia,\nPlease re-install.");
            }
        }

        private void Process_Exited(object sender, EventArgs e, Process proc)
        {
            this.Invoke((MethodInvoker)delegate
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.Text == proc.MainWindowTitle)
                    {
                        if (primaryWindow != null)
                        {
                            if (proc.MainWindowTitle == primaryWindow.MainWindowTitle)
                            {
                                toNull();
                            }
                        }

                        item.Remove();
                    }
                }
            });
        }

        private void toNull()
        {
            primaryWindow = null;
        }

        private string GetWindowNumber()
        {
            string items = "";
            string num = "";

            foreach (Process proc in Process.GetProcessesByName("Growtopia"))
            {
                items += proc.MainWindowTitle;
            }

            for (int i = 1; i < 999; i++)
            {
                num += "[" + i.ToString() + "]-";
            }

            num = num.Remove(num.Length - 1);
            string[] array = num.Split('-');

            foreach (string xnum in array)
            {
                if (!items.Contains(xnum))
                {
                    return xnum;
                }
            }

            return num;
        }

        private void SortList()
        {
            ListViewSorter Sorter = new ListViewSorter();
            listView1.ListViewItemSorter = Sorter;

            listView1.Sorting = SortOrder.Descending;
            listView1.Sort();
        }

        private void Menu1_Opening(object sender, CancelEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (primaryWindow != null && primaryWindow.MainWindowTitle == listView1.SelectedItems[0].Text)
                {
                    setAsPrimaryToolStripMenuItem.Enabled = false;
                }
                else
                {
                    setAsPrimaryToolStripMenuItem.Enabled = true;
                }

                closeToolStripMenuItem.Enabled = true;
            }
            else
            {
                setAsPrimaryToolStripMenuItem.Enabled = false;
                closeToolStripMenuItem.Enabled = false;
            }

            if (listView1.Items.Count < 1)
            {
                closeAllToolStripMenuItem.Enabled = false;
            }
            else
            {
                closeAllToolStripMenuItem.Enabled = true;
            }
        }

        private void setAsPrimaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Process proc in Process.GetProcessesByName("Growtopia"))
            {
                if (proc.MainWindowTitle == listView1.SelectedItems[0].Text)
                {
                    primaryWindow = proc;
                }
            }
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Process proc in Process.GetProcessesByName("Growtopia"))
            {
                if (proc.MainWindowTitle == listView1.SelectedItems[0].Text)
                {
                    proc.Kill();
                }
            }
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Process proc in Process.GetProcessesByName("Growtopia"))
            {
                proc.Kill();
            }
        }

        #endregion

        // Always look for improvement...
        #region Page 2

        #region Record

        private void ButtonRecord_Click(object sender, EventArgs e)
        {

            if (primaryWindow != null)
            {
                if (listView1.Items.Count > 0)
                {
                    if (buttonPlay.Text != "Stop")
                    {
                        if (buttonRecord.Text == "Record")
                        {
                            buttonRecord.Text = "Stop";
                            buttonRecord.BackColor = Color.White;

                            miniControl.updateButtons();

                            lockTabs();

                            mouseHook.Install();
                            SetForegroundWindow(primaryWindow.MainWindowHandle);
                        }
                        else
                        {
                            mouseHook.Uninstall();

                            buttonRecord.Text = "Record";
                            buttonRecord.BackColor = this.BackColor;

                            miniControl.updateButtons();

                            lockTabs();
                        }
                    }
                    else
                    {
                        ShowMessage("You should stop Play mode first.");
                    }
                }
                else
                {
                    ShowMessage("Growtopia window list is empty.");
                }
            }
            else
            {
                ShowMessage("Primary window is not set.");
            }
        }

        private void RecordMouseClick(MouseHook.MSLLHOOKSTRUCT button)
        {
            if (primaryWindow != null)
            {
                RECT wrc;
                GetWindowRect(primaryWindow.MainWindowHandle, out wrc);

                RECT crc;
                GetClientRect(primaryWindow.MainWindowHandle, out crc);

                Point lefttop = new Point(crc.Left, crc.Top);
                ClientToScreen(primaryWindow.MainWindowHandle, out lefttop);

                Point rightbottom = new Point(crc.Right, crc.Bottom);
                ClientToScreen(primaryWindow.MainWindowHandle, out rightbottom);

                int wintop = lefttop.Y - wrc.Top;
                int winbottom = wrc.Bottom - rightbottom.Y;
                int winleft = lefttop.X - wrc.Left;
                int winright = wrc.Right - rightbottom.X;

                int winwidth = wrc.Right - wrc.Left - winleft - winright;
                int winheight = wrc.Bottom - wrc.Top - wintop - winbottom;

                int xpos = Cursor.Position.X - wrc.Left - winleft;
                int ypos = Cursor.Position.Y - wrc.Top - wintop;

                if (GetForegroundWindow() == primaryWindow.MainWindowHandle)
                {
                    if (xpos >= 0 && ypos >= 0 && xpos <= winwidth && ypos <= winheight)
                    {
                        ListViewItem lvi = new ListViewItem(new string[] { xpos.ToString(), ypos.ToString() });
                        listView2.Items.Add(lvi);
                    }
                }
            }
            else
            {
                mouseHook.Uninstall();

                buttonRecord.Text = "Record";
                buttonRecord.BackColor = this.BackColor;

                miniControl.updateButtons();

                lockTabs();

                ShowMessage("It seems the primary window has\nexited.");
            }
        }

        #endregion

        #region Play

        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                if (listView2.Items.Count > 0)
                {
                    if (buttonRecord.Text != "Stop")
                    {
                        if (!Workflow.Active)
                        {
                            buttonPlay.Text = "Stop";
                            buttonPlay.BackColor = Color.White;
                            miniControl.updateButtons();
                            lockTabs();

                            lock (windowList)
                            {
                                windowList.Clear();
                                windowList = GetListViewItems(listView1).Cast<ListViewItem>().Select(item => item).ToList();
                            }
                            lock (clickList)
                            {
                                clickList.Clear();
                                clickList = GetListViewItems(listView2).Cast<ListViewItem>().Select(item => item).ToList();
                            }

                            Thread thread = new Thread(() =>
                            {
                                Workflow.Active = true;

                                if (Workflow.PerformClicks(windowList, clickList, ClickInterval) == 1)
                                {
                                    Invoke((MethodInvoker)delegate
                                    {
                                        ShowMessage("The Growtopia window list has\nbeen modified or one of the\nGrowtopia windows has\nbeen closed.");
                                    });
                                }

                                Workflow.Active = false;

                                Invoke((MethodInvoker)delegate
                                {
                                    buttonPlay.Text = "Play";
                                    buttonPlay.BackColor = this.BackColor;
                                    miniControl.updateButtons();
                                    lockTabs();
                                });

                            });

                            thread.SetApartmentState(ApartmentState.STA);
                            thread.Start();
                        }
                        else
                        {
                            Workflow.Active = false;
                        }
                    }
                    else
                    {
                        ShowMessage("You should stop Record mode first.");
                    }
                }
                else
                {
                    ShowMessage("Clicks list is empty.");
                }
            }
            else
            {
                ShowMessage("Growtopia window list is empty.");
            }
        }

        private delegate ListView.ListViewItemCollection GetItems(ListView listview);

        private ListView.ListViewItemCollection GetListViewItems(ListView listview)
        {
            ListView.ListViewItemCollection temp = new ListView.ListViewItemCollection(new ListView());
            if (!listview.InvokeRequired)
            {
                foreach (ListViewItem item in listview.Items)
                {
                    temp.Add((ListViewItem)item.Clone());
                }
                   
                return temp;
            }
            else
            {
                return (ListView.ListViewItemCollection)this.Invoke(new GetItems(GetListViewItems), new object[] { listview });
            }   
        }

        #endregion

        #region Menu

        private void RemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView2.Items.Remove(listView2.SelectedItems[0]);
        }

        private void ClearListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView2.Items)
            {
                listView2.Items.Remove(item);
            }
        }

        private void Menu2_Opening(object sender, CancelEventArgs e)
        {
            if (buttonPlay.Text == "Stop")
            {
                removeToolStripMenuItem.Enabled = false;
                clearListToolStripMenuItem.Enabled = false;
            }
            else
            {
                if (listView2.SelectedItems.Count == 0)
                {
                    removeToolStripMenuItem.Enabled = false;
                }
                else
                {
                    removeToolStripMenuItem.Enabled = true;
                }
                if (listView2.Items.Count < 1)
                {
                    clearListToolStripMenuItem.Enabled = false;
                }
                else
                {
                    clearListToolStripMenuItem.Enabled = true;
                }
            }
        }

        #endregion

        #endregion

        #region Page 3

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxColor.GetItemText(comboBoxColor.SelectedItem) == "FrenzyMode 1x")
            {
                FrenzyMode.Interval = 100;
                if (!FrenzyMode.Enabled)
                    FrenzyMode.Start();
            }
            else if (comboBoxColor.GetItemText(comboBoxColor.SelectedItem) == "FrenzyMode 2x")
            {
                FrenzyMode.Interval = 50;
                if (!FrenzyMode.Enabled)
                    FrenzyMode.Start();
            }
            else if (comboBoxColor.GetItemText(comboBoxColor.SelectedItem) == "FrenzyMode 3x")
            {
                FrenzyMode.Interval = 25;
                if (!FrenzyMode.Enabled)
                    FrenzyMode.Start();
            }
            else if (comboBoxColor.GetItemText(comboBoxColor.SelectedItem) == "FrenzyMode 4x")
            {
                FrenzyMode.Interval = 5;
                if (!FrenzyMode.Enabled)
                    FrenzyMode.Start();
            }
            else
            {
                if (FrenzyMode.Enabled)
                    FrenzyMode.Stop();

                ChangeColor(comboBoxColor.SelectedItem.ToString());
            }
        }

        private void CheckBoxSMC_Click(object sender, EventArgs e)
        {
            if (ShowMini == false)
            {
                ShowMini = true;
                checkBoxSMC.BackColor = this.BackColor;
            }
            else
            {
                ShowMini = false;
                checkBoxSMC.BackColor = Color.FromArgb(50, 50, 50);
            }
        }

        private void CheckBoxTM_Click(object sender, EventArgs e)
        {
            if (!this.TopMost)
            {
                this.TopMost = true;
                checkBoxTM.BackColor = this.BackColor;
            }
            else
            {
                this.TopMost = false;
                checkBoxTM.BackColor = Color.FromArgb(50, 50, 50);
            }
        }

        private void checkBoxHK_Click(object sender, EventArgs e)
        {
            if (!Hotkeys)
            {
                Hotkeys = true;
                checkBoxHK.BackColor = this.BackColor;
            }
            else
            {
                Hotkeys = false;
                checkBoxHK.BackColor = Color.FromArgb(50, 50, 50);
            }
        }

        private void ButtonAbout_Click(object sender, EventArgs e)
        {
            ShowAbout();
        }

        #endregion
    }
}
