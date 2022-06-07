namespace TDX_Extended
{
    public partial class Form1 : Form
    {

        Logger _myLogger;
        Settings _mySettings;


        public Form1()
        {
            _myLogger = new Logger();
            _mySettings = new Settings(_myLogger);
            InitializeComponent();

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settingsForm = new Settings_Form(_myLogger, _mySettings);
            settingsForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}