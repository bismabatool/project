namespace WindowsFormsApp1
{
    partial class ManageRubrics
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnaddrubric = new System.Windows.Forms.Button();
            this.projectBDataSet = new WindowsFormsApp1.ProjectBDataSet();
            this.rubricBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rubricTableAdapter = new WindowsFormsApp1.ProjectBDataSetTableAdapters.RubricTableAdapter();
            this.rubricrecord = new System.Windows.Forms.DataGridView();
            this.rubricBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rubricLevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rubricLevelTableAdapter = new WindowsFormsApp1.ProjectBDataSetTableAdapters.RubricLevelTableAdapter();
            this.rubricBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cloIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricrecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricLevelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.btnaddrubric);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 58);
            this.panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(711, 39);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(85, 16);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "BackToMain";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnaddrubric
            // 
            this.btnaddrubric.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddrubric.Location = new System.Drawing.Point(252, 2);
            this.btnaddrubric.Name = "btnaddrubric";
            this.btnaddrubric.Size = new System.Drawing.Size(290, 53);
            this.btnaddrubric.TabIndex = 2;
            this.btnaddrubric.Text = "Add New Rubric";
            this.btnaddrubric.UseVisualStyleBackColor = true;
            this.btnaddrubric.Click += new System.EventHandler(this.btnaddrubric_Click);
            // 
            // projectBDataSet
            // 
            this.projectBDataSet.DataSetName = "ProjectBDataSet";
            this.projectBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rubricBindingSource
            // 
            this.rubricBindingSource.DataMember = "Rubric";
            this.rubricBindingSource.DataSource = this.projectBDataSet;
            // 
            // rubricTableAdapter
            // 
            this.rubricTableAdapter.ClearBeforeFill = true;
            // 
            // rubricrecord
            // 
            this.rubricrecord.AutoGenerateColumns = false;
            this.rubricrecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rubricrecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn,
            this.cloIdDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.rubricrecord.DataSource = this.rubricBindingSource2;
            this.rubricrecord.Location = new System.Drawing.Point(2, 65);
            this.rubricrecord.Name = "rubricrecord";
            this.rubricrecord.Size = new System.Drawing.Size(542, 264);
            this.rubricrecord.TabIndex = 1;
            this.rubricrecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rubricBindingSource1
            // 
            this.rubricBindingSource1.DataMember = "Rubric";
            this.rubricBindingSource1.DataSource = this.projectBDataSet;
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
            // rubricBindingSource2
            // 
            this.rubricBindingSource2.DataMember = "Rubric";
            this.rubricBindingSource2.DataSource = this.projectBDataSet;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "Details";
            this.detailsDataGridViewTextBoxColumn.HeaderText = "Details";
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            // 
            // cloIdDataGridViewTextBoxColumn
            // 
            this.cloIdDataGridViewTextBoxColumn.DataPropertyName = "CloId";
            this.cloIdDataGridViewTextBoxColumn.HeaderText = "CloId";
            this.cloIdDataGridViewTextBoxColumn.Name = "cloIdDataGridViewTextBoxColumn";
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
            // ManageRubrics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rubricrecord);
            this.Controls.Add(this.panel1);
            this.Name = "ManageRubrics";
            this.Text = "ManageRubrics";
            this.Load += new System.EventHandler(this.ManageRubrics_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricrecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricLevelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnaddrubric;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private ProjectBDataSet projectBDataSet;
        private System.Windows.Forms.BindingSource rubricBindingSource;
        private ProjectBDataSetTableAdapters.RubricTableAdapter rubricTableAdapter;
        private System.Windows.Forms.DataGridView rubricrecord;
        private System.Windows.Forms.BindingSource rubricBindingSource1;
        private System.Windows.Forms.BindingSource rubricLevelBindingSource;
        private ProjectBDataSetTableAdapters.RubricLevelTableAdapter rubricLevelTableAdapter;
        private System.Windows.Forms.BindingSource rubricBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cloIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}