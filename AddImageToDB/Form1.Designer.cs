namespace C_
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.imageNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.imageUrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.imagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.testDataSet = new C_.TestDataSet();
			this.imagesTableAdapter = new C_.TestDataSetTableAdapters.ImagesTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imagesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(82, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(213, 22);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Name";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(82, 61);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(213, 169);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Image";
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(321, 61);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnBrowse.TabIndex = 4;
			this.btnBrowse.Text = "Browse";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(321, 107);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.imageNameDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn,
            this.imageUrlDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.imagesBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 257);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 100;
			this.dataGridView1.Size = new System.Drawing.Size(1078, 312);
			this.dataGridView1.TabIndex = 6;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.Width = 125;
			// 
			// imageNameDataGridViewTextBoxColumn
			// 
			this.imageNameDataGridViewTextBoxColumn.DataPropertyName = "ImageName";
			this.imageNameDataGridViewTextBoxColumn.HeaderText = "ImageName";
			this.imageNameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.imageNameDataGridViewTextBoxColumn.Name = "imageNameDataGridViewTextBoxColumn";
			this.imageNameDataGridViewTextBoxColumn.Width = 200;
			// 
			// imageDataGridViewImageColumn
			// 
			this.imageDataGridViewImageColumn.DataPropertyName = "Image";
			this.imageDataGridViewImageColumn.HeaderText = "Image";
			this.imageDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.imageDataGridViewImageColumn.MinimumWidth = 6;
			this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
			this.imageDataGridViewImageColumn.Width = 400;
			// 
			// imageUrlDataGridViewTextBoxColumn
			// 
			this.imageUrlDataGridViewTextBoxColumn.DataPropertyName = "ImageUrl";
			this.imageUrlDataGridViewTextBoxColumn.HeaderText = "ImageUrl";
			this.imageUrlDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.imageUrlDataGridViewTextBoxColumn.Name = "imageUrlDataGridViewTextBoxColumn";
			this.imageUrlDataGridViewTextBoxColumn.Width = 300;
			// 
			// imagesBindingSource
			// 
			this.imagesBindingSource.DataMember = "Images";
			this.imagesBindingSource.DataSource = this.testDataSet;
			// 
			// testDataSet
			// 
			this.testDataSet.DataSetName = "TestDataSet";
			this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// imagesTableAdapter
			// 
			this.imagesTableAdapter.ClearBeforeFill = true;
			// 
			
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1102, 581);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imagesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.DataGridView dataGridView1;
		private TestDataSet testDataSet;
		private System.Windows.Forms.BindingSource imagesBindingSource;
		private TestDataSetTableAdapters.ImagesTableAdapter imagesTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn imageNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn imageUrlDataGridViewTextBoxColumn;
	}
}

