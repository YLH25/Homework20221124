namespace Homework
{
	partial class addOrderFrom
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
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.categoryComboBox = new System.Windows.Forms.ComboBox();
			this.foodCategoryVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.amountTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.saveButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.foodCategoryVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// NameTextBox
			// 
			this.NameTextBox.Location = new System.Drawing.Point(71, 30);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(121, 22);
			this.NameTextBox.TabIndex = 0;
			// 
			// categoryComboBox
			// 
			this.categoryComboBox.DataSource = this.foodCategoryVMBindingSource;
			this.categoryComboBox.DisplayMember = "CategoryName";
			this.categoryComboBox.FormattingEnabled = true;
			this.categoryComboBox.Location = new System.Drawing.Point(71, 69);
			this.categoryComboBox.Name = "categoryComboBox";
			this.categoryComboBox.Size = new System.Drawing.Size(121, 20);
			this.categoryComboBox.TabIndex = 1;
			this.categoryComboBox.ValueMember = "CategoryName";
			// 
			// foodCategoryVMBindingSource
			// 
			this.foodCategoryVMBindingSource.DataSource = typeof(Homework.model.VM.FoodCategoryVM);
			// 
			// amountTextBox
			// 
			this.amountTextBox.Location = new System.Drawing.Point(71, 111);
			this.amountTextBox.Name = "amountTextBox";
			this.amountTextBox.Size = new System.Drawing.Size(121, 22);
			this.amountTextBox.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 7;
			this.label3.Text = "數量";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 8;
			this.label2.Text = "餐點";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 9;
			this.label1.Text = "點餐人";
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(71, 150);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 10;
			this.saveButton.Text = "新增";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// addOrderFrom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(234, 211);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.amountTextBox);
			this.Controls.Add(this.categoryComboBox);
			this.Controls.Add(this.NameTextBox);
			this.Name = "addOrderFrom";
			this.Text = "新增訂單";
			((System.ComponentModel.ISupportInitialize)(this.foodCategoryVMBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.ComboBox categoryComboBox;
		private System.Windows.Forms.TextBox amountTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.BindingSource foodCategoryVMBindingSource;
	}
}