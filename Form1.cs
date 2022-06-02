namespace TDX_Extended
{
    public partial class Form1 : Form
    {

        private TDXE settings = new TDXE();

        public Form1()
        {
            InitializeComponent();

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settingsForm = new Settings_Form(settings);
            settingsForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}