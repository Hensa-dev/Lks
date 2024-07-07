namespace Bromo
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Board = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDash = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.USP = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MB = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.MKP = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.MK = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.MJD = new System.Windows.Forms.Button();
            this.Dashboard = new System.Windows.Forms.Timer(this.components);
            this.MasterMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.Exit = new System.Windows.Forms.Button();
            this.Board.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDash)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.MasterMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Board
            // 
            this.Board.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Board.Controls.Add(this.label1);
            this.Board.Controls.Add(this.BtnDash);
            this.Board.Dock = System.Windows.Forms.DockStyle.Top;
            this.Board.Location = new System.Drawing.Point(0, 0);
            this.Board.Margin = new System.Windows.Forms.Padding(2);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(902, 44);
            this.Board.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(56, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dashboard";
            // 
            // BtnDash
            // 
            this.BtnDash.Image = ((System.Drawing.Image)(resources.GetObject("BtnDash.Image")));
            this.BtnDash.Location = new System.Drawing.Point(8, 2);
            this.BtnDash.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDash.Name = "BtnDash";
            this.BtnDash.Size = new System.Drawing.Size(38, 40);
            this.BtnDash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnDash.TabIndex = 3;
            this.BtnDash.TabStop = false;
            this.BtnDash.Click += new System.EventHandler(this.BtnDash_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox6);
            this.panel6.Controls.Add(this.USP);
            this.panel6.Location = new System.Drawing.Point(-208, 250);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(207, 58);
            this.panel6.TabIndex = 11;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(2, 2);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // USP
            // 
            this.USP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.USP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.USP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.USP.Location = new System.Drawing.Point(-11, -34);
            this.USP.Margin = new System.Windows.Forms.Padding(2);
            this.USP.Name = "USP";
            this.USP.Size = new System.Drawing.Size(275, 100);
            this.USP.TabIndex = 9;
            this.USP.Text = "Ubah Status Penerbangan";
            this.USP.UseVisualStyleBackColor = false;
            this.USP.Click += new System.EventHandler(this.USP_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pictureBox2);
            this.panel7.Controls.Add(this.MB);
            this.panel7.Location = new System.Drawing.Point(-208, 2);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(207, 58);
            this.panel7.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // MB
            // 
            this.MB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MB.Location = new System.Drawing.Point(-28, -20);
            this.MB.Margin = new System.Windows.Forms.Padding(2);
            this.MB.Name = "MB";
            this.MB.Size = new System.Drawing.Size(254, 72);
            this.MB.TabIndex = 5;
            this.MB.Text = "Master Bandara";
            this.MB.UseVisualStyleBackColor = false;
            this.MB.Click += new System.EventHandler(this.Master_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.MKP);
            this.panel3.Location = new System.Drawing.Point(-208, 64);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(207, 58);
            this.panel3.TabIndex = 11;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(2, 3);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 27);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // MKP
            // 
            this.MKP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MKP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MKP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MKP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MKP.Location = new System.Drawing.Point(-22, -17);
            this.MKP.Margin = new System.Windows.Forms.Padding(2);
            this.MKP.Name = "MKP";
            this.MKP.Size = new System.Drawing.Size(262, 66);
            this.MKP.TabIndex = 8;
            this.MKP.Text = "Master Kode Promo";
            this.MKP.UseVisualStyleBackColor = false;
            this.MKP.Click += new System.EventHandler(this.MKP_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.MK);
            this.panel5.Location = new System.Drawing.Point(-208, 126);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(207, 58);
            this.panel5.TabIndex = 11;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(2, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // MK
            // 
            this.MK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MK.Location = new System.Drawing.Point(-22, -16);
            this.MK.Margin = new System.Windows.Forms.Padding(2);
            this.MK.Name = "MK";
            this.MK.Size = new System.Drawing.Size(248, 72);
            this.MK.TabIndex = 6;
            this.MK.Text = "Master Maskapai";
            this.MK.UseVisualStyleBackColor = false;
            this.MK.Click += new System.EventHandler(this.MK_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.MJD);
            this.panel4.Location = new System.Drawing.Point(-208, 188);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(207, 58);
            this.panel4.TabIndex = 10;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(2, 2);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // MJD
            // 
            this.MJD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MJD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MJD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MJD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MJD.Location = new System.Drawing.Point(-11, -19);
            this.MJD.Margin = new System.Windows.Forms.Padding(2);
            this.MJD.Name = "MJD";
            this.MJD.Size = new System.Drawing.Size(285, 69);
            this.MJD.TabIndex = 7;
            this.MJD.Text = "Master Jadwal Penerbangan";
            this.MJD.UseVisualStyleBackColor = false;
            this.MJD.Click += new System.EventHandler(this.MJD_Click);
            // 
            // Dashboard
            // 
            this.Dashboard.Interval = 20;
            this.Dashboard.Tick += new System.EventHandler(this.Dashboard_Tick);
            // 
            // MasterMenu
            // 
            this.MasterMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MasterMenu.Controls.Add(this.panel7);
            this.MasterMenu.Controls.Add(this.panel3);
            this.MasterMenu.Controls.Add(this.panel5);
            this.MasterMenu.Controls.Add(this.panel4);
            this.MasterMenu.Controls.Add(this.panel6);
            this.MasterMenu.Controls.Add(this.Exit);
            this.MasterMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.MasterMenu.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.MasterMenu.Location = new System.Drawing.Point(0, 44);
            this.MasterMenu.Name = "MasterMenu";
            this.MasterMenu.Size = new System.Drawing.Size(1, 466);
            this.MasterMenu.TabIndex = 10;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.DarkRed;
            this.Exit.Location = new System.Drawing.Point(-77, 313);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 35);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "Keluar";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 510);
            this.Controls.Add(this.MasterMenu);
            this.Controls.Add(this.Board);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.IsMdiContainer = true;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Board.ResumeLayout(false);
            this.Board.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDash)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.MasterMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Board;
        private System.Windows.Forms.PictureBox BtnDash;
        private System.Windows.Forms.Button MB;
        private System.Windows.Forms.Button MK;
        private System.Windows.Forms.Button MJD;
        private System.Windows.Forms.Button MKP;
        private System.Windows.Forms.Button USP;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Dashboard;
        private System.Windows.Forms.FlowLayoutPanel MasterMenu;
        private System.Windows.Forms.Button Exit;
    }
}