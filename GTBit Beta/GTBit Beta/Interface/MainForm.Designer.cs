namespace GTBit_Beta
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelForm = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.TabSelector = new System.Windows.Forms.Panel();
            this.buttonTab1 = new System.Windows.Forms.Button();
            this.buttonTab3 = new System.Windows.Forms.Button();
            this.buttonTab2 = new System.Windows.Forms.Button();
            this.panelTabSelectorActive = new System.Windows.Forms.Panel();
            this.panelTabControl = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelWL = new System.Windows.Forms.Panel();
            this.panelWLH = new System.Windows.Forms.Panel();
            this.labelWL = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Menu1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setAsPrimaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonLG = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelML = new System.Windows.Forms.Panel();
            this.panelMLH = new System.Windows.Forms.Panel();
            this.labelMLY = new System.Windows.Forms.Label();
            this.labelMLX = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Menu2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonRecord = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelTM = new System.Windows.Forms.Label();
            this.panelTM = new System.Windows.Forms.Panel();
            this.checkBoxTM = new System.Windows.Forms.Button();
            this.labelSMC = new System.Windows.Forms.Label();
            this.panelSMC = new System.Windows.Forms.Panel();
            this.checkBoxSMC = new System.Windows.Forms.Button();
            this.panelTrackBar = new System.Windows.Forms.Panel();
            this.TrackBarSlider = new System.Windows.Forms.Button();
            this.panelTrackBar2 = new System.Windows.Forms.Panel();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.labelFC = new System.Windows.Forms.Label();
            this.labelCI = new System.Windows.Forms.Label();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.labelLogo = new System.Windows.Forms.Label();
            this.FrenzyMode = new System.Windows.Forms.Timer(this.components);
            this.labelHK = new System.Windows.Forms.Label();
            this.panelHK = new System.Windows.Forms.Panel();
            this.checkBoxHK = new System.Windows.Forms.Button();
            this.panelForm.SuspendLayout();
            this.TabSelector.SuspendLayout();
            this.panelTabControl.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelWL.SuspendLayout();
            this.panelWLH.SuspendLayout();
            this.Menu1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelML.SuspendLayout();
            this.panelMLH.SuspendLayout();
            this.Menu2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panelTM.SuspendLayout();
            this.panelSMC.SuspendLayout();
            this.panelTrackBar.SuspendLayout();
            this.panelHK.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelForm
            // 
            this.panelForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panelForm.Controls.Add(this.buttonMinimize);
            this.panelForm.Controls.Add(this.buttonClose);
            this.panelForm.Controls.Add(this.TabSelector);
            this.panelForm.Controls.Add(this.panelTabControl);
            this.panelForm.Controls.Add(this.labelLogo);
            this.panelForm.Location = new System.Drawing.Point(0, 5);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(270, 499);
            this.panelForm.TabIndex = 2;
            this.panelForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelForm_MouseDown);
            this.panelForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelForm_MouseMove);
            this.panelForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelForm_MouseUp);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.buttonMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimize.ForeColor = System.Drawing.Color.Lime;
            this.buttonMinimize.Location = new System.Drawing.Point(219, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(20, 25);
            this.buttonMinimize.TabIndex = 0;
            this.buttonMinimize.TabStop = false;
            this.buttonMinimize.Text = "o";
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.ButtonMinimize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.Lime;
            this.buttonClose.Location = new System.Drawing.Point(242, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(20, 25);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "o";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // TabSelector
            // 
            this.TabSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabSelector.Controls.Add(this.buttonTab1);
            this.TabSelector.Controls.Add(this.buttonTab3);
            this.TabSelector.Controls.Add(this.buttonTab2);
            this.TabSelector.Controls.Add(this.panelTabSelectorActive);
            this.TabSelector.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabSelector.Location = new System.Drawing.Point(28, 71);
            this.TabSelector.Name = "TabSelector";
            this.TabSelector.Size = new System.Drawing.Size(210, 34);
            this.TabSelector.TabIndex = 0;
            // 
            // buttonTab1
            // 
            this.buttonTab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.buttonTab1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.buttonTab1.FlatAppearance.BorderSize = 0;
            this.buttonTab1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.buttonTab1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.buttonTab1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.buttonTab1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTab1.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTab1.ForeColor = System.Drawing.Color.Lime;
            this.buttonTab1.Location = new System.Drawing.Point(0, 0);
            this.buttonTab1.Name = "buttonTab1";
            this.buttonTab1.Size = new System.Drawing.Size(70, 31);
            this.buttonTab1.TabIndex = 0;
            this.buttonTab1.TabStop = false;
            this.buttonTab1.Text = "Home";
            this.buttonTab1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTab1.UseVisualStyleBackColor = false;
            this.buttonTab1.Click += new System.EventHandler(this.ButtonTab1_Click);
            // 
            // buttonTab3
            // 
            this.buttonTab3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.buttonTab3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.buttonTab3.FlatAppearance.BorderSize = 0;
            this.buttonTab3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.buttonTab3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.buttonTab3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.buttonTab3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTab3.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTab3.ForeColor = System.Drawing.Color.Lime;
            this.buttonTab3.Location = new System.Drawing.Point(140, 0);
            this.buttonTab3.Name = "buttonTab3";
            this.buttonTab3.Size = new System.Drawing.Size(70, 31);
            this.buttonTab3.TabIndex = 0;
            this.buttonTab3.TabStop = false;
            this.buttonTab3.Text = "Settings";
            this.buttonTab3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTab3.UseVisualStyleBackColor = false;
            this.buttonTab3.Click += new System.EventHandler(this.ButtonTab3_Click);
            // 
            // buttonTab2
            // 
            this.buttonTab2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.buttonTab2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.buttonTab2.FlatAppearance.BorderSize = 0;
            this.buttonTab2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.buttonTab2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.buttonTab2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.buttonTab2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTab2.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTab2.ForeColor = System.Drawing.Color.Lime;
            this.buttonTab2.Location = new System.Drawing.Point(70, 0);
            this.buttonTab2.Name = "buttonTab2";
            this.buttonTab2.Size = new System.Drawing.Size(70, 31);
            this.buttonTab2.TabIndex = 0;
            this.buttonTab2.TabStop = false;
            this.buttonTab2.Text = "Macro";
            this.buttonTab2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTab2.UseVisualStyleBackColor = false;
            this.buttonTab2.Click += new System.EventHandler(this.ButtonTab2_Click);
            // 
            // panelTabSelectorActive
            // 
            this.panelTabSelectorActive.BackColor = System.Drawing.Color.Lime;
            this.panelTabSelectorActive.Location = new System.Drawing.Point(0, 30);
            this.panelTabSelectorActive.Name = "panelTabSelectorActive";
            this.panelTabSelectorActive.Size = new System.Drawing.Size(65, 4);
            this.panelTabSelectorActive.TabIndex = 0;
            // 
            // panelTabControl
            // 
            this.panelTabControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panelTabControl.Controls.Add(this.tabControl1);
            this.panelTabControl.Location = new System.Drawing.Point(25, 121);
            this.panelTabControl.Name = "panelTabControl";
            this.panelTabControl.Size = new System.Drawing.Size(220, 353);
            this.panelTabControl.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ItemSize = new System.Drawing.Size(58, 0);
            this.tabControl1.Location = new System.Drawing.Point(-4, -22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(228, 379);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tabPage1.Controls.Add(this.panelWL);
            this.tabPage1.Controls.Add(this.buttonLG);
            this.tabPage1.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(220, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // panelWL
            // 
            this.panelWL.BackColor = System.Drawing.Color.Lime;
            this.panelWL.Controls.Add(this.panelWLH);
            this.panelWL.Controls.Add(this.listView1);
            this.panelWL.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelWL.Location = new System.Drawing.Point(10, 73);
            this.panelWL.Name = "panelWL";
            this.panelWL.Size = new System.Drawing.Size(200, 270);
            this.panelWL.TabIndex = 1;
            // 
            // panelWLH
            // 
            this.panelWLH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panelWLH.Controls.Add(this.labelWL);
            this.panelWLH.Location = new System.Drawing.Point(2, 2);
            this.panelWLH.Name = "panelWLH";
            this.panelWLH.Size = new System.Drawing.Size(196, 35);
            this.panelWLH.TabIndex = 0;
            // 
            // labelWL
            // 
            this.labelWL.AutoSize = true;
            this.labelWL.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWL.ForeColor = System.Drawing.Color.Lime;
            this.labelWL.Location = new System.Drawing.Point(10, 10);
            this.labelWL.Name = "labelWL";
            this.labelWL.Size = new System.Drawing.Size(79, 17);
            this.labelWL.TabIndex = 0;
            this.labelWL.Text = "Window List";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.ContextMenuStrip = this.Menu1;
            this.listView1.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.Lime;
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(2, 41);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(196, 227);
            this.listView1.TabIndex = 0;
            this.listView1.TabStop = false;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Window Title";
            this.columnHeader1.Width = 170;
            // 
            // Menu1
            // 
            this.Menu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Menu1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setAsPrimaryToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.closeAllToolStripMenuItem});
            this.Menu1.Name = "Menu1";
            this.Menu1.ShowImageMargin = false;
            this.Menu1.ShowItemToolTips = false;
            this.Menu1.Size = new System.Drawing.Size(140, 70);
            this.Menu1.Opening += new System.ComponentModel.CancelEventHandler(this.Menu1_Opening);
            // 
            // setAsPrimaryToolStripMenuItem
            // 
            this.setAsPrimaryToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.setAsPrimaryToolStripMenuItem.Name = "setAsPrimaryToolStripMenuItem";
            this.setAsPrimaryToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.setAsPrimaryToolStripMenuItem.Text = "Set as Primary";
            this.setAsPrimaryToolStripMenuItem.Click += new System.EventHandler(this.setAsPrimaryToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.closeAllToolStripMenuItem.Text = "Close All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // buttonLG
            // 
            this.buttonLG.BackColor = System.Drawing.Color.Lime;
            this.buttonLG.FlatAppearance.BorderSize = 0;
            this.buttonLG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLG.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLG.ForeColor = System.Drawing.Color.Black;
            this.buttonLG.Location = new System.Drawing.Point(10, 10);
            this.buttonLG.Name = "buttonLG";
            this.buttonLG.Size = new System.Drawing.Size(200, 50);
            this.buttonLG.TabIndex = 0;
            this.buttonLG.TabStop = false;
            this.buttonLG.Text = "Launch Growtopia";
            this.buttonLG.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonLG.UseVisualStyleBackColor = false;
            this.buttonLG.Click += new System.EventHandler(this.ButtonLaunchGrowtopia_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tabPage2.Controls.Add(this.panelML);
            this.tabPage2.Controls.Add(this.buttonPlay);
            this.tabPage2.Controls.Add(this.buttonRecord);
            this.tabPage2.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(220, 353);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // panelML
            // 
            this.panelML.BackColor = System.Drawing.Color.Lime;
            this.panelML.Controls.Add(this.panelMLH);
            this.panelML.Controls.Add(this.listView2);
            this.panelML.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelML.Location = new System.Drawing.Point(10, 73);
            this.panelML.Name = "panelML";
            this.panelML.Size = new System.Drawing.Size(200, 270);
            this.panelML.TabIndex = 0;
            // 
            // panelMLH
            // 
            this.panelMLH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panelMLH.Controls.Add(this.labelMLY);
            this.panelMLH.Controls.Add(this.labelMLX);
            this.panelMLH.Location = new System.Drawing.Point(2, 2);
            this.panelMLH.Name = "panelMLH";
            this.panelMLH.Size = new System.Drawing.Size(196, 35);
            this.panelMLH.TabIndex = 0;
            // 
            // labelMLY
            // 
            this.labelMLY.AutoSize = true;
            this.labelMLY.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMLY.ForeColor = System.Drawing.Color.Lime;
            this.labelMLY.Location = new System.Drawing.Point(95, 10);
            this.labelMLY.Name = "labelMLY";
            this.labelMLY.Size = new System.Drawing.Size(17, 17);
            this.labelMLY.TabIndex = 0;
            this.labelMLY.Text = "Y";
            // 
            // labelMLX
            // 
            this.labelMLX.AutoSize = true;
            this.labelMLX.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMLX.ForeColor = System.Drawing.Color.Lime;
            this.labelMLX.Location = new System.Drawing.Point(10, 10);
            this.labelMLX.Name = "labelMLX";
            this.labelMLX.Size = new System.Drawing.Size(17, 17);
            this.labelMLX.TabIndex = 0;
            this.labelMLX.Text = "X";
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.listView2.ContextMenuStrip = this.Menu2;
            this.listView2.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.ForeColor = System.Drawing.Color.Lime;
            this.listView2.FullRowSelect = true;
            this.listView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(2, 41);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(196, 227);
            this.listView2.TabIndex = 0;
            this.listView2.TabStop = false;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Window Title";
            this.columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 85;
            // 
            // Menu2
            // 
            this.Menu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Menu2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem,
            this.clearListToolStripMenuItem});
            this.Menu2.Name = "Menu1";
            this.Menu2.ShowImageMargin = false;
            this.Menu2.ShowItemToolTips = false;
            this.Menu2.Size = new System.Drawing.Size(110, 48);
            this.Menu2.Opening += new System.ComponentModel.CancelEventHandler(this.Menu2_Opening);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.RemoveToolStripMenuItem_Click);
            // 
            // clearListToolStripMenuItem
            // 
            this.clearListToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.clearListToolStripMenuItem.Name = "clearListToolStripMenuItem";
            this.clearListToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.clearListToolStripMenuItem.Text = "Clear List";
            this.clearListToolStripMenuItem.Click += new System.EventHandler(this.ClearListToolStripMenuItem_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.Lime;
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.ForeColor = System.Drawing.Color.Black;
            this.buttonPlay.Location = new System.Drawing.Point(91, 10);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(119, 50);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.TabStop = false;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
            // 
            // buttonRecord
            // 
            this.buttonRecord.BackColor = System.Drawing.Color.Lime;
            this.buttonRecord.FlatAppearance.BorderSize = 0;
            this.buttonRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecord.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecord.ForeColor = System.Drawing.Color.Black;
            this.buttonRecord.Location = new System.Drawing.Point(10, 10);
            this.buttonRecord.Name = "buttonRecord";
            this.buttonRecord.Size = new System.Drawing.Size(75, 50);
            this.buttonRecord.TabIndex = 0;
            this.buttonRecord.TabStop = false;
            this.buttonRecord.Text = "Record";
            this.buttonRecord.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonRecord.UseVisualStyleBackColor = false;
            this.buttonRecord.Click += new System.EventHandler(this.ButtonRecord_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tabPage3.Controls.Add(this.labelHK);
            this.tabPage3.Controls.Add(this.panelHK);
            this.tabPage3.Controls.Add(this.labelTM);
            this.tabPage3.Controls.Add(this.panelTM);
            this.tabPage3.Controls.Add(this.labelSMC);
            this.tabPage3.Controls.Add(this.panelSMC);
            this.tabPage3.Controls.Add(this.panelTrackBar);
            this.tabPage3.Controls.Add(this.comboBoxColor);
            this.tabPage3.Controls.Add(this.labelFC);
            this.tabPage3.Controls.Add(this.labelCI);
            this.tabPage3.Controls.Add(this.buttonAbout);
            this.tabPage3.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(220, 353);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // labelTM
            // 
            this.labelTM.AutoSize = true;
            this.labelTM.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTM.ForeColor = System.Drawing.Color.Lime;
            this.labelTM.Location = new System.Drawing.Point(41, 199);
            this.labelTM.Name = "labelTM";
            this.labelTM.Size = new System.Drawing.Size(67, 17);
            this.labelTM.TabIndex = 1;
            this.labelTM.Text = "Top Most";
            // 
            // panelTM
            // 
            this.panelTM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTM.Controls.Add(this.checkBoxTM);
            this.panelTM.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTM.Location = new System.Drawing.Point(15, 198);
            this.panelTM.Name = "panelTM";
            this.panelTM.Size = new System.Drawing.Size(20, 20);
            this.panelTM.TabIndex = 2;
            // 
            // checkBoxTM
            // 
            this.checkBoxTM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.checkBoxTM.FlatAppearance.BorderSize = 0;
            this.checkBoxTM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxTM.Location = new System.Drawing.Point(1, 1);
            this.checkBoxTM.Name = "checkBoxTM";
            this.checkBoxTM.Size = new System.Drawing.Size(16, 16);
            this.checkBoxTM.TabIndex = 0;
            this.checkBoxTM.TabStop = false;
            this.checkBoxTM.UseVisualStyleBackColor = false;
            this.checkBoxTM.Click += new System.EventHandler(this.CheckBoxTM_Click);
            // 
            // labelSMC
            // 
            this.labelSMC.AutoSize = true;
            this.labelSMC.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSMC.ForeColor = System.Drawing.Color.Lime;
            this.labelSMC.Location = new System.Drawing.Point(41, 158);
            this.labelSMC.Name = "labelSMC";
            this.labelSMC.Size = new System.Drawing.Size(117, 17);
            this.labelSMC.TabIndex = 0;
            this.labelSMC.Text = "Show Mini Control";
            // 
            // panelSMC
            // 
            this.panelSMC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSMC.Controls.Add(this.checkBoxSMC);
            this.panelSMC.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSMC.Location = new System.Drawing.Point(15, 157);
            this.panelSMC.Name = "panelSMC";
            this.panelSMC.Size = new System.Drawing.Size(20, 20);
            this.panelSMC.TabIndex = 0;
            // 
            // checkBoxSMC
            // 
            this.checkBoxSMC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.checkBoxSMC.FlatAppearance.BorderSize = 0;
            this.checkBoxSMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxSMC.Location = new System.Drawing.Point(1, 1);
            this.checkBoxSMC.Name = "checkBoxSMC";
            this.checkBoxSMC.Size = new System.Drawing.Size(16, 16);
            this.checkBoxSMC.TabIndex = 0;
            this.checkBoxSMC.TabStop = false;
            this.checkBoxSMC.UseVisualStyleBackColor = false;
            this.checkBoxSMC.Click += new System.EventHandler(this.CheckBoxSMC_Click);
            // 
            // panelTrackBar
            // 
            this.panelTrackBar.Controls.Add(this.TrackBarSlider);
            this.panelTrackBar.Controls.Add(this.panelTrackBar2);
            this.panelTrackBar.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTrackBar.Location = new System.Drawing.Point(13, 39);
            this.panelTrackBar.Name = "panelTrackBar";
            this.panelTrackBar.Size = new System.Drawing.Size(160, 20);
            this.panelTrackBar.TabIndex = 0;
            // 
            // TrackBarSlider
            // 
            this.TrackBarSlider.BackColor = System.Drawing.Color.Lime;
            this.TrackBarSlider.FlatAppearance.BorderSize = 0;
            this.TrackBarSlider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TrackBarSlider.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrackBarSlider.ForeColor = System.Drawing.Color.Black;
            this.TrackBarSlider.Location = new System.Drawing.Point(0, 0);
            this.TrackBarSlider.Name = "TrackBarSlider";
            this.TrackBarSlider.Size = new System.Drawing.Size(10, 20);
            this.TrackBarSlider.TabIndex = 0;
            this.TrackBarSlider.TabStop = false;
            this.TrackBarSlider.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.TrackBarSlider.UseVisualStyleBackColor = false;
            this.TrackBarSlider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TrackBarSlider_MouseDown);
            this.TrackBarSlider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TrackBarSlider_MouseMove);
            this.TrackBarSlider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrackBarSlider_MouseUp);
            // 
            // panelTrackBar2
            // 
            this.panelTrackBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelTrackBar2.Location = new System.Drawing.Point(1, 7);
            this.panelTrackBar2.Name = "panelTrackBar2";
            this.panelTrackBar2.Size = new System.Drawing.Size(160, 5);
            this.panelTrackBar2.TabIndex = 0;
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.comboBoxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColor.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxColor.ForeColor = System.Drawing.Color.Lime;
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.ItemHeight = 17;
            this.comboBoxColor.Items.AddRange(new object[] {
            "FrenzyMode 1x",
            "FrenzyMode 2x",
            "FrenzyMode 3x",
            "FrenzyMode 4x"});
            this.comboBoxColor.Location = new System.Drawing.Point(13, 106);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(160, 25);
            this.comboBoxColor.TabIndex = 0;
            this.comboBoxColor.TabStop = false;
            this.comboBoxColor.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // labelFC
            // 
            this.labelFC.AutoSize = true;
            this.labelFC.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFC.ForeColor = System.Drawing.Color.Lime;
            this.labelFC.Location = new System.Drawing.Point(10, 77);
            this.labelFC.Name = "labelFC";
            this.labelFC.Size = new System.Drawing.Size(48, 17);
            this.labelFC.TabIndex = 0;
            this.labelFC.Text = "Color :";
            // 
            // labelCI
            // 
            this.labelCI.AutoSize = true;
            this.labelCI.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCI.ForeColor = System.Drawing.Color.Lime;
            this.labelCI.Location = new System.Drawing.Point(10, 10);
            this.labelCI.Name = "labelCI";
            this.labelCI.Size = new System.Drawing.Size(124, 17);
            this.labelCI.TabIndex = 0;
            this.labelCI.Text = "Click Interval : 200";
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.Color.Lime;
            this.buttonAbout.FlatAppearance.BorderSize = 0;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbout.ForeColor = System.Drawing.Color.Black;
            this.buttonAbout.Location = new System.Drawing.Point(10, 287);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(200, 50);
            this.buttonAbout.TabIndex = 0;
            this.buttonAbout.TabStop = false;
            this.buttonAbout.Text = "About";
            this.buttonAbout.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonAbout.UseVisualStyleBackColor = false;
            this.buttonAbout.Click += new System.EventHandler(this.ButtonAbout_Click);
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Caviar Dreams", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.ForeColor = System.Drawing.Color.Lime;
            this.labelLogo.Location = new System.Drawing.Point(20, 20);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(152, 34);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "GTBit Beta";
            this.labelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseDown);
            this.labelLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseMove);
            this.labelLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseUp);
            // 
            // FrenzyMode
            // 
            this.FrenzyMode.Tick += new System.EventHandler(this.FrenzyMode_Tick);
            // 
            // labelHK
            // 
            this.labelHK.AutoSize = true;
            this.labelHK.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHK.ForeColor = System.Drawing.Color.Lime;
            this.labelHK.Location = new System.Drawing.Point(41, 240);
            this.labelHK.Name = "labelHK";
            this.labelHK.Size = new System.Drawing.Size(56, 17);
            this.labelHK.TabIndex = 3;
            this.labelHK.Text = "Hotkeys";
            // 
            // panelHK
            // 
            this.panelHK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHK.Controls.Add(this.checkBoxHK);
            this.panelHK.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelHK.Location = new System.Drawing.Point(15, 239);
            this.panelHK.Name = "panelHK";
            this.panelHK.Size = new System.Drawing.Size(20, 20);
            this.panelHK.TabIndex = 4;
            // 
            // checkBoxHK
            // 
            this.checkBoxHK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.checkBoxHK.FlatAppearance.BorderSize = 0;
            this.checkBoxHK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxHK.Location = new System.Drawing.Point(1, 1);
            this.checkBoxHK.Name = "checkBoxHK";
            this.checkBoxHK.Size = new System.Drawing.Size(16, 16);
            this.checkBoxHK.TabIndex = 0;
            this.checkBoxHK.TabStop = false;
            this.checkBoxHK.UseVisualStyleBackColor = false;
            this.checkBoxHK.Click += new System.EventHandler(this.checkBoxHK_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(270, 504);
            this.Controls.Add(this.panelForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GTBit Beta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.TabSelector.ResumeLayout(false);
            this.panelTabControl.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelWL.ResumeLayout(false);
            this.panelWLH.ResumeLayout(false);
            this.panelWLH.PerformLayout();
            this.Menu1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panelML.ResumeLayout(false);
            this.panelMLH.ResumeLayout(false);
            this.panelMLH.PerformLayout();
            this.Menu2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panelTM.ResumeLayout(false);
            this.panelSMC.ResumeLayout(false);
            this.panelTrackBar.ResumeLayout(false);
            this.panelHK.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panelTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonLG;
        private System.Windows.Forms.Panel TabSelector;
        private System.Windows.Forms.Panel panelTabSelectorActive;
        private System.Windows.Forms.Button buttonTab1;
        private System.Windows.Forms.Button buttonTab2;
        private System.Windows.Forms.Button buttonTab3;
        private System.Windows.Forms.Panel panelWL;
        private System.Windows.Forms.Label labelWL;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Panel panelWLH;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Panel panelML;
        private System.Windows.Forms.Panel panelMLH;
        private System.Windows.Forms.Label labelMLY;
        private System.Windows.Forms.Label labelMLX;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label labelCI;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label labelFC;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Panel panelTrackBar2;
        private System.Windows.Forms.ContextMenuStrip Menu1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip Menu2;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearListToolStripMenuItem;
        private System.Windows.Forms.Panel panelTrackBar;
        private System.Windows.Forms.Label labelSMC;
        private System.Windows.Forms.Panel panelSMC;
        private System.Windows.Forms.Button TrackBarSlider;
        private System.Windows.Forms.Button checkBoxSMC;
        public System.Windows.Forms.Button buttonPlay;
        public System.Windows.Forms.Button buttonRecord;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Label labelTM;
        private System.Windows.Forms.Panel panelTM;
        private System.Windows.Forms.Button checkBoxTM;
        private System.Windows.Forms.Timer FrenzyMode;
        private System.Windows.Forms.ToolStripMenuItem setAsPrimaryToolStripMenuItem;
        private System.Windows.Forms.Label labelHK;
        private System.Windows.Forms.Panel panelHK;
        private System.Windows.Forms.Button checkBoxHK;
    }
}

