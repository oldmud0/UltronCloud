using System;
using System.Windows.Forms;

namespace UltronCloud
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            if (Properties.Settings.Default.FirstTimeStart)
            {
                new WelcomeForm().ShowDialog(this);

                Properties.Settings.Default.FirstTimeStart = false;
                Properties.Settings.Default.Save();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addIntegrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddIntegrationForm().ShowDialog(this);
        }
    }
}
