using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UITry
{
    public partial class Ayarlar : Form
    {
        Database _database = new Database();
        public Ayarlar()
        {
            InitializeComponent();
        }

        private void Ayarlar_Load(object sender, EventArgs e)
        {
            btnCurrentUser.Text = Check._userNameG;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (tbxNewPassword.Text!="" && tbxNewPassword2.Text!="")
            {
                if (tbxNewPassword.Text == tbxNewPassword2.Text)
                {
                    if (tbxOldPassword.Text == Check._userPasswordG)
                    {
                        _database.ChangePassword(tbxNewPassword.Text);
                        MessageBox.Show("Şifreniz Değiştirildi!");
                        tbxNewPassword.Text = "";
                        tbxNewPassword2.Text = "";
                        tbxOldPassword.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Şifre Hatalı!");
                        tbxNewPassword.Text = "";
                        tbxNewPassword2.Text = "";
                        tbxOldPassword.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler Eşleşmiyor!");
                    tbxNewPassword.Text = "";
                    tbxNewPassword2.Text = "";
                    tbxOldPassword.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Lütfen İlgili Alnları Doldurunuz!");
                tbxNewPassword.Text = "";
                tbxNewPassword2.Text = "";
                tbxOldPassword.Text = "";
            }
            
            
        }
    }
}
