using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;
using System.Text.Json;


namespace TDX_Extended
{
    internal partial class Settings_Form : Form
    {

        private Settings _settings;
        private Logger _myLogger;
        private int index = 0;
        private int selection;
        private bool edit = false;


        public Settings_Form(Logger logger, Settings settings)
        {
            _myLogger = logger;
            _settings = settings;
            selection = _settings.addressBook.selection;
            index = selection;

            InitializeComponent();

            friendlyNameTxtBox.Text = _settings.selectedFriendlyName;
            serverTxtBox.Text = _settings.selectedServer;
            envTxtBox.Text = _settings.selectedEnvironment;
            accountTxtBox.Text = _settings.selectedAccount;
            passwdTxtBox.Text = _settings.selectedPassword;
            webServCheckBox.Checked = _settings.selectedIsWebServices;

            friendlyNameEntryTxtBox.Text = _settings.selectedFriendlyName;
            serverEntryTxtBox.Text = _settings.selectedServer;
            envEntryTxtBox.Text = _settings.selectedEnvironment;
            accountEntryTxtBox.Text = _settings.selectedAccount;
            pwdEntryTxtBox.Text = _settings.selectedPassword;
            webServEntryCheckBox.Checked = _settings.selectedIsWebServices;

            updateIndexDisplay();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            _settings.addressBook.selection = selection;
            _settings.saveAddressBook();
            this.Close();
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            friendlyNameTxtBox.Text = friendlyNameEntryTxtBox.Text;
            serverTxtBox.Text = serverEntryTxtBox.Text;
            accountTxtBox.Text = accountEntryTxtBox.Text;
            passwdTxtBox.Text = pwdEntryTxtBox.Text;
            envTxtBox.Text = envEntryTxtBox.Text;
            webServCheckBox.Checked = webServEntryCheckBox.Checked;

            _settings.addressBook.selection = index;
            selection = index;
            _settings.selectedFriendlyName = _settings.addressBook.addresses[index].friendlyName;
            _settings.selectedServer = _settings.addressBook.addresses[index].serverAddress;
            _settings.selectedEnvironment = _settings.addressBook.addresses[index].environment;
            _settings.selectedAccount = _settings.addressBook.addresses[index].account;
            _settings.selectedPassword = _settings.addressBook.addresses[index].password;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            entrySaveBtn.Enabled = true;
            entryCancelBtn.Enabled = true;
            addBtn.Enabled = false;
            selectBtn.Enabled = false;
            editBtn.Enabled = false;
            leftBtn.Enabled = false;
            rightBtn.Enabled = false;
            friendlyNameEntryTxtBox.ReadOnly = false;
            serverEntryTxtBox.ReadOnly = false;
            accountEntryTxtBox.ReadOnly = false;
            pwdEntryTxtBox.ReadOnly = false;
            envEntryTxtBox.ReadOnly = false;
            edit = true;
            webServEntryCheckBox.Enabled = true;
            testConnectionBtn.Enabled = false;
        }

        private void entrySaveBtn_Click(object sender, EventArgs e)
        {
            entrySaveBtn.Enabled = false;
            entryCancelBtn.Enabled = false;
            addBtn.Enabled = true;
            selectBtn.Enabled = true;
            editBtn.Enabled = true;
            leftBtn.Enabled = true;
            rightBtn.Enabled = true;
            friendlyNameEntryTxtBox.ReadOnly = true;
            serverEntryTxtBox.ReadOnly = true;
            accountEntryTxtBox.ReadOnly = true;
            pwdEntryTxtBox.ReadOnly = true;
            envEntryTxtBox.ReadOnly = true;
            webServEntryCheckBox.Enabled = false;
            testConnectionBtn.Enabled = true;

            if (edit)
            {
                _settings.addressBook.addresses[index].friendlyName = friendlyNameEntryTxtBox.Text;
                _settings.addressBook.addresses[index].serverAddress = serverEntryTxtBox.Text;
                _settings.addressBook.addresses[index].environment = envEntryTxtBox.Text;
                _settings.addressBook.addresses[index].account = accountEntryTxtBox.Text;
                _settings.addressBook.addresses[index].password = pwdEntryTxtBox.Text;
                _settings.addressBook.addresses[index].isWebServices = webServEntryCheckBox.Checked;

                if (index == selection)
                {
                    friendlyNameTxtBox.Text = friendlyNameEntryTxtBox.Text;
                    serverTxtBox.Text = serverEntryTxtBox.Text;
                    accountTxtBox.Text = accountEntryTxtBox.Text;
                    passwdTxtBox.Text = pwdEntryTxtBox.Text;
                    envTxtBox.Text = envEntryTxtBox.Text;
                    webServCheckBox.Checked = webServEntryCheckBox.Checked;
                }
            }
            else
            {
                if (_settings.addressBook.addresses == null)
                    _settings.addressBook.addresses = new List<AddressEntry>();
                _settings.addressBook.addresses.Add(new AddressEntry()
                {
                    friendlyName = friendlyNameEntryTxtBox.Text,
                    serverAddress = serverEntryTxtBox.Text,
                    environment = envEntryTxtBox.Text,
                    account = accountEntryTxtBox.Text,
                    password = pwdEntryTxtBox.Text,
                    isWebServices = webServEntryCheckBox.Checked
                });
            }

            updateIndexDisplay();
            edit = false;
        }

        private void entryCancelBtn_Click(object sender, EventArgs e)
        {
            entrySaveBtn.Enabled = false;
            entryCancelBtn.Enabled = false;
            addBtn.Enabled = true;
            selectBtn.Enabled = true;
            editBtn.Enabled = true;
            leftBtn.Enabled = true;
            rightBtn.Enabled = true;
            friendlyNameEntryTxtBox.ReadOnly = true;
            serverEntryTxtBox.ReadOnly = true;
            accountEntryTxtBox.ReadOnly = true;
            pwdEntryTxtBox.ReadOnly = true;
            envEntryTxtBox.ReadOnly = true;
            webServEntryCheckBox.Enabled = false;
            testConnectionBtn.Enabled = true;

            friendlyNameEntryTxtBox.Text = _settings.addressBook.addresses[index].friendlyName;
            serverEntryTxtBox.Text = _settings.addressBook.addresses[index].serverAddress;
            accountEntryTxtBox.Text = _settings.addressBook.addresses[index].account;
            pwdEntryTxtBox.Text = _settings.addressBook.addresses[index].password;
            envEntryTxtBox.Text = _settings.addressBook.addresses[index].environment;
            webServEntryCheckBox.Checked = _settings.addressBook.addresses[index].isWebServices;

        }

        private void leftBtn_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                friendlyNameEntryTxtBox.Text = _settings.addressBook.addresses[index].friendlyName;
                serverEntryTxtBox.Text = _settings.addressBook.addresses[index].serverAddress;
                accountEntryTxtBox.Text = _settings.addressBook.addresses[index].account;
                pwdEntryTxtBox.Text = _settings.addressBook.addresses[index].password;
                envEntryTxtBox.Text = _settings.addressBook.addresses[index].environment;
                webServEntryCheckBox.Checked = _settings.addressBook.addresses[index].isWebServices;
            }

            updateIndexDisplay();
        }

        private void rightBtn_Click(object sender, EventArgs e)
        {
            if (index < (_settings.addressBook.addresses.Count - 1))
            {
                index++;
                friendlyNameEntryTxtBox.Text = _settings.addressBook.addresses[index].friendlyName;
                serverEntryTxtBox.Text = _settings.addressBook.addresses[index].serverAddress;
                accountEntryTxtBox.Text = _settings.addressBook.addresses[index].account;
                pwdEntryTxtBox.Text = _settings.addressBook.addresses[index].password;
                envEntryTxtBox.Text = _settings.addressBook.addresses[index].environment;
                webServEntryCheckBox.Checked = _settings.addressBook.addresses[index].isWebServices;
            }
            updateIndexDisplay();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            entrySaveBtn.Enabled = true;
            entryCancelBtn.Enabled = true;
            addBtn.Enabled = false;
            selectBtn.Enabled = false;
            editBtn.Enabled = false;
            leftBtn.Enabled = false;
            rightBtn.Enabled = false;
            friendlyNameEntryTxtBox.ReadOnly = false;
            serverEntryTxtBox.ReadOnly = false;
            accountEntryTxtBox.ReadOnly = false;
            pwdEntryTxtBox.ReadOnly = false;
            envEntryTxtBox.ReadOnly = false;
            webServEntryCheckBox.Enabled = true;

            friendlyNameEntryTxtBox.Text = "";
            serverEntryTxtBox.Text = "";
            accountEntryTxtBox.Text = "";
            pwdEntryTxtBox.Text = "";
            envEntryTxtBox.Text = "";
            webServEntryCheckBox.Checked = false;
            testConnectionBtn.Enabled = false;
        }

        private void updateIndexDisplay()
        {
            if (_settings.addressBook.addresses != null)
            {
                var max = _settings.addressBook.addresses.Count;
                counterLbl.Text = (index + 1) + " of " + max;
                if (index < (max - 1) && index > 0)
                {
                    rightBtn.Enabled = true;
                    leftBtn.Enabled = true;
                }
                else if (index == 0)
                {
                    rightBtn.Enabled = true;
                    leftBtn.Enabled = false;
                }
                else if (index == (max - 1))
                {
                    rightBtn.Enabled = false;
                    leftBtn.Enabled = true;
                }
            }
            else
            {
                counterLbl.Text = "0 of 0";
                rightBtn.Enabled = false;
                leftBtn.Enabled = false;
            }

        }

        private async void testConnectionBtn_Click(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(serverEntryTxtBox.Text);

                Task<string> getAuthToken;
                TDX_Authentication tdxAuth;

                if (webServEntryCheckBox.Checked)
                {
                    tdxAuth = new TDX_Authentication(
                        _myLogger,
                        serverEntryTxtBox.Text,
                        accountEntryTxtBox.Text,
                        pwdEntryTxtBox.Text,
                        true);
                    getAuthToken = tdxAuth.LoginAdminAsync(httpClient);
                }
                else
                {
                    tdxAuth = new TDX_Authentication(
                        _myLogger,
                        serverEntryTxtBox.Text,
                        accountEntryTxtBox.Text,
                        pwdEntryTxtBox.Text);
                    getAuthToken = tdxAuth.LoginAsync(httpClient);
                }

                var token = await getAuthToken;
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                //test the connection to confirm current user
                await tdxAuth.getUserAsync(httpClient);

                //// Pull full list of active Employees
                //var userListQuery = new TDX_People_GetUserListQuery();
                //userListQuery.setIsActive(true);
                //userListQuery.setIsEmployee(true);
                //userListQuery.setUserType(1);

                //var tdxPeople = new TDX_People();
                //TeamDynamix.Api.Users.UserListing[] tdxPeopleList = await tdxPeople.GetUserListAsync(_myLogger, httpClient, userListQuery);

                //Guid[] tdx_Guids = new Guid[tdxPeopleList.Length];

                //StringBuilder peopleSB = new StringBuilder();

                //for (int lcv = 0; lcv < tdxPeopleList.Length; lcv++)
                //{
                //    peopleSB.Append(tdxPeopleList[lcv].FullName + ": " + tdxPeopleList[lcv].UID.ToString() + "\n");
                //    tdx_Guids[lcv] = tdxPeopleList[lcv].UID;
                //}

                //_myLogger.Message();
                //MessageBox.Show(peopleSB.ToString(), "People and UIDs");

                //StringBuilder guidSB = new StringBuilder();

                //foreach (var guid in tdx_Guids)
                //{
                //    Console.WriteLine(guid);
                //    guidSB.Append(guid + "\n");
                //}

                //MessageBox.Show(guidSB.ToString(), "GUIDs Only");
            }
        }

    }
}
