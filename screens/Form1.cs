using System;
using System.Drawing;
using System.Windows.Forms;

namespace UITry
{
    public partial class Form1 : Form
    {
        //Database tanımlama
        Database _database = new Database();
        string _user = "";
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //Constructor
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnBatterys.Enabled = false;
            btnCharges.Enabled = false;
            btnCovers.Enabled = false;
            btnHeadphones.Enabled = false;
            btnSettings.Enabled = false;
            btnScreens.Enabled = false;
            btnAdd.Enabled = false;
            btnAccessories.Enabled = false;
            tbxPassword.PasswordChar = '*';
            tbxPassword.MaxLength = 14;
            tbxUserName.MaxLength = 14;
        }


        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }

            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.ForeColor = Color.Gold;
                    currentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                    //panelTitleBar.BackColor = color;
                    //panelLogo.BackColor = color;
                    //lblLogo.ForeColor = color;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = SystemColors.ActiveCaption;
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Name;
        }

        private void btnBatterys_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Bataryalar(), sender);
        }

        private void btnCharges_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Şarjlar(), sender);
        }

        private void btnScreens_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Koruyucular(), sender);
        }

        private void btnCovers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Kılıflar(), sender);
        }

        private void btnHeadphones_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Kulaklıklar(), sender);
        }

        private void btnAccessories_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Aksesuarlar(), sender);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Ekleme(), sender);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Ayarlar(), sender);
        }

        private void btnLgn_Click(object sender, EventArgs e)
        {
            if (tbxUserName.Text!="" && tbxPassword.Text!="")
            {
                bool control = _database.GetUser(tbxUserName.Text, tbxPassword.Text);
                if (control == true)
                {
                    btnBatterys.Enabled = true;
                    btnCharges.Enabled = true;
                    btnCovers.Enabled = true;
                    btnHeadphones.Enabled = true;
                    btnSettings.Enabled = true;
                    btnScreens.Enabled = true;
                    btnAdd.Enabled = true;
                    btnAccessories.Enabled = true;
                    btnLgn.Enabled = false;
                    _user = tbxUserName.Text;
                    Check._userNameG = tbxUserName.Text;
                    Check._userPasswordG = tbxPassword.Text;
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı!");
                    tbxPassword.Text = "";
                    tbxUserName.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Lütfen Kullanıcı Adı ve Şifre Girin!");
            }
        }
    }
}
