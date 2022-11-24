namespace Homework
{
	partial class addFoodCategoriesFrom
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
			this.saveButton = new System.Windows.Forms.Button();
			this.priceTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.categoryNameTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(196, 135);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 16;
			this.saveButton.Text = "儲存";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// priceTextBox
			// 
			this.priceTextBox.Location = new System.Drawing.Point(93, 89);
			this.priceTextBox.Name = "priceTextBox";
			this.priceTextBox.Size = new System.Drawing.Size(178, 22);
			this.priceTextBox.TabIndex = 15;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(55, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 12);
			this.label3.TabIndex = 12;
			this.label3.Text = "單價:";
			// 
			// categoryNameTextBox
			// 
			this.categoryNameTextBox.Location = new System.Drawing.Point(93, 47);
			this.categoryNameTextBox.Name = "categoryNameTextBox";
			this.categoryNameTextBox.Size = new System.Drawing.Size(178, 22);
			this.categoryNameTextBox.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(31, 50);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 12);
			this.label4.TabIndex = 14;
			this.label4.Text = "食物名稱:";
			// 
			// addFoodCategoriesFrom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(321, 196);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.priceTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.categoryNameTextBox);
			this.Controls.Add(this.label4);
			this.Name = "addFoodCategoriesFrom";
			this.Text = "新增餐點類別";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.TextBox priceTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox categoryNameTextBox;
		private System.Windows.Forms.Label label4;
	}
}