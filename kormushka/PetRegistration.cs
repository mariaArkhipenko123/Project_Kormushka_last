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
    public partial class PetRegistration : Form
    {
        public PetRegistration()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PetManagment petManagment = new PetManagment();
            petManagment.Show();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            if (ownerField.Text == "")
            {
                MessageBox.Show("fill in the field!");
                return;
            }
           
            if (loginFieldP.Text == "")
            {
                MessageBox.Show("fill in the field!");
                return;
            }
            if (passwordFieldP.Text == "")
            {
                MessageBox.Show("fill in the field!");
                return;
            }

            if (isPetExist())
                return;
            if (isUserExist2())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `pet` ( `login`, `password`, `owner`) VALUES (@login, @password, @owner)", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginFieldP.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passwordFieldP.Text;
            command.Parameters.Add("@owner", MySqlDbType.VarChar).Value = ownerField.Text;
           

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("ok");
            else
                MessageBox.Show("No");

            db.closeConnection();


        }
        public bool isPetExist()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `pet` WHERE `login`=@UsL", db.getConnection());
            command.Parameters.Add("@UsL", MySqlDbType.VarChar).Value = loginFieldP.Text;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("login use");
                return true;
            }
            else
                return false;

        }

        public bool isUserExist2()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `usercat` WHERE `login`=@UsL", db.getConnection());
            command.Parameters.Add("@UsL", MySqlDbType.VarChar).Value = ownerField.Text;


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
    }
    
}
