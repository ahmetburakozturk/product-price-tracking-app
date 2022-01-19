using System;
using System.Windows.Forms;

namespace UITry
{
    public partial class Bataryalar : Form
    {
        Database _database = new Database();
        public Bataryalar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Bataryalar_Load(object sender, EventArgs e)
        {
            LoadItems();
        }

        private void LoadItems()
        {
            dgwBatterys.DataSource = _database.GetAll("Batarya", "ozturk");
        }

        private void btnDeleteBatterys_Click(object sender, EventArgs e)
        {
            _database.DeleteItem(Convert.ToInt32(tbxDelBatteryID.Text));
            LoadItems();
        }
    }
}
