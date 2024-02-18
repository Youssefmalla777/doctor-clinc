namespace doctor_clinc
{
    partial class data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(data));
            this.label1 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtreview = new System.Windows.Forms.TextBox();
            this.txtpatient = new System.Windows.Forms.TextBox();
            this.combogender = new System.Windows.Forms.ComboBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtdisease = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtnotes = new System.Windows.Forms.TextBox();
            this.txtdoctor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnreview = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picdoctor = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picdoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoEllipsis = true;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtdate
            // 
            this.txtdate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtdate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtdate.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.txtdate, "txtdate");
            this.txtdate.Name = "txtdate";
            this.toolTip1.SetToolTip(this.txtdate, resources.GetString("txtdate.ToolTip"));
            this.txtdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdate_KeyDown_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Name = "dateTimePicker1";
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.OwnerDraw = true;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.StripAmpersands = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "info";
            // 
            // txtreview
            // 
            this.txtreview.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtreview.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtreview.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.txtreview, "txtreview");
            this.txtreview.Name = "txtreview";
            this.toolTip1.SetToolTip(this.txtreview, resources.GetString("txtreview.ToolTip"));
            this.txtreview.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtreview_KeyDown);
            this.txtreview.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtreview_KeyUp);
            // 
            // txtpatient
            // 
            this.txtpatient.AllowDrop = true;
            this.txtpatient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtpatient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtpatient.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.txtpatient, "txtpatient");
            this.txtpatient.Name = "txtpatient";
            this.toolTip1.SetToolTip(this.txtpatient, resources.GetString("txtpatient.ToolTip"));
            this.txtpatient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpatient_KeyDown);
            this.txtpatient.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtpatient_KeyUp);
            // 
            // combogender
            // 
            this.combogender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combogender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.combogender.BackColor = System.Drawing.SystemColors.Info;
            this.combogender.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.combogender, "combogender");
            this.combogender.FormattingEnabled = true;
            this.combogender.Items.AddRange(new object[] {
            resources.GetString("combogender.Items"),
            resources.GetString("combogender.Items1")});
            this.combogender.Name = "combogender";
            this.toolTip1.SetToolTip(this.combogender, resources.GetString("combogender.ToolTip"));
            // 
            // txtage
            // 
            this.txtage.AllowDrop = true;
            this.txtage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtage.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.txtage, "txtage");
            this.txtage.Name = "txtage";
            this.toolTip1.SetToolTip(this.txtage, resources.GetString("txtage.ToolTip"));
            this.txtage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtage_KeyDown);
            this.txtage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtage_KeyUp);
            // 
            // txtdisease
            // 
            this.txtdisease.AllowDrop = true;
            this.txtdisease.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtdisease.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtdisease.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.txtdisease, "txtdisease");
            this.txtdisease.Name = "txtdisease";
            this.toolTip1.SetToolTip(this.txtdisease, resources.GetString("txtdisease.ToolTip"));
            this.txtdisease.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdisease_KeyDown);
            this.txtdisease.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtdisease_KeyUp);
            // 
            // txtaddress
            // 
            this.txtaddress.AllowDrop = true;
            this.txtaddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtaddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtaddress.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.txtaddress, "txtaddress");
            this.txtaddress.Name = "txtaddress";
            this.toolTip1.SetToolTip(this.txtaddress, resources.GetString("txtaddress.ToolTip"));
            this.txtaddress.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtaddress_KeyUp);
            // 
            // txtnotes
            // 
            resources.ApplyResources(this.txtnotes, "txtnotes");
            this.txtnotes.Name = "txtnotes";
            this.toolTip1.SetToolTip(this.txtnotes, resources.GetString("txtnotes.ToolTip"));
            // 
            // txtdoctor
            // 
            this.txtdoctor.AllowDrop = true;
            this.txtdoctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtdoctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtdoctor.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.txtdoctor, "txtdoctor");
            this.txtdoctor.Name = "txtdoctor";
            this.toolTip1.SetToolTip(this.txtdoctor, resources.GetString("txtdoctor.ToolTip"));
            this.txtdoctor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdoctor_KeyDown);
            this.txtdoctor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtdoctor_KeyUp);
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoEllipsis = true;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dateTimePicker2.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dateTimePicker2.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.dateTimePicker2, "dateTimePicker2");
            this.dateTimePicker2.Name = "dateTimePicker2";
            // 
            // btnreview
            // 
            this.btnreview.AutoEllipsis = true;
            this.btnreview.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnreview.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnreview, "btnreview");
            this.btnreview.Name = "btnreview";
            this.btnreview.UseCompatibleTextRendering = true;
            this.btnreview.UseVisualStyleBackColor = true;
            this.btnreview.Click += new System.EventHandler(this.btnreview_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoEllipsis = true;
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.AutoEllipsis = true;
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.AutoEllipsis = true;
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // picdoctor
            // 
            this.picdoctor.BackColor = System.Drawing.Color.SeaShell;
            resources.ApplyResources(this.picdoctor, "picdoctor");
            this.picdoctor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picdoctor.Name = "picdoctor";
            this.picdoctor.TabStop = false;
            // 
            // label7
            // 
            this.label7.AllowDrop = true;
            this.label7.AutoEllipsis = true;
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // checkBox1
            // 
            this.checkBox1.AllowDrop = true;
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.ThreeState = true;
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AllowDrop = true;
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.ThreeState = true;
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AllowDrop = true;
            resources.ApplyResources(this.checkBox3, "checkBox3");
            this.checkBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.ThreeState = true;
            this.checkBox3.UseVisualStyleBackColor = false;
            // 
            // checkBox4
            // 
            this.checkBox4.AllowDrop = true;
            resources.ApplyResources(this.checkBox4, "checkBox4");
            this.checkBox4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.ThreeState = true;
            this.checkBox4.UseVisualStyleBackColor = false;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.PowderBlue;
            resources.ApplyResources(this.btnadd, "btnadd");
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Name = "btnadd";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnfind
            // 
            this.btnfind.BackColor = System.Drawing.Color.PowderBlue;
            resources.ApplyResources(this.btnfind, "btnfind");
            this.btnfind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfind.Name = "btnfind";
            this.btnfind.UseVisualStyleBackColor = false;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.Color.PowderBlue;
            resources.ApplyResources(this.btnshow, "btnshow");
            this.btnshow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnshow.Name = "btnshow";
            this.btnshow.UseVisualStyleBackColor = false;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.PowderBlue;
            resources.ApplyResources(this.delete, "delete");
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.Name = "delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label8
            // 
            this.label8.AllowDrop = true;
            this.label8.AutoEllipsis = true;
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // data
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.txtdoctor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.txtnotes);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.picdoctor);
            this.Controls.Add(this.txtdisease);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combogender);
            this.Controls.Add(this.txtpatient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnreview);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.txtreview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Name = "data";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picdoctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtreview;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnreview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpatient;
        private System.Windows.Forms.ComboBox combogender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdisease;
        private System.Windows.Forms.PictureBox picdoctor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtnotes;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdoctor;
    }
}