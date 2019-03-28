namespace WindowsFormsApp1
{
    partial class MarkStudentAttendance
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
            this.btnadd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAttendancedate = new System.Windows.Forms.ComboBox();
            this.classAttendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet = new WindowsFormsApp1.ProjectBDataSet();
            this.cmbStdreg = new System.Windows.Forms.ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbAttendanceStatus = new System.Windows.Forms.ComboBox();
            this.lookupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classAttendanceTableAdapter = new WindowsFormsApp1.ProjectBDataSetTableAdapters.ClassAttendanceTableAdapter();
            this.studentTableAdapter = new WindowsFormsApp1.ProjectBDataSetTableAdapters.StudentTableAdapter();
            this.lookupTableAdapter = new WindowsFormsApp1.ProjectBDataSetTableAdapters.LookupTableAdapter();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classAttendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(151, 315);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 31;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // panel1
            // 
            this.panel1.AccessibleDescription = "";
            this.panel1.AccessibleName = "";
            this.panel1.Controls.Add(this.linkLabel3);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 61);
            this.panel1.TabIndex = 30;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(0, 45);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(157, 16);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "back to class attendance";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(270, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mark Attendance";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Attendance Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Student Reg no.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "AttendanceStatus";
            // 
            // cmbAttendancedate
            // 
            this.cmbAttendancedate.DataSource = this.classAttendanceBindingSource;
            this.cmbAttendancedate.DisplayMember = "AttendanceDate";
            this.cmbAttendancedate.FormattingEnabled = true;
            this.cmbAttendancedate.Location = new System.Drawing.Point(262, 116);
            this.cmbAttendancedate.Name = "cmbAttendancedate";
            this.cmbAttendancedate.Size = new System.Drawing.Size(121, 21);
            this.cmbAttendancedate.TabIndex = 34;
            this.cmbAttendancedate.ValueMember = "Id";
            // 
            // classAttendanceBindingSource
            // 
            this.classAttendanceBindingSource.DataMember = "ClassAttendance";
            this.classAttendanceBindingSource.DataSource = this.projectBDataSet;
            // 
            // projectBDataSet
            // 
            this.projectBDataSet.DataSetName = "ProjectBDataSet";
            this.projectBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbStdreg
            // 
            this.cmbStdreg.DataSource = this.studentBindingSource;
            this.cmbStdreg.DisplayMember = "RegistrationNumber";
            this.cmbStdreg.FormattingEnabled = true;
            this.cmbStdreg.Location = new System.Drawing.Point(262, 149);
            this.cmbStdreg.Name = "cmbStdreg";
            this.cmbStdreg.Size = new System.Drawing.Size(121, 21);
            this.cmbStdreg.TabIndex = 35;
            this.cmbStdreg.ValueMember = "Id";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.projectBDataSet;
            // 
            // cmbAttendanceStatus
            // 
            this.cmbAttendanceStatus.DataSource = this.lookupBindingSource;
            this.cmbAttendanceStatus.DisplayMember = "Name";
            this.cmbAttendanceStatus.FormattingEnabled = true;
            this.cmbAttendanceStatus.Location = new System.Drawing.Point(262, 184);
            this.cmbAttendanceStatus.Name = "cmbAttendanceStatus";
            this.cmbAttendanceStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbAttendanceStatus.TabIndex = 36;
            this.cmbAttendanceStatus.ValueMember = "LookupId";
            // 
            // lookupBindingSource
            // 
            this.lookupBindingSource.DataMember = "Lookup";
            this.lookupBindingSource.DataSource = this.projectBDataSet;
            // 
            // classAttendanceTableAdapter
            // 
            this.classAttendanceTableAdapter.ClearBeforeFill = true;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // lookupTableAdapter
            // 
            this.lookupTableAdapter.ClearBeforeFill = true;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.LinkColor = System.Drawing.Color.Black;
            this.linkLabel3.Location = new System.Drawing.Point(0, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(168, 16);
            this.linkLabel3.TabIndex = 38;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "back to student attendance";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // MarkStudentAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbAttendanceStatus);
            this.Controls.Add(this.cmbStdreg);
            this.Controls.Add(this.cmbAttendancedate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "MarkStudentAttendance";
            this.Text = "MarkStudentAttendance";
            this.Load += new System.EventHandler(this.MarkStudentAttendance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classAttendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAttendancedate;
        private System.Windows.Forms.ComboBox cmbStdreg;
        private System.Windows.Forms.ComboBox cmbAttendanceStatus;
        private ProjectBDataSet projectBDataSet;
        private System.Windows.Forms.BindingSource classAttendanceBindingSource;
        private ProjectBDataSetTableAdapters.ClassAttendanceTableAdapter classAttendanceTableAdapter;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private ProjectBDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource lookupBindingSource;
        private ProjectBDataSetTableAdapters.LookupTableAdapter lookupTableAdapter;
        private System.Windows.Forms.LinkLabel linkLabel3;
    }
}