namespace TDX_Extended
{
    public partial class Form1 : Form
    {

        Settings mySettings = new Settings();


        public Form1()
        {
            InitializeComponent();

            initialSetup();

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settingsForm = new Settings_Form(mySettings);
            settingsForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void initialSetup()
        {
            //book.linkSettings(settings);

            //switch (book.selection)
            //{
            //    case Addresses.Selection.prodServer:
            //        {
            //            //prod Server
            //            book.selectedServer = book.prodServerAddress;
            //            book.selectedEnvironment = "Production";
            //            book.selectedAccount = book.prodServerBEID;
            //            book.selectedPassword = book.prodServerKey;
            //            break;
            //        }
            //    case Addresses.Selection.prodUser:
            //        {
            //            //prod User
            //            book.selectedServer = book.prodUserAddress;
            //            book.selectedEnvironment = "Production";
            //            book.selectedAccount = book.prodUserUsername;
            //            book.selectedPassword = book.prodUserPwd;
            //            break;
            //        }
            //    case Addresses.Selection.sandboxServer:
            //        {
            //            //sandbox Server
            //            book.selectedServer = book.sandboxServerAddress;
            //            book.selectedEnvironment = "Sandbox";
            //            book.selectedAccount = book.sandboxServerBEID;
            //            book.selectedPassword = book.sandboxServerKey;
            //            break;
            //        }
            //    case Addresses.Selection.sandboxUser:
            //        {
            //            //sandbox User
            //            book.selectedServer = book.sandboxUserAddress;
            //            book.selectedEnvironment = "Production";
            //            book.selectedAccount = book.sandboxUserUsername;
            //            book.selectedPassword = book.sandboxUserPwd;
            //            break;
            //        }
            //    default:
            //        {
            //            //set the fields to null
            //            book.selectedServer = "";
            //            book.selectedEnvironment = "";
            //            book.selectedAccount = "";
            //            book.selectedPassword = "";
            //            break;
            //        }

            //}
        }
    }
}