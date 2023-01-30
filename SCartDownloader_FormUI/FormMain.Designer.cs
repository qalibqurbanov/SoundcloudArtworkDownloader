
namespace SCartDownloader_FormUI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.txtMusicUrl = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.pbArtwork = new System.Windows.Forms.PictureBox();
            this.btnFind = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbOlculer = new MetroFramework.Controls.MetroComboBox();
            this.lblVersion = new MetroFramework.Controls.MetroLabel();
            this.cbRandomName = new MetroFramework.Controls.MetroCheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbLastFolder = new MetroFramework.Controls.MetroCheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbArtwork)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMusicUrl
            // 
            // 
            // 
            // 
            this.txtMusicUrl.CustomButton.Image = null;
            this.txtMusicUrl.CustomButton.Location = new System.Drawing.Point(555, 1);
            this.txtMusicUrl.CustomButton.Name = "";
            this.txtMusicUrl.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMusicUrl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMusicUrl.CustomButton.TabIndex = 1;
            this.txtMusicUrl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMusicUrl.CustomButton.UseSelectable = true;
            this.txtMusicUrl.CustomButton.Visible = false;
            this.txtMusicUrl.Lines = new string[0];
            this.txtMusicUrl.Location = new System.Drawing.Point(179, 78);
            this.txtMusicUrl.MaxLength = 32767;
            this.txtMusicUrl.Name = "txtMusicUrl";
            this.txtMusicUrl.PasswordChar = '\0';
            this.txtMusicUrl.PromptText = "Please enter music url. Example: https://soundcloud.com/AUTHOR/SONG";
            this.txtMusicUrl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMusicUrl.SelectedText = "";
            this.txtMusicUrl.SelectionLength = 0;
            this.txtMusicUrl.SelectionStart = 0;
            this.txtMusicUrl.ShortcutsEnabled = true;
            this.txtMusicUrl.Size = new System.Drawing.Size(577, 23);
            this.txtMusicUrl.Style = MetroFramework.MetroColorStyle.Magenta;
            this.txtMusicUrl.TabIndex = 0;
            this.txtMusicUrl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtMusicUrl.UseSelectable = true;
            this.txtMusicUrl.WaterMark = "Please enter music url. Example: https://soundcloud.com/AUTHOR/SONG";
            this.txtMusicUrl.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMusicUrl.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(865, 107);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 23);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Magenta;
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pbArtwork
            // 
            this.pbArtwork.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbArtwork.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbArtwork.Location = new System.Drawing.Point(23, 78);
            this.pbArtwork.Name = "pbArtwork";
            this.pbArtwork.Size = new System.Drawing.Size(150, 150);
            this.pbArtwork.TabIndex = 2;
            this.pbArtwork.TabStop = false;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(179, 107);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(91, 23);
            this.btnFind.Style = MetroFramework.MetroColorStyle.Magenta;
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find";
            this.btnFind.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnFind.UseSelectable = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(148)))));
            this.panel1.Location = new System.Drawing.Point(23, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 10);
            this.panel1.TabIndex = 4;
            // 
            // cbOlculer
            // 
            this.cbOlculer.FormattingEnabled = true;
            this.cbOlculer.ItemHeight = 23;
            this.cbOlculer.Location = new System.Drawing.Point(762, 72);
            this.cbOlculer.Name = "cbOlculer";
            this.cbOlculer.Size = new System.Drawing.Size(194, 29);
            this.cbOlculer.Style = MetroFramework.MetroColorStyle.Magenta;
            this.cbOlculer.TabIndex = 5;
            this.cbOlculer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbOlculer.UseSelectable = true;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblVersion.Location = new System.Drawing.Point(360, 18);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(50, 19);
            this.lblVersion.Style = MetroFramework.MetroColorStyle.Magenta;
            this.lblVersion.TabIndex = 6;
            this.lblVersion.Text = "version";
            this.lblVersion.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblVersion.UseCustomBackColor = true;
            this.lblVersion.UseCustomForeColor = true;
            // 
            // cbRandomName
            // 
            this.cbRandomName.AutoSize = true;
            this.cbRandomName.ForeColor = System.Drawing.Color.SpringGreen;
            this.cbRandomName.Location = new System.Drawing.Point(761, 195);
            this.cbRandomName.Name = "cbRandomName";
            this.cbRandomName.Size = new System.Drawing.Size(167, 15);
            this.cbRandomName.Style = MetroFramework.MetroColorStyle.Magenta;
            this.cbRandomName.TabIndex = 7;
            this.cbRandomName.Text = "Generate random file name";
            this.cbRandomName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbRandomName.UseCustomForeColor = true;
            this.cbRandomName.UseSelectable = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(148)))));
            this.panel2.Location = new System.Drawing.Point(761, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 10);
            this.panel2.TabIndex = 5;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.Gold;
            this.metroLabel2.Location = new System.Drawing.Point(899, 173);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Settings:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(148)))));
            this.panel3.Location = new System.Drawing.Point(761, 157);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(192, 10);
            this.panel3.TabIndex = 6;
            // 
            // cbLastFolder
            // 
            this.cbLastFolder.AutoSize = true;
            this.cbLastFolder.ForeColor = System.Drawing.Color.SpringGreen;
            this.cbLastFolder.Location = new System.Drawing.Point(761, 216);
            this.cbLastFolder.Name = "cbLastFolder";
            this.cbLastFolder.Size = new System.Drawing.Size(162, 15);
            this.cbLastFolder.Style = MetroFramework.MetroColorStyle.Magenta;
            this.cbLastFolder.TabIndex = 8;
            this.cbLastFolder.Text = "Save to last selected folder";
            this.cbLastFolder.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbLastFolder.UseCustomForeColor = true;
            this.cbLastFolder.UseSelectable = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(148)))));
            this.panel4.Location = new System.Drawing.Point(943, 221);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 10);
            this.panel4.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(148)))));
            this.panel5.Location = new System.Drawing.Point(943, 212);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 10);
            this.panel5.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(148)))));
            this.panel6.Location = new System.Drawing.Point(934, 221);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 10);
            this.panel6.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(148)))));
            this.panel7.Location = new System.Drawing.Point(943, 202);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 10);
            this.panel7.TabIndex = 8;
            // 
            // FormMain
            // 
            this.AcceptButton = this.btnFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 250);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.cbLastFolder);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbRandomName);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.cbOlculer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.pbArtwork);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMusicUrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "SoundCloud Artwork Downloader";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbArtwork)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtMusicUrl;
        private MetroFramework.Controls.MetroButton btnSave;
        private System.Windows.Forms.PictureBox pbArtwork;
        private MetroFramework.Controls.MetroButton btnFind;
        private System.Windows.Forms.Panel panel1;
        public MetroFramework.Controls.MetroComboBox cbOlculer;
        private MetroFramework.Controls.MetroLabel lblVersion;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        public MetroFramework.Controls.MetroCheckBox cbRandomName;
        public MetroFramework.Controls.MetroCheckBox cbLastFolder;
    }
}