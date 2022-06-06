using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using System.Reflection;
using System.Dynamic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace TDX_Extended
{
    internal partial class AddressBook_Form : Form
    {


        private AddressEntry _book;


        public AddressBook_Form(AddressEntry book)
        {

            _book = book;

            InitializeComponent();

            //switch (_book.selection)
            //{
            //    case AddressEntry.Selection.prodServer: prodAdminBtn.Checked = true; break;
            //    case AddressEntry.Selection.prodUser: prodUserBtn.Checked = true; break;
            //    case AddressEntry.Selection.sandboxServer: sandboxAdminBtn.Checked = true; break;
            //    default: sandboxUserBtn.Checked = true; break;
            //}

            //sandboxServerTxtBox.Text = _book.sandboxServerAddress;
            //sandboxBeidTxtBox.Text = _book.sandboxServerBEID;
            //sandboxKeyTxtBox.Text = _book.sandboxServerKey;
            //sandboxUserServerTxtBox.Text = _book.sandboxUserAddress;
            //sandboxUserUsernameTxtBox.Text = _book.sandboxUserUsername;
            //sandboxUserPwdTxtBox.Text = _book.sandboxUserPwd;

            //prodServerTxtBox.Text = _book.prodServerAddress;
            //prodBeidTxtBox.Text = _book.prodServerBEID;
            //prodKeyTxtBox.Text = _book.prodServerKey;
            //prodUserServerTxtBox.Text = _book.prodUserAddress;
            //prodUserUsernameTxtBox.Text = _book.prodUserUsername;
            //prodUserPwdTxtBox.Text = _book.prodUserPwd;

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void prodAdminBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (prodAdminBtn.Checked)
            {
                prodAdminBtn.Checked = true;
                sandboxAdminBtn.Checked = false;
                prodUserBtn.Checked = false;
                sandboxUserBtn.Checked = false;
            }
        }

        private void sandboxAdminBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (sandboxAdminBtn.Checked)
            {
                prodAdminBtn.Checked = false;
                sandboxAdminBtn.Checked = true;
                prodUserBtn.Checked = false;
                sandboxUserBtn.Checked = false;
            }
        }

        private void prodUserBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (prodUserBtn.Checked)
            {
                prodAdminBtn.Checked = false;
                sandboxAdminBtn.Checked = false;
                prodUserBtn.Checked = true;
                sandboxUserBtn.Checked = false;
            }
        }

        private void sandboxUserBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (sandboxUserBtn.Checked)
            {
                prodAdminBtn.Checked = false;
                sandboxAdminBtn.Checked = false;
                prodUserBtn.Checked = false;
                sandboxUserBtn.Checked = true;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            //if (prodAdminBtn.Checked == true)
            //{
            //    _book.selection = AddressEntry.Selection.prodServer;
            //    _book.selectedServer = prodServerTxtBox.Text;
            //    _book.selectedEnvironment = "Production - Admin";
            //    _book.selectedAccount = prodBeidTxtBox.Text;
            //    _book.selectedPassword = prodKeyTxtBox.Text;
            //}
            //else if (sandboxAdminBtn.Checked == true)
            //{
            //    _book.selection = AddressEntry.Selection.sandboxServer;
            //    _book.selectedServer = sandboxServerTxtBox.Text;
            //    _book.selectedEnvironment = "Sandbox - Admin";
            //    _book.selectedAccount = sandboxBeidTxtBox.Text;
            //    _book.selectedPassword = sandboxKeyTxtBox.Text;
            //}
            //else if (prodUserBtn.Checked == true)
            //{
            //    _book.selection = AddressEntry.Selection.prodUser;
            //    _book.selectedServer = prodUserServerTxtBox.Text;
            //    _book.selectedEnvironment = "Production - User";
            //    _book.selectedAccount = prodUserUsernameTxtBox.Text;
            //    _book.selectedPassword = prodUserPwdTxtBox.Text;
            //}
            //else
            //{
            //    _book.selection = AddressEntry.Selection.sandboxUser;
            //    _book.selectedServer = sandboxUserServerTxtBox.Text;
            //    _book.selectedEnvironment = "Sandbox - User";
            //    _book.selectedAccount = sandboxUserUsernameTxtBox.Text;
            //    _book.selectedPassword = sandboxUserPwdTxtBox.Text;
            //}

            //_book.prodServerAddress = prodServerTxtBox.Text;
            //_book.prodServerBEID = prodBeidTxtBox.Text;
            //_book.prodServerKey = prodKeyTxtBox.Text;

            //_book.prodUserAddress = prodUserServerTxtBox.Text;
            //_book.prodUserUsername = prodUserUsernameTxtBox.Text;
            //_book.prodUserPwd = prodUserPwdTxtBox.Text;

            //_book.sandboxServerAddress = sandboxServerTxtBox.Text;
            //_book.sandboxServerBEID = sandboxBeidTxtBox.Text;
            //_book.sandboxServerKey = sandboxKeyTxtBox.Text;

            //_book.sandboxUserAddress = sandboxUserServerTxtBox.Text;
            //_book.sandboxUserUsername = sandboxUserUsernameTxtBox.Text;
            //_book.sandboxUserPwd = sandboxUserPwdTxtBox.Text;

            //_book.saveAddressBook();

            this.Close();
        }
    }
}
