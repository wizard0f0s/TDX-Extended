using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDX_Extended
{
    internal partial class Settings_Form : Form
    {


        public Settings_Form(TDXE settings)
        {
            InitializeComponent();


            switch ((AddressBook.Selection) settings.addressBookSelection)
            {
                case AddressBook.Selection.prodServer:
                    {
                        //prod Server
                        serverTxtBox.Text = book.prodServerAddress;
                        envTxtBox.Text = "Production";
                        accountTxtBox.Text = book.prodServerBEID;
                        passwdTxtBox.Text = book.prodServerKey;
                        break;
                    }
                case AddressBook.Selection.prodUser:
                    {
                        //prod User
                        serverTxtBox.Text = book.prodUserAddress;
                        envTxtBox.Text = "Production";
                        accountTxtBox.Text = book.prodUserUsername;
                        passwdTxtBox.Text = book.prodUserPwd;
                        break;
                    }
                case AddressBook.Selection.sandboxServer:
                    {
                        //sandbox Server
                        serverTxtBox.Text = book.sandboxServerAddress;
                        envTxtBox.Text = "Sandbox";
                        accountTxtBox.Text = book.sandboxServerBEID;
                        passwdTxtBox.Text = book.sandboxServerKey;
                        break;
                    }
                case AddressBook.Selection.sandboxUser:
                    {
                        //sandbox User
                        serverTxtBox.Text = book.sandboxUserAddress;
                        envTxtBox.Text = "Production";
                        accountTxtBox.Text = book.sandboxUserUsername;
                        passwdTxtBox.Text = book.sandboxUserPwd;
                        break;
                    }
                default:
                    {
                        //set the fields to null
                        serverTxtBox.Text = "";
                        envTxtBox.Text = "";
                        accountTxtBox.Text = "";
                        passwdTxtBox.Text = "";
                        break;
                    }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addressBookBtn_Click(object sender, EventArgs e)
        {
            var book = new AddressBook(addressBookSelection);
            book.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
