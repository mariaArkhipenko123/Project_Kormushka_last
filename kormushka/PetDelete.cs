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
    public partial class PetDelete : Form
    {
        public PetDelete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isUserExist1())
                return;

            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand($"DELETE FROM pet WHERE login = @val", db.getConnection());
            cmd.Parameters.AddWithValue("@val", userDeleteLogin.Text);
            MySqlDataReader dbr;
            db.openConnection();
            dbr = cmd.ExecuteReader();
            MessageBox.Show("Updated");
            db.closeConnection();
        }
        public bool isUserExist1()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `pet` WHERE `login`=@UsL", db.getConnection());
            command.Parameters.Add("@UsL", MySqlDbType.VarChar).Value = userDeleteLogin.Text;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {

                return false;
            }
            else
                MessageBox.Show("login not found");
            return true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PetManagment petManagment = new PetManagment();
            petManagment.Show();
        }
    }
}
