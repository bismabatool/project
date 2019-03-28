namespace WindowsFormsApp1
{
    partial class ClassAttendance
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnaddAttendance = new System.Windows.Forms.Button();
            this.ClassAttendanceRecord = new System.Windows.Forms.DataGridView();
            this.projectBDataSet = new WindowsFormsApp1.ProjectBDataSet();
            this.classAttendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classAttendanceTableAdapter = new WindowsFormsApp1.ProjectBDataSetTableAdapters.ClassAttendanceTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnmarkAttendance = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassAttendanceRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classAttendanceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnmarkAttendance);
            this.panel1.Controls.Add(this.btnaddAttendance);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 79);
            this.panel1.TabIndex = 0;
            // 
            // btnaddAttendance
            // 
            this.btnaddAttendance.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnaddAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddAttendance.Location = new System.Drawing.Point(0, 0);
            this.btnaddAttendance.Name = "btnaddAttendance";
            this.btnaddAttendance.Size = new System.Drawing.Size(273, 79);
            this.btnaddAttendance.TabIndex = 2;
            this.btnaddAttendance.Text = "Add New Attendace Instance";
            this.btnaddAttendance.UseVisualStyleBackColor = true;
            this.btnaddAttendance.Click += new System.EventHandler(this.btnaddAttendance_Click);
            // 
            // ClassAttendanceRecord
            // 
            this.ClassAttendanceRecord.AutoGenerateColumns = false;
            this.ClassAttendanceRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassAttendanceRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.attendanceDateDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.ClassAttendanceRecord.DataSource = this.classAttendanceBindingSource;
            this.ClassAttendanceRecord.Location = new System.Drawing.Point(1, 83);
            this.ClassAttendanceRecord.Name = "ClassAttendanceRecord";
            this.ClassAttendanceRecord.Size = new System.Drawing.Size(734, 314);
            this.ClassAttendanceRecord.TabIndex = 1;
            this.ClassAttendanceRecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // projectBDataSet
            // 
            this.projectBDataSet.DataSetName = "ProjectBDataSet";
            this.projectBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classAttendanceBindingSource
            // 
            this.classAttendanceBindingSource.DataMember = "ClassAttendance";
            this.classAttendanceBindingSource.DataSource = this.projectBDataSet;
            // 
            // classAttendanceTableAdapter
            // 
            this.classAttendanceTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attendanceDateDataGridViewTextBoxColumn
            // 
            this.attendanceDateDataGridViewTextBoxColumn.DataPropertyName = "AttendanceDate";
            this.attendanceDateDataGridViewTextBoxColumn.HeaderText = "AttendanceDate";
            this.attendanceDateDataGridViewTextBoxColumn.Name = "attendanceDateDataGridViewTextBoxColumn";
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "Id";
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Id";
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // btnmarkAttendance
            // 
            this.btnmarkAttendance.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnmarkAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmarkAttendance.Location = new System.Drawing.Point(526, 0);
            this.btnmarkAttendance.Name = "btnmarkAttendance";
            this.btnmarkAttendance.Size = new System.Drawing.Size(273, 79);
            this.btnmarkAttendance.TabIndex = 3;
            this.btnmarkAttendance.Text = "Mark Student Attendance";
            this.btnmarkAttendance.UseVisualStyleBackColor = true;
            this.btnmarkAttendance.Click += new System.EventHandler(this.btnmarkAttendance_Click);
            // 
            // ClassAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClassAttendanceRecord);
            this.Controls.Add(this.panel1);
            this.Name = "ClassAttendance";
            this.Text = "ClassAttendance";
            this.Load += new System.EventHandler(this.ClassAttendance_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClassAttendanceRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classAttendanceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnaddAttendance;
        private System.Windows.Forms.DataGridView ClassAttendanceRecord;
        private ProjectBDataSet projectBDataSet;
        private System.Windows.Forms.BindingSource classAttendanceBindingSource;
        private ProjectBDataSetTableAdapters.ClassAttendanceTableAdapter classAttendanceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button btnmarkAttendance;
    }
}