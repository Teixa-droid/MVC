using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroductionLayer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            initial form = new initial();

            form.Show();
            this.Hide();

            form.FormClosing += frm_closing;

        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtdocument.Text = "";
            txtpassword.Text = "";
            this.Show();
        }
    }
}
