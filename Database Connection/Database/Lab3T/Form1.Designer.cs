namespace Lab3T
{
    partial class Form1
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
			this.listBoxUniv = new System.Windows.Forms.ListBox();
			this.listBoxFac = new System.Windows.Forms.ListBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.insert = new System.Windows.Forms.Button();
			this.update = new System.Windows.Forms.Button();
			this.delete = new System.Windows.Forms.Button();
			this.textBoxId = new System.Windows.Forms.TextBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxCode = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxCity = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.add = new System.Windows.Forms.Button();
			this.deleteBtn = new System.Windows.Forms.Button();
			this.idFac = new System.Windows.Forms.TextBox();
			this.numeFac = new System.Windows.Forms.TextBox();
			this.codeFac = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.database1DataSet = new Lab3T.Database1DataSet();
			this.facultatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.facultatiTableAdapter = new Lab3T.Database1DataSetTableAdapters.FacultatiTableAdapter();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameFacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.facultatiBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// listBoxUniv
			// 
			this.listBoxUniv.FormattingEnabled = true;
			this.listBoxUniv.ItemHeight = 16;
			this.listBoxUniv.Location = new System.Drawing.Point(63, 32);
			this.listBoxUniv.Margin = new System.Windows.Forms.Padding(4);
			this.listBoxUniv.Name = "listBoxUniv";
			this.listBoxUniv.Size = new System.Drawing.Size(159, 196);
			this.listBoxUniv.TabIndex = 0;
			this.listBoxUniv.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// listBoxFac
			// 
			this.listBoxFac.FormattingEnabled = true;
			this.listBoxFac.ItemHeight = 16;
			this.listBoxFac.Location = new System.Drawing.Point(360, 39);
			this.listBoxFac.Margin = new System.Windows.Forms.Padding(4);
			this.listBoxFac.Name = "listBoxFac";
			this.listBoxFac.Size = new System.Drawing.Size(159, 196);
			this.listBoxFac.TabIndex = 1;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(63, 270);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(159, 22);
			this.textBox1.TabIndex = 2;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(63, 328);
			this.textBox2.Margin = new System.Windows.Forms.Padding(4);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(159, 22);
			this.textBox2.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(61, 249);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Code";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(61, 307);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "City";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(60, 11);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "Univ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(356, 11);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(31, 17);
			this.label4.TabIndex = 7;
			this.label4.Text = "Fac";
			// 
			// insert
			// 
			this.insert.Location = new System.Drawing.Point(360, 262);
			this.insert.Margin = new System.Windows.Forms.Padding(4);
			this.insert.Name = "insert";
			this.insert.Size = new System.Drawing.Size(100, 28);
			this.insert.TabIndex = 8;
			this.insert.Text = "Insert";
			this.insert.UseVisualStyleBackColor = true;
			this.insert.Click += new System.EventHandler(this.insert_Click);
			// 
			// update
			// 
			this.update.Location = new System.Drawing.Point(360, 301);
			this.update.Margin = new System.Windows.Forms.Padding(4);
			this.update.Name = "update";
			this.update.Size = new System.Drawing.Size(100, 28);
			this.update.TabIndex = 9;
			this.update.Text = "Update";
			this.update.UseVisualStyleBackColor = true;
			this.update.Click += new System.EventHandler(this.update_Click);
			// 
			// delete
			// 
			this.delete.Location = new System.Drawing.Point(359, 343);
			this.delete.Margin = new System.Windows.Forms.Padding(4);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(100, 28);
			this.delete.TabIndex = 10;
			this.delete.Text = "Delete";
			this.delete.UseVisualStyleBackColor = true;
			this.delete.Click += new System.EventHandler(this.delete_Click);
			// 
			// textBoxId
			// 
			this.textBoxId.Location = new System.Drawing.Point(589, 156);
			this.textBoxId.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxId.Name = "textBoxId";
			this.textBoxId.Size = new System.Drawing.Size(132, 22);
			this.textBoxId.TabIndex = 11;
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(589, 226);
			this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(132, 22);
			this.textBoxName.TabIndex = 12;
			// 
			// textBoxCode
			// 
			this.textBoxCode.Location = new System.Drawing.Point(589, 289);
			this.textBoxCode.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxCode.Name = "textBoxCode";
			this.textBoxCode.Size = new System.Drawing.Size(132, 22);
			this.textBoxCode.TabIndex = 13;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(586, 123);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(19, 17);
			this.label5.TabIndex = 14;
			this.label5.Text = "Id";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(586, 195);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(70, 17);
			this.label6.TabIndex = 15;
			this.label6.Text = "University";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(586, 268);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(41, 17);
			this.label7.TabIndex = 16;
			this.label7.Text = "Code";
			// 
			// textBoxCity
			// 
			this.textBoxCity.Location = new System.Drawing.Point(589, 363);
			this.textBoxCity.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxCity.Name = "textBoxCity";
			this.textBoxCity.Size = new System.Drawing.Size(132, 22);
			this.textBoxCity.TabIndex = 17;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(586, 331);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(31, 17);
			this.label8.TabIndex = 18;
			this.label8.Text = "City";
			// 
			// dataGridView
			// 
			this.dataGridView.AutoGenerateColumns = false;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.nameFacDataGridViewTextBoxColumn});
			this.dataGridView.DataSource = this.facultatiBindingSource;
			this.dataGridView.Location = new System.Drawing.Point(63, 405);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 51;
			this.dataGridView.RowTemplate.Height = 24;
			this.dataGridView.Size = new System.Drawing.Size(648, 335);
			this.dataGridView.TabIndex = 19;
			// 
			// add
			// 
			this.add.Location = new System.Drawing.Point(774, 641);
			this.add.Name = "add";
			this.add.Size = new System.Drawing.Size(75, 23);
			this.add.TabIndex = 20;
			this.add.Text = "Add";
			this.add.UseVisualStyleBackColor = true;
			this.add.Click += new System.EventHandler(this.add_Click);
			// 
			// deleteBtn
			// 
			this.deleteBtn.Location = new System.Drawing.Point(890, 641);
			this.deleteBtn.Name = "deleteBtn";
			this.deleteBtn.Size = new System.Drawing.Size(75, 23);
			this.deleteBtn.TabIndex = 21;
			this.deleteBtn.Text = "Delete";
			this.deleteBtn.UseVisualStyleBackColor = true;
			this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
			// 
			// idFac
			// 
			this.idFac.Location = new System.Drawing.Point(865, 467);
			this.idFac.Name = "idFac";
			this.idFac.Size = new System.Drawing.Size(100, 22);
			this.idFac.TabIndex = 22;
			// 
			// numeFac
			// 
			this.numeFac.Location = new System.Drawing.Point(865, 565);
			this.numeFac.Name = "numeFac";
			this.numeFac.Size = new System.Drawing.Size(100, 22);
			this.numeFac.TabIndex = 23;
			// 
			// codeFac
			// 
			this.codeFac.Location = new System.Drawing.Point(865, 519);
			this.codeFac.Name = "codeFac";
			this.codeFac.Size = new System.Drawing.Size(100, 22);
			this.codeFac.TabIndex = 24;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(756, 472);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(19, 17);
			this.label9.TabIndex = 25;
			this.label9.Text = "Id";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(756, 568);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(102, 17);
			this.label10.TabIndex = 26;
			this.label10.Text = "Nume Facultati";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(756, 524);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(41, 17);
			this.label11.TabIndex = 27;
			this.label11.Text = "Code";
			// 
			// database1DataSet
			// 
			this.database1DataSet.DataSetName = "Database1DataSet";
			this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// facultatiBindingSource
			// 
			this.facultatiBindingSource.DataMember = "Facultati";
			this.facultatiBindingSource.DataSource = this.database1DataSet;
			// 
			// facultatiTableAdapter
			// 
			this.facultatiTableAdapter.ClearBeforeFill = true;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.Width = 125;
			// 
			// codeDataGridViewTextBoxColumn
			// 
			this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
			this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
			this.codeDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
			this.codeDataGridViewTextBoxColumn.Width = 125;
			// 
			// nameFacDataGridViewTextBoxColumn
			// 
			this.nameFacDataGridViewTextBoxColumn.DataPropertyName = "NameFac";
			this.nameFacDataGridViewTextBoxColumn.HeaderText = "NameFac";
			this.nameFacDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.nameFacDataGridViewTextBoxColumn.Name = "nameFacDataGridViewTextBoxColumn";
			this.nameFacDataGridViewTextBoxColumn.Width = 125;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1055, 763);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.codeFac);
			this.Controls.Add(this.numeFac);
			this.Controls.Add(this.idFac);
			this.Controls.Add(this.deleteBtn);
			this.Controls.Add(this.add);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textBoxCity);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxCode);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.textBoxId);
			this.Controls.Add(this.delete);
			this.Controls.Add(this.update);
			this.Controls.Add(this.insert);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.listBoxFac);
			this.Controls.Add(this.listBoxUniv);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.facultatiBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUniv;
        private System.Windows.Forms.ListBox listBoxFac;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button add;
		private System.Windows.Forms.Button deleteBtn;
		private System.Windows.Forms.TextBox idFac;
		private System.Windows.Forms.TextBox numeFac;
		private System.Windows.Forms.TextBox codeFac;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private Database1DataSet database1DataSet;
		private System.Windows.Forms.BindingSource facultatiBindingSource;
		private Database1DataSetTableAdapters.FacultatiTableAdapter facultatiTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameFacDataGridViewTextBoxColumn;
	}
}

