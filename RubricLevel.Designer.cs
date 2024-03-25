namespace WindowsFormsApp5
{
    partial class RubricLevel
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
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RubricLev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RubricId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasurementLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rubricBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet6 = new WindowsFormsApp5.ProjectBDataSet6();
            this.rubricTableAdapter = new WindowsFormsApp5.ProjectBDataSet6TableAdapters.RubricTableAdapter();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.projectBDataSet7 = new WindowsFormsApp5.ProjectBDataSet7();
            this.rubricBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rubricTableAdapter1 = new WindowsFormsApp5.ProjectBDataSet7TableAdapters.RubricTableAdapter();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rubric Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rubric Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RubricLev,
            this.RubricId,
            this.Details,
            this.MeasurementLevel});
            this.dataGridView1.Location = new System.Drawing.Point(500, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(664, 315);
            this.dataGridView1.TabIndex = 3;
            // 
            // RubricLev
            // 
            this.RubricLev.HeaderText = "RubricLevel ID";
            this.RubricLev.MinimumWidth = 8;
            this.RubricLev.Name = "RubricLev";
            this.RubricLev.Width = 150;
            // 
            // RubricId
            // 
            this.RubricId.HeaderText = "Rubric Id";
            this.RubricId.MinimumWidth = 8;
            this.RubricId.Name = "RubricId";
            this.RubricId.Width = 150;
            // 
            // Details
            // 
            this.Details.HeaderText = "Details";
            this.Details.MinimumWidth = 8;
            this.Details.Name = "Details";
            this.Details.Width = 150;
            // 
            // MeasurementLevel
            // 
            this.MeasurementLevel.HeaderText = "Measurement Level";
            this.MeasurementLevel.MinimumWidth = 8;
            this.MeasurementLevel.Name = "MeasurementLevel";
            this.MeasurementLevel.Width = 150;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(123, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 60);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(433, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 60);
            this.button2.TabIndex = 5;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1050, 382);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 60);
            this.button3.TabIndex = 6;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(77, 549);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(64, 25);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Home";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(599, 549);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(222, 25);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "AssessmentComponent";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.Location = new System.Drawing.Point(1035, 549);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(134, 25);
            this.linkLabel3.TabIndex = 9;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "StudentResult";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(297, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 26);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Measurement Level";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rubricBindingSource, "Id", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(297, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 28);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rubricBindingSource
            // 
            this.rubricBindingSource.DataMember = "Rubric";
            this.rubricBindingSource.DataSource = this.projectBDataSet6;
            // 
            // projectBDataSet6
            // 
            this.projectBDataSet6.DataSetName = "ProjectBDataSet6";
            this.projectBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rubricTableAdapter
            // 
            this.rubricTableAdapter.ClearBeforeFill = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(297, 225);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 26);
            this.textBox2.TabIndex = 15;
            // 
            // projectBDataSet7
            // 
            this.projectBDataSet7.DataSetName = "ProjectBDataSet7";
            this.projectBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rubricBindingSource1
            // 
            this.rubricBindingSource1.DataMember = "Rubric";
            this.rubricBindingSource1.DataSource = this.projectBDataSet7;
            // 
            // rubricTableAdapter1
            // 
            this.rubricTableAdapter1.ClearBeforeFill = true;
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.Location = new System.Drawing.Point(329, 549);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(82, 25);
            this.linkLabel4.TabIndex = 16;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Look up";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // RubricLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 616);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "RubricLevel";
            this.Text = "RubricLevel";
            this.Load += new System.EventHandler(this.RubricLevel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private ProjectBDataSet6 projectBDataSet6;
        private System.Windows.Forms.BindingSource rubricBindingSource;
        private ProjectBDataSet6TableAdapters.RubricTableAdapter rubricTableAdapter;
        private System.Windows.Forms.TextBox textBox2;
        private ProjectBDataSet7 projectBDataSet7;
        private System.Windows.Forms.BindingSource rubricBindingSource1;
        private ProjectBDataSet7TableAdapters.RubricTableAdapter rubricTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RubricLev;
        private System.Windows.Forms.DataGridViewTextBoxColumn RubricId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Details;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasurementLevel;
        private System.Windows.Forms.LinkLabel linkLabel4;
    }
}