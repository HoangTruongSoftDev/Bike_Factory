/*
  Student name: Hoang Truong
  StudentID: 202130169 
 */

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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        #region//This region is about declare Fields, Essential Methods
        List<Account> listOfAccountRegister = new List<Account>();
        private void RegisterUser()
        {
            listOfAccountRegister.Clear();

            listOfAccountRegister = FileHandlerAccount.ReadFromFileAccounts();
            string currentUserName, currentPassword;
            Account currentAccount = null;
            bool checkUserName = true;
            foreach (Account checkDuplicate in listOfAccountRegister)
            {
                if (checkDuplicate.Username == this.textBoxUserNameRegister.Text)
                {
                    checkUserName = false;
                }
            }

            if (this.textBoxUserNameRegister.Text.Length > 0)
            {
                if (checkUserName)
                {
                    if (this.textBoxPasswordRegister.Text.Length > 0)
                    {

                        if (this.textBoxReenterPasswordRegister.Text == this.textBoxPasswordRegister.Text)
                        {
                            currentUserName = this.textBoxUserNameRegister.Text;
                            currentPassword = this.textBoxPasswordRegister.Text;
                            currentAccount = new Account(currentUserName, currentPassword);
                            listOfAccountRegister.Add(currentAccount);
                            FileHandlerAccount.WriteIntoFileAccounts(listOfAccountRegister);
                            MessageBox.Show($"Register Successfully\n\nThe information of your User:\n{currentAccount}", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Your Password isn't matched with the Re-enter Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Can not create an user without Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("There already exisit this User Name please choose another one", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show("Can not create an user without User Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region//This region is about Buttons
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            RegisterUser();
        }

        private void buttonBackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
