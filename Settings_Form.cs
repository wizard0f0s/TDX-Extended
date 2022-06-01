﻿using System;
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
    public partial class Settings_Form : Form
    {

        private AddressBook.Selection addressBookSelection = AddressBook.Selection.sandboxServer;
        public Settings_Form()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addressBookBtn_Click(object sender, EventArgs e)
        {
            
            AddressBook book = new AddressBook(addressBookSelection);
            book.Show();
        }
    }
}
