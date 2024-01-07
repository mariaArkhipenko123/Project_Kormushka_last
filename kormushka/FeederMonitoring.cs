using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kormushka
{
    public partial class FeederMonitoring : Form
    {
        public FeederMonitoring()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("select * from feeder", db.getConnection());
            MySqlDataReader dbr;
            db.openConnection();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                listBoxC.Items.Add("OWNER:");
                listBoxC.Items.Add(dbr["login"]);
                listBoxC.Items.Add("FEEDER NAME:");
                listBoxC.Items.Add(dbr["kormushkaname"]);
                listBoxC.Items.Add("TYPE OF FEED:");
                listBoxC.Items.Add(dbr["feed"]);
                listBoxC.Items.Add("CONDITION:");
                listBoxC.Items.Add(dbr["condition"]);
                listBoxC.Items.Add("--------------------------");
            }
            db.closeConnection();
        }

        private void listBoxC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBoxC.Items.Clear();
        }
    }
}
