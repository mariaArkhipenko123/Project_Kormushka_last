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
    public partial class AddFeed : Form
    {
        public AddFeed()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            if (nameFeed.Text == "")
            {
                MessageBox.Show("fill in the field!");
                return;
            }
            if (feedtype.Text == "")
            {
                MessageBox.Show("fill in the field!");
                return;
            }
            if (loginField.Text == "")
            {
                MessageBox.Show("fill in the field!");
                return;
            }
            if (condition.Text == "")
            {
                MessageBox.Show("fill in the field!");
                return;
            }

           
            if (isnameExist())
                return;
            if (isloginExist())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `feeder` ( `login`, `condition`, `kormushkaname`, `feed`) VALUES (@login, @condition, @kormushkaname, @feed)", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@condition", MySqlDbType.VarChar).Value = condition.Text;
            command.Parameters.Add("@kormushkaname", MySqlDbType.VarChar).Value = nameFeed.Text;
            command.Parameters.Add("@feed", MySqlDbType.VarChar).Value = feedtype.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("ok");
            else
                MessageBox.Show("No");

            db.closeConnection();


        }
        public bool isloginExist()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `usercat` WHERE `login`=@login", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;


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
        public bool isnameExist()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `pet` WHERE `login`=@login", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = nameFeed.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {

                return false;
            }
            else
                MessageBox.Show("name not found");
            return true;

        }
    }
    
}
