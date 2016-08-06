using System;
using System.Windows.Forms;

namespace UltronCloud
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void buttonAddIntegration_Click(object sender, EventArgs e)
        {
            new AddIntegrationForm().ShowDialog(this);
            this.Close();
        }
    }
}
