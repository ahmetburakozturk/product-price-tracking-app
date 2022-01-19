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
    public partial class Kılıflar : Form
    {
        Database _database = new Database();
        public Kılıflar()
        {
            InitializeComponent();
        }

        private void Kılıflar_Load(object sender, EventArgs e)
        {
            LoadItems();
        }

        private void LoadItems()
        {
            dgwCover.DataSource = _database.GetAll("Kılıf", "ozturk");
        }

        private void btnDelCovers_Click(object sender, EventArgs e)
        {
            _database.DeleteItem(Convert.ToInt32(tbxDelCoverID.Text));
            LoadItems();
        }
    }
}
