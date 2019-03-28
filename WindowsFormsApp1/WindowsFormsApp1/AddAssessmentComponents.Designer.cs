namespace WindowsFormsApp1
{
    partial class AddAssessmentComponents
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcompname = new System.Windows.Forms.TextBox();
            this.txttotalmarks = new System.Windows.Forms.TextBox();
            this.comboBoxRubricid = new System.Windows.Forms.ComboBox();
            this.rubricBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet = new WindowsFormsApp1.ProjectBDataSet();
            this.comboBoxAssessId = new System.Windows.Forms.ComboBox();
            this.assessmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rubricTableAdapter = new WindowsFormsApp1.ProjectBDataSetTableAdapters.RubricTableAdapter();
            this.assessmentTableAdapter = new WindowsFormsApp1.ProjectBDataSetTableAdapters.AssessmentTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(179, 252);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(89, 23);
            this.btnadd.TabIndex = 12;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Component Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Total Marks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Rubric ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Assessment Title";
            // 
            // txtcompname
            // 
            this.txtcompname.Location = new System.Drawing.Point(250, 84);
            this.txtcompname.Name = "txtcompname";
            this.txtcompname.Size = new System.Drawing.Size(122, 20);
            this.txtcompname.TabIndex = 18;
            // 
            // txttotalmarks
            // 
            this.txttotalmarks.Location = new System.Drawing.Point(251, 159);
            this.txttotalmarks.Name = "txttotalmarks";
            this.txttotalmarks.Size = new System.Drawing.Size(122, 20);
            this.txttotalmarks.TabIndex = 19;
            // 
            // comboBoxRubricid
            // 
            this.comboBoxRubricid.DataSource = this.rubricBindingSource;
            this.comboBoxRubricid.DisplayMember = "Id";
            this.comboBoxRubricid.FormattingEnabled = true;
            this.comboBoxRubricid.Location = new System.Drawing.Point(251, 123);
            this.comboBoxRubricid.Name = "comboBoxRubricid";
            this.comboBoxRubricid.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRubricid.TabIndex = 20;
            this.comboBoxRubricid.ValueMember = "Id";
            // 
            // rubricBindingSource
            // 
            this.rubricBindingSource.DataMember = "Rubric";
            this.rubricBindingSource.DataSource = this.projectBDataSet;
            // 
            // projectBDataSet
            // 
            this.projectBDataSet.DataSetName = "ProjectBDataSet";
            this.projectBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxAssessId
            // 
            this.comboBoxAssessId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.assessmentBindingSource, "Id", true));
            this.comboBoxAssessId.DataSource = this.assessmentBindingSource;
            this.comboBoxAssessId.DisplayMember = "Title";
            this.comboBoxAssessId.FormattingEnabled = true;
            this.comboBoxAssessId.Location = new System.Drawing.Point(251, 195);
            this.comboBoxAssessId.Name = "comboBoxAssessId";
            this.comboBoxAssessId.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAssessId.TabIndex = 21;
            this.comboBoxAssessId.ValueMember = "Id";
            // 
            // assessmentBindingSource
            // 
            this.assessmentBindingSource.DataMember = "Assessment";
            this.assessmentBindingSource.DataSource = this.projectBDataSet;
            // 
            // rubricTableAdapter
            // 
            this.rubricTableAdapter.ClearBeforeFill = true;
            // 
            // assessmentTableAdapter
            // 
            this.assessmentTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.AccessibleDescription = "";
            this.panel1.AccessibleName = "";
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 61);
            this.panel1.TabIndex = 23;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(0, 45);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(38, 16);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "back";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(270, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Add Assessment component";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddAssessmentComponents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxAssessId);
            this.Controls.Add(this.comboBoxRubricid);
            this.Controls.Add(this.txttotalmarks);
            this.Controls.Add(this.txtcompname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnadd);
            this.Name = "AddAssessmentComponents";
            this.Text = "AddAssessmentComponents";
            this.Load += new System.EventHandler(this.AddAssessmentComponents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcompname;
        private System.Windows.Forms.TextBox txttotalmarks;
        private System.Windows.Forms.ComboBox comboBoxRubricid;
        private System.Windows.Forms.ComboBox comboBoxAssessId;
        private ProjectBDataSet projectBDataSet;
        private System.Windows.Forms.BindingSource rubricBindingSource;
        private ProjectBDataSetTableAdapters.RubricTableAdapter rubricTableAdapter;
        private System.Windows.Forms.BindingSource assessmentBindingSource;
        private ProjectBDataSetTableAdapters.AssessmentTableAdapter assessmentTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}