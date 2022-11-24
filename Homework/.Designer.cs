namespace Homework
{
	partial class OrdersForm
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.foodCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.addButton = new System.Windows.Forms.Button();
			this.searchButton = new System.Windows.Forms.Button();
			this.categoryIdComboBox = new System.Windows.Forms.ComboBox();
			this.foodCategoryVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.維護餐點類別ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.清空訂單ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.count = new System.Windows.Forms.Button();
			this.refreshButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.foodCategoryVMBindingSource)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.orderNameDataGridViewTextBoxColumn,
            this.foodCategoryDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.orderIndexVMBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(32, 83);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(490, 330);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
			this.dataGridViewTextBoxColumn1.HeaderText = "訂單編號";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(366, 36);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(75, 23);
			this.addButton.TabIndex = 1;
			this.addButton.Text = "新增訂單";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(169, 36);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(75, 23);
			this.searchButton.TabIndex = 3;
			this.searchButton.Text = "搜尋";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// categoryIdComboBox
			// 
			this.categoryIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.foodCategoryVMBindingSource, "Id", true));
			this.categoryIdComboBox.DataSource = this.foodCategoryVMBindingSource;
			this.categoryIdComboBox.DisplayMember = "CategoryName";
			this.categoryIdComboBox.FormattingEnabled = true;
			this.categoryIdComboBox.Location = new System.Drawing.Point(32, 40);
			this.categoryIdComboBox.Name = "categoryIdComboBox";
			this.categoryIdComboBox.Size = new System.Drawing.Size(121, 20);
			this.categoryIdComboBox.TabIndex = 2;
			this.categoryIdComboBox.ValueMember = "Id";
			// 
			// foodCategoryVMBindingSource
			// 
			this.foodCategoryVMBindingSource.DataSource = typeof(Homework.model.VM.FoodCategoryVM);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.維護餐點類別ToolStripMenuItem,
            this.清空訂單ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(554, 24);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 維護餐點類別ToolStripMenuItem
			// 
			this.維護餐點類別ToolStripMenuItem.Name = "維護餐點類別ToolStripMenuItem";
			this.維護餐點類別ToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
			this.維護餐點類別ToolStripMenuItem.Text = "維護餐點類別";
			this.維護餐點類別ToolStripMenuItem.Click += new System.EventHandler(this.維護餐點類別ToolStripMenuItem_Click);
			// 
			// 清空訂單ToolStripMenuItem
			// 
			this.清空訂單ToolStripMenuItem.Name = "清空訂單ToolStripMenuItem";
			this.清空訂單ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.清空訂單ToolStripMenuItem.Text = "清空訂單";
			this.清空訂單ToolStripMenuItem.Click += new System.EventHandler(this.清空訂單ToolStripMenuItem_Click);
			// 
			// count
			// 
			this.count.Location = new System.Drawing.Point(447, 36);
			this.count.Name = "count";
			this.count.Size = new System.Drawing.Size(75, 23);
			this.count.TabIndex = 5;
			this.count.Text = "計算";
			this.count.UseVisualStyleBackColor = true;
			this.count.Click += new System.EventHandler(this.count_Click);
			// 
			// refreshButton
			// 
			this.refreshButton.Location = new System.Drawing.Point(250, 36);
			this.refreshButton.Name = "refreshButton";
			this.refreshButton.Size = new System.Drawing.Size(75, 23);
			this.refreshButton.TabIndex = 3;
			this.refreshButton.Text = "重新整理";
			this.refreshButton.UseVisualStyleBackColor = true;
			this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
			// 
			// OrdersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(554, 446);
			this.Controls.Add(this.count);
			this.Controls.Add(this.refreshButton);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.categoryIdComboBox);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "OrdersForm";
			this.Text = "訂餐維護系統";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.foodCategoryVMBindingSource)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.ComboBox categoryIdComboBox;
		private System.Windows.Forms.BindingSource foodCategoryVMBindingSource;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 維護餐點類別ToolStripMenuItem;
		private System.Windows.Forms.Button count;
		private System.Windows.Forms.ToolStripMenuItem 清空訂單ToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button refreshButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn foodCategoryDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource orderIndexVMBindingSource;
	}
}

