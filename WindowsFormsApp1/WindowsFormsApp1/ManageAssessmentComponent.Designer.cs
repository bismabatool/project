namespace WindowsFormsApp1
{
    partial class ManageAssessmentComponent
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
            this.AssessmentComponentrecord = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnaddstudent = new System.Windows.Forms.Button();
            this.projectBDataSet = new WindowsFormsApp1.ProjectBDataSet();
            this.assessmentComponentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assessmentComponentTableAdapter = new WindowsFormsApp1.ProjectBDataSetTableAdapters.AssessmentComponentTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubricIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateUpdatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assessmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AssessmentComponentrecord)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentComponentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AssessmentComponentrecord
            // 
            this.AssessmentComponentrecord.AutoGenerateColumns = false;
            this.AssessmentComponentrecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssessmentComponentrecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.rubricIdDataGridViewTextBoxColumn,
            this.totalMarksDataGridViewTextBoxColumn,
            this.dateCreatedDataGridViewTextBoxColumn,
            this.dateUpdatedDataGridViewTextBoxColumn,
            this.assessmentIdDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.AssessmentComponentrecord.DataSource = this.assessmentComponentBindingSource;
            this.AssessmentComponentrecord.Dock = System.Windows.Forms.DockStyle.Left;
            this.AssessmentComponentrecord.Location = new System.Drawing.Point(0, 53);
            this.AssessmentComponentrecord.Name = "AssessmentComponentrecord";
            this.AssessmentComponentrecord.Size = new System.Drawing.Size(1122, 397);
            this.AssessmentComponentrecord.TabIndex = 3;
            this.AssessmentComponentrecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentrecord_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.btnaddstudent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 53);
            this.panel1.TabIndex = 2;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(0, 37);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(85, 16);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "BackToMain";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnaddstudent
            // 
            this.btnaddstudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddstudent.Location = new System.Drawing.Point(187, 6);
            this.btnaddstudent.Name = "btnaddstudent";
            this.btnaddstudent.Size = new System.Drawing.Size(363, 47);
            this.btnaddstudent.TabIndex = 0;
            this.btnaddstudent.Text = "Add New Assessment Component";
            this.btnaddstudent.UseVisualStyleBackColor = true;
            this.btnaddstudent.Click += new System.EventHandler(this.btnaddstudent_Click);
            // 
            // projectBDataSet
            // 
            this.projectBDataSet.DataSetName = "ProjectBDataSet";
            this.projectBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assessmentComponentBindingSource
            // 
            this.assessmentComponentBindingSource.DataMember = "AssessmentComponent";
            this.assessmentComponentBindingSource.DataSource = this.projectBDataSet;
            // 
            // assessmentComponentTableAdapter
            // 
            this.assessmentComponentTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // rubricIdDataGridViewTextBoxColumn
            // 
            this.rubricIdDataGridViewTextBoxColumn.DataPropertyName = "RubricId";
            this.rubricIdDataGridViewTextBoxColumn.HeaderText = "RubricId";
            this.rubricIdDataGridViewTextBoxColumn.Name = "rubricIdDataGridViewTextBoxColumn";
            // 
            // totalMarksDataGridViewTextBoxColumn
            // 
            this.totalMarksDataGridViewTextBoxColumn.DataPropertyName = "TotalMarks";
            this.totalMarksDataGridViewTextBoxColumn.HeaderText = "TotalMarks";
            this.totalMarksDataGridViewTextBoxColumn.Name = "totalMarksDataGridViewTextBoxColumn";
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            // 
            // dateUpdatedDataGridViewTextBoxColumn
            // 
            this.dateUpdatedDataGridViewTextBoxColumn.DataPropertyName = "DateUpdated";
            this.dateUpdatedDataGridViewTextBoxColumn.HeaderText = "DateUpdated";
            this.dateUpdatedDataGridViewTextBoxColumn.Name = "dateUpdatedDataGridViewTextBoxColumn";
            // 
            // assessmentIdDataGridViewTextBoxColumn
            // 
            this.assessmentIdDataGridViewTextBoxColumn.DataPropertyName = "AssessmentId";
            this.assessmentIdDataGridViewTextBoxColumn.HeaderText = "AssessmentId";
            this.assessmentIdDataGridViewTextBoxColumn.Name = "assessmentIdDataGridViewTextBoxColumn";
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "Id";
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Id";
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // ManageAssessmentComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 450);
            this.Controls.Add(this.AssessmentComponentrecord);
            this.Controls.Add(this.panel1);
            this.Name = "ManageAssessmentComponent";
            this.Text = "ManageAssessmentComponent";
            this.Load += new System.EventHandler(this.ManageAssessmentComponent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AssessmentComponentrecord)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentComponentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AssessmentComponentrecord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnaddstudent;
        private ProjectBDataSet projectBDataSet;
        private System.Windows.Forms.BindingSource assessmentComponentBindingSource;
        private ProjectBDataSetTableAdapters.AssessmentComponentTableAdapter assessmentComponentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubricIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateUpdatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assessmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}