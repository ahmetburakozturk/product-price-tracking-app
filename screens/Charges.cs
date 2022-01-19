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
    public partial class Şarjlar : Form
    {
        Database _database = new Database();
        public Şarjlar()
        {
            InitializeComponent();
        }

        private void Şarjlar_Load(object sender, EventArgs e)
        {
            LoadItems();
        }

        private void LoadItems()
        {
            dgwCharge.DataSource = _database.GetAll("Şarj Aleti", "ozturk");
        }

        private void btnDeleteCharges_Click(object sender, EventArgs e)
        {
            _database.DeleteItem(Convert.ToInt32(tbxDelChargeID.Text));
            LoadItems();
        }
    }
}
