﻿namespace WindowsFormsApp1
{
    partial class AddRubricLevel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtrubriclvldet = new System.Windows.Forms.TextBox();
            this.txtmeasulvl = new System.Windows.Forms.TextBox();
            this.comboBoxrubricid = new System.Windows.Forms.ComboBox();
            this.rubricBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet = new WindowsFormsApp1.ProjectBDataSet();
            this.rubricTableAdapter = new WindowsFormsApp1.ProjectBDataSetTableAdapters.RubricTableAdapter();
            this.btnadd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Rubric Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Rubric Level Detail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Measurement Level";
            // 
            // panel1
            // 
            this.panel1.AccessibleDescription = "";
            this.panel1.AccessibleName = "";
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 61);
            this.panel1.TabIndex = 22;
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
            this.label4.Text = "Add Rubric Level";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtrubriclvldet
            // 
            this.txtrubriclvldet.Location = new System.Drawing.Point(244, 121);
            this.txtrubriclvldet.Multiline = true;
            this.txtrubriclvldet.Name = "txtrubriclvldet";
            this.txtrubriclvldet.Size = new System.Drawing.Size(121, 45);
            this.txtrubriclvldet.TabIndex = 23;
            // 
            // txtmeasulvl
            // 
            this.txtmeasulvl.Location = new System.Drawing.Point(244, 176);
            this.txtmeasulvl.Name = "txtmeasulvl";
            this.txtmeasulvl.Size = new System.Drawing.Size(121, 20);
            this.txtmeasulvl.TabIndex = 24;
            // 
            // comboBoxrubricid
            // 
            this.comboBoxrubricid.DataSource = this.rubricBindingSource;
            this.comboBoxrubricid.DisplayMember = "Id";
            this.comboBoxrubricid.FormattingEnabled = true;
            this.comboBoxrubricid.Location = new System.Drawing.Point(244, 93);
            this.comboBoxrubricid.Name = "comboBoxrubricid";
            this.comboBoxrubricid.Size = new System.Drawing.Size(121, 21);
            this.comboBoxrubricid.TabIndex = 25;
            this.comboBoxrubricid.ValueMember = "Id";
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
            // rubricTableAdapter
            // 
            this.rubricTableAdapter.ClearBeforeFill = true;
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(172, 242);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 26;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // AddRubricLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.comboBoxrubricid);
            this.Controls.Add(this.txtmeasulvl);
            this.Controls.Add(this.txtrubriclvldet);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddRubricLevel";
            this.Text = "AddRubricLevel";
            this.Load += new System.EventHandler(this.AddRubricLevel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtrubriclvldet;
        private System.Windows.Forms.TextBox txtmeasulvl;
        private System.Windows.Forms.ComboBox comboBoxrubricid;
        private ProjectBDataSet projectBDataSet;
        private System.Windows.Forms.BindingSource rubricBindingSource;
        private ProjectBDataSetTableAdapters.RubricTableAdapter rubricTableAdapter;
        private System.Windows.Forms.Button btnadd;
    }
}