using Siticone.UI.WinForms.Suite;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            base.TopMost = true;
            FormShadow.SetShadowForm(this);

            /*int centerX = (this.ClientSize.Width - Usernametextbox.Width) / 2;
            int centerY = (this.ClientSize.Height - Usernametextbox.Height) / 2;
            Usernametextbox.Location = new Point(centerX, centerY);
            Console.WriteLine("centerX:"+ centerX+"centerY:"+centerY);*/  
        }
    }
}
