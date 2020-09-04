namespace GTBit_Beta
{
    partial class MiniControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiniControl));
            this.MCbuttonRecord = new System.Windows.Forms.Button();
            this.MCbuttonPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MCbuttonRecord
            // 
            this.MCbuttonRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.MCbuttonRecord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.MCbuttonRecord.FlatAppearance.BorderSize = 0;
            this.MCbuttonRecord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.MCbuttonRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.MCbuttonRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MCbuttonRecord.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCbuttonRecord.ForeColor = System.Drawing.Color.Lime;
            this.MCbuttonRecord.Location = new System.Drawing.Point(6, 0);
            this.MCbuttonRecord.Name = "MCbuttonRecord";
            this.MCbuttonRecord.Size = new System.Drawing.Size(100, 35);
            this.MCbuttonRecord.TabIndex = 0;
            this.MCbuttonRecord.Text = "Record";
            this.MCbuttonRecord.UseVisualStyleBackColor = false;
            this.MCbuttonRecord.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MCbuttonPlay
            // 
            this.MCbuttonPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.MCbuttonPlay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.MCbuttonPlay.FlatAppearance.BorderSize = 0;
            this.MCbuttonPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.MCbuttonPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.MCbuttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MCbuttonPlay.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCbuttonPlay.ForeColor = System.Drawing.Color.Lime;
            this.MCbuttonPlay.Location = new System.Drawing.Point(106, 0);
            this.MCbuttonPlay.Name = "MCbuttonPlay";
            this.MCbuttonPlay.Size = new System.Drawing.Size(100, 35);
            this.MCbuttonPlay.TabIndex = 1;
            this.MCbuttonPlay.Text = "Play";
            this.MCbuttonPlay.UseVisualStyleBackColor = false;
            this.MCbuttonPlay.Click += new System.EventHandler(this.Button2_Click);
            // 
            // MiniControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(208, 35);
            this.Controls.Add(this.MCbuttonPlay);
            this.Controls.Add(this.MCbuttonRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MiniControl";
            this.ShowInTaskbar = false;
            this.Text = "GTBit Mini Control";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MiniControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MCbuttonRecord;
        private System.Windows.Forms.Button MCbuttonPlay;
    }
}