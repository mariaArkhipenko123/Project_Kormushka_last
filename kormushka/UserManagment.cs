using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace kormushka
{
    public partial class UserManagment : Form
    {
        public UserManagment()
        {
            InitializeComponent();
        }

        private void buttonLogAdm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("select * from usercat", db.getConnection());
            MySqlDataReader dbr;
            db.openConnection();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                listBox1.Items.Add(dbr["login"]);
            }
            db.closeConnection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDelete userDelete = new UserDelete();
            userDelete.Show();
        }
    }
}
