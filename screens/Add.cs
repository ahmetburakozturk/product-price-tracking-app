using System.Windows.Forms;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace UITry
{
    public partial class Ekleme : Form
    {
        Database _database = new Database();
        public Ekleme()
        {
            InitializeComponent();
        }

        private void Ekleme_Load(object sender, System.EventArgs e)
        {

        }

        private void cbxCategory_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, System.EventArgs e)
        {
            string category = "";
            if (cbxCategory.SelectedIndex==0)
            {
                category = "Şarj Aleti";
            }
            else if (cbxCategory.SelectedIndex == 1)
            {
                category = "Batarya";
            }
            else if (cbxCategory.SelectedIndex == 2)
            {
                category = "Kılıf";
            }
            else if (cbxCategory.SelectedIndex == 3)
            {
                category = "Kırılmaz";
            }
            else if (cbxCategory.SelectedIndex == 4)
            {
                category = "Kulaklık";
            }
            else if (cbxCategory.SelectedIndex == 5)
            {
                category = "Aksesuar";
            }
            int id = this._database.GetUserID();            
            _database.AddItem(new Item
            {
                Urun = tbxItemName.Text,
                Marka = tbxBrand.Text,
                Kategori=category,
                Alis= Convert.ToDecimal(tbxPrıceIn.Text),
                Satis = Convert.ToDecimal(tbxPrıceOut.Text),
                ID=Convert.ToInt32(id)
            });
            MessageBox.Show("Item Added");
            tbxItemName.Text = "";
            tbxBrand.Text = "";
            tbxPrıceIn.Text = "";
            tbxPrıceOut.Text = "";
        }
    }
}
