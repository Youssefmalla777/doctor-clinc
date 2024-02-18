namespace doctor_clinc
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtpatient = new System.Windows.Forms.TextBox();
            this.txtdesies = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnpick = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thePateintsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theApoitmientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theAgeAndTheGenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(821, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "enter the image");
            this.pictureBox1.WaitOnLoad = true;
            // 
            // txtpatient
            // 
            this.txtpatient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtpatient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtpatient.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtpatient.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpatient.Location = new System.Drawing.Point(318, 101);
            this.txtpatient.Name = "txtpatient";
            this.txtpatient.Size = new System.Drawing.Size(465, 35);
            this.txtpatient.TabIndex = 1;
            this.txtpatient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtpatient, "enter the name");
            this.txtpatient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpatient_KeyDown_1);
            // 
            // txtdesies
            // 
            this.txtdesies.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtdesies.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtdesies.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtdesies.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesies.Location = new System.Drawing.Point(319, 167);
            this.txtdesies.Name = "txtdesies";
            this.txtdesies.Size = new System.Drawing.Size(465, 35);
            this.txtdesies.TabIndex = 2;
            this.txtdesies.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtdesies, "enter the disease");
            this.txtdesies.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtdesies_KeyUp);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.OwnerDraw = true;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.StripAmpersands = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "info";
            // 
            // btnpick
            // 
            this.btnpick.AllowDrop = true;
            this.btnpick.AutoSize = true;
            this.btnpick.BackColor = System.Drawing.Color.Cyan;
            this.btnpick.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnpick.BackgroundImage")));
            this.btnpick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnpick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpick.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpick.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnpick.Location = new System.Drawing.Point(563, 230);
            this.btnpick.Name = "btnpick";
            this.btnpick.Size = new System.Drawing.Size(221, 45);
            this.btnpick.TabIndex = 3;
            this.btnpick.Text = "pick a photo";
            this.btnpick.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnpick.UseVisualStyleBackColor = true;
            this.btnpick.Click += new System.EventHandler(this.btnpick_Click);
            // 
            // btnadd
            // 
            this.btnadd.AllowDrop = true;
            this.btnadd.AutoSize = true;
            this.btnadd.BackColor = System.Drawing.Color.Cyan;
            this.btnadd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnadd.BackgroundImage")));
            this.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(318, 230);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(209, 45);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnedit
            // 
            this.btnedit.AllowDrop = true;
            this.btnedit.AutoSize = true;
            this.btnedit.BackColor = System.Drawing.Color.Cyan;
            this.btnedit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnedit.BackgroundImage")));
            this.btnedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnedit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnedit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(60, 230);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(198, 45);
            this.btnedit.TabIndex = 5;
            this.btnedit.Text = "edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.AllowDrop = true;
            this.btndelete.AutoSize = true;
            this.btndelete.BackColor = System.Drawing.Color.Cyan;
            this.btndelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndelete.BackgroundImage")));
            this.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(319, 281);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(208, 40);
            this.btndelete.TabIndex = 6;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnexit
            // 
            this.btnexit.AllowDrop = true;
            this.btnexit.AutoSize = true;
            this.btnexit.BackColor = System.Drawing.Color.Cyan;
            this.btnexit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexit.BackgroundImage")));
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(60, 281);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(198, 40);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "the Patient name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "the disease:";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 346);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1065, 407);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "                                 the Patient full name";
            this.columnHeader1.Width = 526;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "                                    the disease name";
            this.columnHeader2.Width = 583;
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(561, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "edit the photo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Aqua;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thePateintsToolStripMenuItem,
            this.theApoitmientsToolStripMenuItem,
            this.theSalesToolStripMenuItem,
            this.theAgeAndTheGenderToolStripMenuItem,
            this.aboutTheDoctorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(1065, 46);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thePateintsToolStripMenuItem
            // 
            this.thePateintsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thePateintsToolStripMenuItem.Image")));
            this.thePateintsToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.thePateintsToolStripMenuItem.Name = "thePateintsToolStripMenuItem";
            this.thePateintsToolStripMenuItem.Size = new System.Drawing.Size(244, 42);
            this.thePateintsToolStripMenuItem.Text = "the patient data";
            this.thePateintsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.thePateintsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.thePateintsToolStripMenuItem.Click += new System.EventHandler(this.thePateintsToolStripMenuItem_Click);
            // 
            // theApoitmientsToolStripMenuItem
            // 
            this.theApoitmientsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("theApoitmientsToolStripMenuItem.Image")));
            this.theApoitmientsToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.theApoitmientsToolStripMenuItem.Name = "theApoitmientsToolStripMenuItem";
            this.theApoitmientsToolStripMenuItem.Size = new System.Drawing.Size(246, 42);
            this.theApoitmientsToolStripMenuItem.Text = "the reservations";
            this.theApoitmientsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.theApoitmientsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.theApoitmientsToolStripMenuItem.Click += new System.EventHandler(this.theApoitmientsToolStripMenuItem_Click);
            // 
            // theSalesToolStripMenuItem
            // 
            this.theSalesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("theSalesToolStripMenuItem.Image")));
            this.theSalesToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.theSalesToolStripMenuItem.Name = "theSalesToolStripMenuItem";
            this.theSalesToolStripMenuItem.Size = new System.Drawing.Size(157, 42);
            this.theSalesToolStripMenuItem.Text = "the sales";
            this.theSalesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.theSalesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.theSalesToolStripMenuItem.Click += new System.EventHandler(this.theSalesToolStripMenuItem_Click);
            // 
            // theAgeAndTheGenderToolStripMenuItem
            // 
            this.theAgeAndTheGenderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("theAgeAndTheGenderToolStripMenuItem.Image")));
            this.theAgeAndTheGenderToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.theAgeAndTheGenderToolStripMenuItem.Name = "theAgeAndTheGenderToolStripMenuItem";
            this.theAgeAndTheGenderToolStripMenuItem.Size = new System.Drawing.Size(193, 42);
            this.theAgeAndTheGenderToolStripMenuItem.Text = "the medical";
            this.theAgeAndTheGenderToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.theAgeAndTheGenderToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.theAgeAndTheGenderToolStripMenuItem.Click += new System.EventHandler(this.theAgeAndTheGenderToolStripMenuItem_Click);
            // 
            // aboutTheDoctorToolStripMenuItem
            // 
            this.aboutTheDoctorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutTheDoctorToolStripMenuItem.Image")));
            this.aboutTheDoctorToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.aboutTheDoctorToolStripMenuItem.Name = "aboutTheDoctorToolStripMenuItem";
            this.aboutTheDoctorToolStripMenuItem.Size = new System.Drawing.Size(256, 42);
            this.aboutTheDoctorToolStripMenuItem.Text = "about the doctor";
            this.aboutTheDoctorToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutTheDoctorToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.aboutTheDoctorToolStripMenuItem.Click += new System.EventHandler(this.aboutTheDoctorToolStripMenuItem_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1065, 753);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnpick);
            this.Controls.Add(this.txtdesies);
            this.Controls.Add(this.txtpatient);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "the main";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtpatient;
        private System.Windows.Forms.TextBox txtdesies;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnpick;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem thePateintsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theApoitmientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theSalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theAgeAndTheGenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTheDoctorToolStripMenuItem;
        protected internal System.Windows.Forms.MenuStrip menuStrip1;
    }
}