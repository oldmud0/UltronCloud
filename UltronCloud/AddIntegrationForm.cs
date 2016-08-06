using System;
using System.Windows.Forms;

namespace UltronCloud
{
    public partial class AddIntegrationForm : Form
    {
        public AddIntegrationForm()
        {
            InitializeComponent();
        }

        private void AddIntegrationForm_Load(object sender, EventArgs e)
        {
            var integs = Integrations.GetSupportedIntegrations();
            foreach (var item in integs)
                listViewIntegrations.Items.Add(new ListViewItem(item.Name));
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (listViewIntegrations.SelectedItems.Count != 1)
                MessageBox.Show(this, "Please select one integration to add.", "Add Integration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show(this, String.Format("A browser window has been opened for you to login to {0}.", listViewIntegrations.SelectedItems[0].Text));
                //TODO: add to main
                Close();
            }
        }
    }
}
