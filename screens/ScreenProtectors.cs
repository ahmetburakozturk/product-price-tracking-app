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
    public partial class Koruyucular : Form
    {
        Database _database = new Database();
        public Koruyucular()
        {
            InitializeComponent();
        }

        private void Koruyucular_Load(object sender, EventArgs e)
        {
            LoadItems();
        }

        private void btnDelProtector_Click(object sender, EventArgs e)
        {
            _database.DeleteItem(Convert.ToInt32(tbxDelProtectorID.Text));
            LoadItems();
        }

        private void LoadItems()
        {
            dgwProtector.DataSource = _database.GetAll("Kırılmaz", "ozturk");
        }
    }
}
