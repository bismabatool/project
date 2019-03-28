namespace WindowsFormsApp1
{
    partial class ManageCLOs
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
            this.btnaddclo = new System.Windows.Forms.Button();
            this.clorecord = new System.Windows.Forms.DataGridView();
            this.cloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet = new WindowsFormsApp1.ProjectBDataSet();
            this.cloTableAdapter = new WindowsFormsApp1.ProjectBDataSetTableAdapters.CloTableAdapter();
            this.fKRubricCloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rubricTableAdapter = new WindowsFormsApp1.ProjectBDataSetTableAdapters.RubricTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateUpdatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clorecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRubricCloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.btnaddclo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 55);
            this.panel1.TabIndex = 0;
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
            this.btnaddclo.Text = "Add New CLO";
            this.btnaddclo.UseVisualStyleBackColor = true;
            this.btnaddclo.Click += new System.EventHandler(this.btnaddclo_Click);
            // 
            // clorecord
            // 
            this.clorecord.AutoGenerateColumns = false;
            this.clorecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clorecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dateCreatedDataGridViewTextBoxColumn,
            this.dateUpdatedDataGridViewTextBoxColumn,
            this.Delete,
            this.Edit});
            this.clorecord.DataSource = this.cloBindingSource;
            this.clorecord.Dock = System.Windows.Forms.DockStyle.Left;
            this.clorecord.Location = new System.Drawing.Point(0, 55);
            this.clorecord.Name = "clorecord";
            this.clorecord.Size = new System.Drawing.Size(788, 395);
            this.clorecord.TabIndex = 1;
            this.clorecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clorecord_CellContentClick);
            // 
            // cloBindingSource
            // 
            this.cloBindingSource.DataMember = "Clo";
            this.cloBindingSource.DataSource = this.projectBDataSet;
            // 
            // projectBDataSet
            // 
            this.projectBDataSet.DataSetName = "ProjectBDataSet";
            this.projectBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cloTableAdapter
            // 
            this.cloTableAdapter.ClearBeforeFill = true;
            // 
            // fKRubricCloBindingSource
            // 
            this.fKRubricCloBindingSource.DataMember = "FK_Rubric_Clo";
            this.fKRubricCloBindingSource.DataSource = this.cloBindingSource;
            // 
            // rubricTableAdapter
            // 
            this.rubricTableAdapter.ClearBeforeFill = true;
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
            // Edit
            // 
            this.Edit.DataPropertyName = "Id";
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // ManageCLOs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clorecord);
            this.Controls.Add(this.panel1);
            this.Name = "ManageCLOs";
            this.Text = "ManageCLOs";
            this.Load += new System.EventHandler(this.ManageCLOs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clorecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRubricCloBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnaddclo;
        private System.Windows.Forms.DataGridView clorecord;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private ProjectBDataSet projectBDataSet;
        private System.Windows.Forms.BindingSource cloBindingSource;
        private ProjectBDataSetTableAdapters.CloTableAdapter cloTableAdapter;
        private System.Windows.Forms.BindingSource fKRubricCloBindingSource;
        private ProjectBDataSetTableAdapters.RubricTableAdapter rubricTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateUpdatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
    }
}