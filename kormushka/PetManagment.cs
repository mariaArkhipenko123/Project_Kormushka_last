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
    public partial class PetManagment : Form
    {
        public PetManagment()
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
            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("select * from pet", db.getConnection());
            MySqlDataReader dbr;
            db.openConnection();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                listBoxP.Items.Add("PET NAME:");
                listBoxP.Items.Add(dbr["login"]);
                listBoxP.Items.Add("OWNER:");
                listBoxP.Items.Add(dbr["owner"]);
                listBoxP.Items.Add("--------------------");
            }
            db.closeConnection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            PetDelete petDelete = new PetDelete();
            petDelete.Show();
        }

        private void buttonLogAdm_Click(object sender, EventArgs e)
        {
            this.Hide();
            PetRegistration petRegistration = new PetRegistration();
            petRegistration.Show();
        }

        private void listBoxP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
