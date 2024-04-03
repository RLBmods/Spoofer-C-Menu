using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform
{
    public partial class SpooferForm : Form
    {
        public SpooferForm()
        {
            InitializeComponent();
        }

        private void SpooferForm_Load(object sender, EventArgs e)
        {
            base.TopMost = true;
            FormShadow.SetShadowForm(this);
        }

        private void DashboardPageButton_Click(object sender, EventArgs e)
        {
            DashboardTabPanel.Visible = true;
            CleanerPage.Visible = false;
            SpooferTabPanel.Visible = false;
        }

        private void SpooferPageButton_Click(object sender, EventArgs e)
        {
            SpooferTabPanel.Visible = true;
            DashboardTabPanel.Visible = false; 
            CleanerPage.Visible = false;
        }

        private void CleanerPageButton_Click(object sender, EventArgs e)
        {
            CleanerPage.Visible = true;
            DashboardTabPanel.Visible = false;
            SpooferTabPanel.Visible = false;
        }
    }
}
