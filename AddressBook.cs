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
    public partial class AddressBook : Form
    {

        public enum Selection
        {
            prodServer, prodUser, sandboxServer, sandboxUser
        }

        public string sandboxServerAddress { get; set; }
        public string sandboxServerBEID { get; set; }
        public string sandboxServerKey { get; set; }
        public string prodServerAddress { get; set; }
        public string prodServerBEID { get; set; }
        public string prodServerKey { get; set; }
        public string prodUserAddress { get; set; }
        public string prodUserUsername { get; set; }
        public string prodUserPwd { get; set; }
        public string sandboxUserAddress { get; set; }
        public string sandboxUserUsername { get; set; }
        public string sandboxUserPwd { get; set; }
        //public Selection selection { get; set; }


        public AddressBook(Selection defaultChoice)
        {

            InitializeComponent();

            switch (defaultChoice)
            {
                case Selection.prodServer: prodAdminBtn.Checked = true; break;
                case Selection.prodUser: prodUserBtn.Checked = true; break;
                case Selection.sandboxServer: sandboxAdminBtn.Checked = true; break;
                default: sandboxUserBtn.Checked = true; break;
            }
 

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("secrets.json", optional: false, reloadOnChange: true)
                .AddUserSecrets<AddressBook>().Build();

            sandboxServerAddress = builder.GetSection("sandboxServerAddress").Value;
            sandboxServerBEID = builder.GetSection("sandboxServerBEID").Value;
            sandboxServerKey = builder.GetSection("sandboxServerKey").Value;
            prodServerAddress = builder.GetSection("prodServerAddress").Value;
            prodServerBEID = builder.GetSection("prodServerBEID").Value;
            prodServerKey = builder.GetSection("prodServerKey").Value;
            sandboxUserAddress = builder.GetSection("sandboxUserAddress").Value;
            sandboxUserUsername = builder.GetSection("sandboxUserUsername").Value;
            sandboxUserPwd = builder.GetSection("sandboxUserPwd").Value;
            prodUserAddress = builder.GetSection("prodUserAddress").Value;
            prodUserUsername = builder.GetSection("prodUserUsername").Value;
            prodUserPwd = builder.GetSection("prodUserPwd").Value;


            sandboxServerTxtBox.Text = sandboxServerAddress;
            sandboxBeidTxtBox.Text = sandboxServerBEID;
            sandboxKeyTxtBox.Text = sandboxServerKey;
            sandboxUserServerTxtBox.Text = sandboxUserAddress;
            sandboxUserUsernameTxtBox.Text = sandboxUserUsername;
            sandboxUserPwdTxtBox.Text = sandboxUserPwd;

            prodServerTxtBox.Text = prodServerAddress;
            prodBeidTxtBox.Text = prodServerBEID;
            prodKeyTxtBox.Text = prodServerKey;
            prodUserServerTxtBox.Text = prodUserAddress;
            prodUserUsernameTxtBox.Text = prodUserUsername;
            prodUserPwdTxtBox.Text = prodUserPwd;

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
            var secretsID = "48024d93-9b5e-40b8-99a1-e75d6cf33c61";
            var secretsPath = Microsoft.Extensions.Configuration.UserSecrets.PathHelper.GetSecretsPathFromSecretsId(secretsID);
            var secretsJson = File.ReadAllText(secretsPath);
            dynamic secrets = JsonConvert.DeserializeObject<ExpandoObject>(secretsJson, new ExpandoObjectConverter());

            secrets.sandboxServerAddress = sandboxServerTxtBox.Text;
            secrets.sandboxServerBEID = sandboxBeidTxtBox.Text;
            secrets.sandboxServerKey = sandboxKeyTxtBox.Text;
            secrets.sandboxUserAddress = sandboxUserServerTxtBox.Text;
            secrets.sandboxUserUsername = sandboxUserUsernameTxtBox.Text;
            secrets.sandboxUserPwd = sandboxUserPwdTxtBox.Text;

            secrets.prodServerAddress = prodServerTxtBox.Text;
            secrets.prodServerBEID = prodBeidTxtBox.Text;
            secrets.prodServerKey = prodKeyTxtBox.Text;
            secrets.prodUserAddress = prodUserServerTxtBox.Text;
            secrets.prodUserUsername = prodUserUsernameTxtBox.Text;
            secrets.prodUserPwd = prodUserPwdTxtBox.Text;

            var updatedSecretsJson = JsonConvert.SerializeObject(secrets, Formatting.Indented);
            File.WriteAllText(secretsPath, updatedSecretsJson);
            this.Close();
        }
    }
}
