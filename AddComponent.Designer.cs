namespace WindowsFormsApp5
{
    partial class AddComponent
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.assessmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet9 = new WindowsFormsApp5.ProjectBDataSet9();
            this.assessmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet1 = new WindowsFormsApp5.ProjectBDataSet1();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.rubricBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet8 = new WindowsFormsApp5.ProjectBDataSet8();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.assessmentTableAdapter = new WindowsFormsApp5.ProjectBDataSet1TableAdapters.AssessmentTableAdapter();
            this.rubricTableAdapter = new WindowsFormsApp5.ProjectBDataSet8TableAdapters.RubricTableAdapter();
            this.assessmentTableAdapter1 = new WindowsFormsApp5.ProjectBDataSet9TableAdapters.AssessmentTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.assessmentComponentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet10 = new WindowsFormsApp5.ProjectBDataSet10();
            this.assessmentComponentTableAdapter = new WindowsFormsApp5.ProjectBDataSet10TableAdapters.AssessmentComponentTableAdapter();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RubricId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateUpdated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssessmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentComponentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Assessment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(582, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Marks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(582, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rubric";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(241, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(778, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 26);
            this.textBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.assessmentBindingSource1, "Id", true));
            this.comboBox1.DataSource = this.assessmentBindingSource1;
            this.comboBox1.DisplayMember = "Id";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(241, 123);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 28);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "Id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // assessmentBindingSource1
            // 
            this.assessmentBindingSource1.DataMember = "Assessment";
            this.assessmentBindingSource1.DataSource = this.projectBDataSet9;
            // 
            // projectBDataSet9
            // 
            this.projectBDataSet9.DataSetName = "ProjectBDataSet9";
            this.projectBDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assessmentBindingSource
            // 
            this.assessmentBindingSource.DataMember = "Assessment";
            this.assessmentBindingSource.DataSource = this.projectBDataSet1;
            // 
            // projectBDataSet1
            // 
            this.projectBDataSet1.DataSetName = "ProjectBDataSet1";
            this.projectBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rubricBindingSource, "Id", true));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(778, 127);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(153, 28);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // rubricBindingSource
            // 
            this.rubricBindingSource.DataMember = "Rubric";
            this.rubricBindingSource.DataSource = this.projectBDataSet8;
            // 
            // projectBDataSet8
            // 
            this.projectBDataSet8.DataSetName = "ProjectBDataSet8";
            this.projectBDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name1,
            this.RubricId,
            this.TotalMarks,
            this.DateCreated,
            this.DateUpdated,
            this.AssessmentId});
            this.dataGridView1.Location = new System.Drawing.Point(12, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1119, 279);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 51);
            this.button1.TabIndex = 9;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(889, 495);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 51);
            this.button2.TabIndex = 10;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(68, 575);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(64, 25);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Home";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(493, 575);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(192, 25);
            this.linkLabel2.TabIndex = 12;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "ManageAssessment";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.Location = new System.Drawing.Point(986, 575);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(114, 25);
            this.linkLabel3.TabIndex = 13;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "RubricLevel";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // assessmentTableAdapter
            // 
            this.assessmentTableAdapter.ClearBeforeFill = true;
            // 
            // rubricTableAdapter
            // 
            this.rubricTableAdapter.ClearBeforeFill = true;
            // 
            // assessmentTableAdapter1
            // 
            this.assessmentTableAdapter1.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(108, 495);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 51);
            this.button3.TabIndex = 14;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // assessmentComponentBindingSource
            // 
            this.assessmentComponentBindingSource.DataMember = "AssessmentComponent";
            this.assessmentComponentBindingSource.DataSource = this.projectBDataSet10;
            // 
            // projectBDataSet10
            // 
            this.projectBDataSet10.DataSetName = "ProjectBDataSet10";
            this.projectBDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assessmentComponentTableAdapter
            // 
            this.assessmentComponentTableAdapter.ClearBeforeFill = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 150;
            // 
            // Name1
            // 
            this.Name1.HeaderText = "Name";
            this.Name1.MinimumWidth = 8;
            this.Name1.Name = "Name1";
            this.Name1.Width = 150;
            // 
            // RubricId
            // 
            this.RubricId.HeaderText = "RubricId";
            this.RubricId.MinimumWidth = 8;
            this.RubricId.Name = "RubricId";
            this.RubricId.Width = 150;
            // 
            // TotalMarks
            // 
            this.TotalMarks.HeaderText = "TotalMarks";
            this.TotalMarks.MinimumWidth = 8;
            this.TotalMarks.Name = "TotalMarks";
            this.TotalMarks.Width = 150;
            // 
            // DateCreated
            // 
            this.DateCreated.HeaderText = "DateCreated";
            this.DateCreated.MinimumWidth = 8;
            this.DateCreated.Name = "DateCreated";
            this.DateCreated.Width = 150;
            // 
            // DateUpdated
            // 
            this.DateUpdated.HeaderText = "DateUpdated";
            this.DateUpdated.MinimumWidth = 8;
            this.DateUpdated.Name = "DateUpdated";
            this.DateUpdated.Width = 150;
            // 
            // AssessmentId
            // 
            this.AssessmentId.HeaderText = "AssessmentId";
            this.AssessmentId.MinimumWidth = 8;
            this.AssessmentId.Name = "AssessmentId";
            this.AssessmentId.Width = 150;
            // 
            // AddComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 599);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddComponent";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.AddComponent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assessmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentComponentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private ProjectBDataSet1 projectBDataSet1;
        private System.Windows.Forms.BindingSource assessmentBindingSource;
        private ProjectBDataSet1TableAdapters.AssessmentTableAdapter assessmentTableAdapter;
        private ProjectBDataSet8 projectBDataSet8;
        private System.Windows.Forms.BindingSource rubricBindingSource;
        private ProjectBDataSet8TableAdapters.RubricTableAdapter rubricTableAdapter;
        private ProjectBDataSet9 projectBDataSet9;
        private System.Windows.Forms.BindingSource assessmentBindingSource1;
        private ProjectBDataSet9TableAdapters.AssessmentTableAdapter assessmentTableAdapter1;
        private System.Windows.Forms.Button button3;
        private ProjectBDataSet10 projectBDataSet10;
        private System.Windows.Forms.BindingSource assessmentComponentBindingSource;
        private ProjectBDataSet10TableAdapters.AssessmentComponentTableAdapter assessmentComponentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RubricId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateUpdated;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssessmentId;
    }
}