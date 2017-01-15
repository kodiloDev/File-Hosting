using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;
using System.Web.Security;

namespace FileClient
{
    public partial class SingIn : Form
    {
        public SingIn()
        {
            InitializeComponent();
        }

        private void btn_singIn_Click(object sender, EventArgs e)
        {
            if (Membership.ValidateUser(txbx_login.Text, txbx_password.Text))
            {
                MainForm mailForm = new MainForm(txbx_login.Text);
                mailForm.Text = String.Format("Пользователь: {0}", txbx_login.Text);
                mailForm.Show();
                this.Hide();
            }

            else
            {
                lbl_error.Text = "Не верные учетные данные";
            }
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            SignUp singUp = new SignUp();
            singUp.Show();
        
        }

        private void SingIn_Load(object sender, EventArgs e)
        {

        }
    }
}
