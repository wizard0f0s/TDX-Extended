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
    public partial class AddressBook : Form
    {
        public AddressBook()
        {
            InitializeComponent();
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
    }
}
