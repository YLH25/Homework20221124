using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}
		private void loginButton_Click(object sender, EventArgs e)
		{
			string account=accountTextBox.Text;
			string password=passwordTextBox.Text;
			bool anyNullOrEmpty = false;
			
			if (string.IsNullOrEmpty(account)) 
			{
				errorProvider1.SetError(accountTextBox, "帳號沒填");
				anyNullOrEmpty = true;
				//return;
			}
			if (string.IsNullOrEmpty(password))
			{
				errorProvider2.SetError(passwordTextBox, "密碼沒填");
				anyNullOrEmpty = true;
				//return ;
			}
			if (!string.IsNullOrEmpty(account))
			{
				errorProvider1.SetError(accountTextBox, "帳號沒填");
				
				errorProvider1.Clear();
				//return;
			}
			if (!string.IsNullOrEmpty(password))
			{
				errorProvider2.SetError(passwordTextBox, "密碼沒填");
				
				errorProvider2.Clear();
				//return ;
			}


			

			if (account == "allen" && password == "allen"&& anyNullOrEmpty==false)
			{
				var frm=new OrdersForm();
				frm.Show();
				this.Close();
			}
			if(account != "allen" && anyNullOrEmpty == false || password != "allen"&&anyNullOrEmpty == false)
			{

				MessageBox.Show("帳號密碼錯誤");
			}
			
		}
	}
}
