namespace WindowsFormsApp1
{
    partial class ManageRubricLevel
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
            this.RubricLevelRecord = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnaddclo = new System.Windows.Forms.Button();
            this.projectBDataSet = new WindowsFormsApp1.ProjectBDataSet();
            this.rubricLevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rubricLevelTableAdapter = new WindowsFormsApp1.ProjectBDataSetTableAdapters.RubricLevelTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubricIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measurementLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RubricLevelRecord)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricLevelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RubricLevelRecord
            // 
            this.RubricLevelRecord.AutoGenerateColumns = false;
            this.RubricLevelRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RubricLevelRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.rubricIdDataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn,
            this.measurementLevelDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.RubricLevelRecord.DataSource = this.rubricLevelBindingSource;
            this.RubricLevelRecord.Dock = System.Windows.Forms.DockStyle.Left;
            this.RubricLevelRecord.Location = new System.Drawing.Point(0, 55);
            this.RubricLevelRecord.Name = "RubricLevelRecord";
            this.RubricLevelRecord.Size = new System.Drawing.Size(788, 395);
            this.RubricLevelRecord.TabIndex = 3;
            this.RubricLevelRecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clorecord_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.btnaddclo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 55);
            this.panel1.TabIndex = 2;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(712, 36);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(85, 16);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "BackToMain";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnaddclo
            // 
            this.btnaddclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddclo.Location = new System.Drawing.Point(219, 3);
            this.btnaddclo.Name = "btnaddclo";
            this.btnaddclo.Size = new System.Drawing.Size(273, 49);
            this.btnaddclo.TabIndex = 1;
            this.btnaddclo.Text = "Add New Rubric Level";
            this.btnaddclo.UseVisualStyleBackColor = true;
            this.btnaddclo.Click += new System.EventHandler(this.btnaddclo_Click);
            // 
            // projectBDataSet
            // 
            this.projectBDataSet.DataSetName = "ProjectBDataSet";
            this.projectBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rubricLevelBindingSource
            // 
            this.rubricLevelBindingSource.DataMember = "RubricLevel";
            this.rubricLevelBindingSource.DataSource = this.projectBDataSet;
            // 
            // rubricLevelTableAdapter
            // 
            this.rubricLevelTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rubricIdDataGridViewTextBoxColumn
            // 
            this.rubricIdDataGridViewTextBoxColumn.DataPropertyName = "RubricId";
            this.rubricIdDataGridViewTextBoxColumn.HeaderText = "RubricId";
            this.rubricIdDataGridViewTextBoxColumn.Name = "rubricIdDataGridViewTextBoxColumn";
            // 
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "Details";
            this.detailsDataGridViewTextBoxColumn.HeaderText = "Details";
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            // 
            // measurementLevelDataGridViewTextBoxColumn
            // 
            this.measurementLevelDataGridViewTextBoxColumn.DataPropertyName = "MeasurementLevel";
            this.measurementLevelDataGridViewTextBoxColumn.HeaderText = "MeasurementLevel";
            this.measurementLevelDataGridViewTextBoxColumn.Name = "measurementLevelDataGridViewTextBoxColumn";
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
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // ManageRubricLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RubricLevelRecord);
            this.Controls.Add(this.panel1);
            this.Name = "ManageRubricLevel";
            this.Text = "ManageRubricLevel";
            this.Load += new System.EventHandler(this.ManageRubricLevel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RubricLevelRecord)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricLevelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RubricLevelRecord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnaddclo;
        private ProjectBDataSet projectBDataSet;
        private System.Windows.Forms.BindingSource rubricLevelBindingSource;
        private ProjectBDataSetTableAdapters.RubricLevelTableAdapter rubricLevelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubricIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measurementLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}