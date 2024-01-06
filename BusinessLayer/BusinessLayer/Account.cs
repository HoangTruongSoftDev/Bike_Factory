using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    [Serializable] //mark the [Serializable] to be able to serealize to .bin file or .ser file or deserealize from .bin file or .ser file
    public class Account //declare class Account to create an object which has 2 attributes are username and password
    {
        private string username; //declare field username of class Account
        private string password; // declare field password of class Account

        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public Account()
        {
            this.Username = "Undefined";
            this.Password = "Undefined";
        }
        public Account(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public override string ToString()
        {
            return $"User name: {this.Username}\nPassword: {this.Password}";
        }
    }
}
