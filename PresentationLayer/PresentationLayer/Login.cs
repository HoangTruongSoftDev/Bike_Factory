using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        #region//This region is about declare the Fields, Essential Methods,...
        List<Account> listOfAccountLogin = new List<Account>();
        private void LoginUser()
        {
            listOfAccountLogin.Clear();
            listOfAccountLogin = FileHandlerAccount.ReadFromFileAccounts();
            bool search = false;
            if (this.textBoxUserNameLogin.Text.Length > 0)
            {
                foreach (Account searchAccount in listOfAccountLogin)
                {
                    if (this.textBoxUserNameLogin.Text == searchAccount.Username)
                    {
                        if (this.textBoxPasswordLogin.Text == searchAccount.Password)
                        {
                            search = true;

                            var asking = MessageBox.Show("Your account is matched!!!\nDo you want to login?", "Successfully", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (asking == DialogResult.Yes)
                            {
                                Form1 applicationForm = new Form1();
                                MessageBox.Show("Login Successfully", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                applicationForm.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Your Login Procedure has been stopped", "Warninng", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                    }
                }
                if (!search)
                {
                    MessageBox.Show("Your User Name or Password may be inccorect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Can not login an user without User Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RegisterUser()
        {
            Register linkRegister = new Register();
            this.Hide();
            linkRegister.ShowDialog();
            this.Show();
        }
        #endregion

        #region//This region is about Buttons 
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginUser();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            RegisterUser();
        }
        #endregion
    }
}
