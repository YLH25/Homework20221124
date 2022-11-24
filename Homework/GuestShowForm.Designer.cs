namespace Homework
{
	partial class GuestShowForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.後臺維護ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.refreshButton = new System.Windows.Forms.Button();
			this.searchButton = new System.Windows.Forms.Button();
			this.categoryIdComboBox = new System.Windows.Forms.ComboBox();
			this.foodCategoryVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.addButton = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.foodCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.Menubutton = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.foodCategoryVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderIndexVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.後臺維護ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(554, 24);
			this.menuStrip1.TabIndex = 8;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 後臺維護ToolStripMenuItem
			// 
			this.後臺維護ToolStripMenuItem.Name = "後臺維護ToolStripMenuItem";
			this.後臺維護ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.後臺維護ToolStripMenuItem.Text = "後臺維護";
			this.後臺維護ToolStripMenuItem.Click += new System.EventHandler(this.後臺維護ToolStripMenuItem_Click);
			// 
			// refreshButton
			// 
			this.refreshButton.Location = new System.Drawing.Point(366, 46);
			this.refreshButton.Name = "refreshButton";
			this.refreshButton.Size = new System.Drawing.Size(75, 23);
			this.refreshButton.TabIndex = 12;
			this.refreshButton.Text = "重新整理";
			this.refreshButton.UseVisualStyleBackColor = true;
			this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(159, 46);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(75, 23);
			this.searchButton.TabIndex = 13;
			this.searchButton.Text = "搜尋";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// categoryIdComboBox
			// 
			this.categoryIdComboBox.DataSource = this.foodCategoryVMBindingSource;
			this.categoryIdComboBox.DisplayMember = "CategoryName";
			this.categoryIdComboBox.FormattingEnabled = true;
			this.categoryIdComboBox.Location = new System.Drawing.Point(32, 48);
			this.categoryIdComboBox.Name = "categoryIdComboBox";
			this.categoryIdComboBox.Size = new System.Drawing.Size(121, 20);
			this.categoryIdComboBox.TabIndex = 11;
			this.categoryIdComboBox.ValueMember = "Id";
			// 
			// foodCategoryVMBindingSource
			// 
			this.foodCategoryVMBindingSource.DataSource = typeof(Homework.model.VM.FoodCategoryVM);
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(447, 46);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(75, 23);
			this.addButton.TabIndex = 10;
			this.addButton.Text = "新增訂單";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.orderNameDataGridViewTextBoxColumn,
            this.foodCategoryDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.orderIndexVMBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(32, 91);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(490, 330);
			this.dataGridView1.TabIndex = 9;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "訂單編號";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// orderNameDataGridViewTextBoxColumn
			// 
			this.orderNameDataGridViewTextBoxColumn.DataPropertyName = "OrderName";
			this.orderNameDataGridViewTextBoxColumn.HeaderText = "訂餐人";
			this.orderNameDataGridViewTextBoxColumn.Name = "orderNameDataGridViewTextBoxColumn";
			this.orderNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// foodCategoryDataGridViewTextBoxColumn
			// 
			this.foodCategoryDataGridViewTextBoxColumn.DataPropertyName = "FoodCategory";
			this.foodCategoryDataGridViewTextBoxColumn.HeaderText = "餐點名稱";
			this.foodCategoryDataGridViewTextBoxColumn.Name = "foodCategoryDataGridViewTextBoxColumn";
			this.foodCategoryDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// amountDataGridViewTextBoxColumn
			// 
			this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
			this.amountDataGridViewTextBoxColumn.HeaderText = "數量";
			this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
			this.amountDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// orderIndexVMBindingSource
			// 
			this.orderIndexVMBindingSource.DataSource = typeof(Homework.model.VM.OrderIndexVM);
			// 
			// Menubutton
			// 
			this.Menubutton.Location = new System.Drawing.Point(240, 45);
			this.Menubutton.Name = "Menubutton";
			this.Menubutton.Size = new System.Drawing.Size(75, 23);
			this.Menubutton.TabIndex = 13;
			this.Menubutton.Text = "菜單";
			this.Menubutton.UseVisualStyleBackColor = true;
			this.Menubutton.Click += new System.EventHandler(this.Menubutton_Click);
			// 
			// GuestShowForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(554, 446);
			this.Controls.Add(this.refreshButton);
			this.Controls.Add(this.Menubutton);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.categoryIdComboBox);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "GuestShowForm";
			this.Text = "訂餐系統";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.foodCategoryVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderIndexVMBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 後臺維護ToolStripMenuItem;
		private System.Windows.Forms.Button refreshButton;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.ComboBox categoryIdComboBox;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource foodCategoryVMBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn foodCategoryDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource orderIndexVMBindingSource;
		private System.Windows.Forms.Button Menubutton;
	}
}