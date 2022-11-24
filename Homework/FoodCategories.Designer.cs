﻿namespace Homework
{
	partial class foodCategoriesForm
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.foodCategoryVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.addnewButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.foodCategoryVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.foodCategoryVMBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(39, 82);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(336, 231);
			this.dataGridView1.TabIndex = 3;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "餐點編號";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// categoryNameDataGridViewTextBoxColumn
			// 
			this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
			this.categoryNameDataGridViewTextBoxColumn.HeaderText = "餐點名稱";
			this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
			this.categoryNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// priceDataGridViewTextBoxColumn
			// 
			this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
			this.priceDataGridViewTextBoxColumn.HeaderText = "價格";
			this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			this.priceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// foodCategoryVMBindingSource
			// 
			this.foodCategoryVMBindingSource.DataSource = typeof(Homework.model.VM.FoodCategoryVM);
			// 
			// addnewButton
			// 
			this.addnewButton.Location = new System.Drawing.Point(275, 32);
			this.addnewButton.Name = "addnewButton";
			this.addnewButton.Size = new System.Drawing.Size(100, 23);
			this.addnewButton.TabIndex = 2;
			this.addnewButton.Text = "新增餐點類別";
			this.addnewButton.UseVisualStyleBackColor = true;
			this.addnewButton.Click += new System.EventHandler(this.addnewButton_Click);
			// 
			// foodCategoriesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(422, 349);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.addnewButton);
			this.Name = "foodCategoriesForm";
			this.Text = "餐點類別";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.foodCategoryVMBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button addnewButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource foodCategoryVMBindingSource;
	}
}