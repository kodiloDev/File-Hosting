using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace FileClient
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btn_singIn_Click(object sender, EventArgs e)
        {
            if (txbx_passwordRep.Text != String.Empty && txbx_passwordRep.Text != String.Empty && txbx_login.Text != String.Empty)
            {
                if (txbx_password.Text == txbx_passwordRep.Text)
                {
                    MembershipUser user;
                    user = Membership.GetUser(txbx_login.Text);
                    if (user == null)
                    {
                        user = Membership.CreateUser(txbx_login.Text, txbx_password.Text);
                    }
                    else
                    {
                        lbl_error.Text = "Такой пользователь уже зарегистрирован";
                        return;
                    }
                    
                   
                    if (user.UserName != null)
                    {
                        MessageBox.Show(txbx_login.Text + " успешно создан");
                    }
                    this.Dispose();
                }
                else
                {
                    lbl_error.Text = "Пароли не совпадают";
                }
            }
            else
            {
                lbl_error.Text = "Поля не могу быть пустыми";
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
