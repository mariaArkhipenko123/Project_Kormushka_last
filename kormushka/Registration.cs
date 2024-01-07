using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace kormushka
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserManagment userManagment = new UserManagment();
            userManagment.Show();
        }

        private void buttonLogAdm_Click(object sender, EventArgs e)
        {
            if (nameFieldR.Text == "")
            {
                MessageBox.Show("fill in the field!");
                return;
            }
            if (surnameFieldR.Text == "")
            {
                MessageBox.Show("fill in the field!");
                return;
            }
            if (loginFieldR.Text == "")
            {
                MessageBox.Show("fill in the field!");
                return;
            }
            if (passwordFieldR.Text == "")
            {
                MessageBox.Show("fill in the field!");
                return;
            }

            if (isUserExist())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `usercat` ( `login`, `password`, `Name`, `Surname`) VALUES (@login, @password, @name, @surname)", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginFieldR.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passwordFieldR.Text;
            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = nameFieldR.Text;
            command.Parameters.Add("@Surname", MySqlDbType.VarChar).Value = surnameFieldR.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("ok");
            else
                MessageBox.Show("No");

            db.closeConnection();


        }
        public bool isUserExist()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `usercat` WHERE `login`=@UsL", db.getConnection());
            command.Parameters.Add("@UsL", MySqlDbType.VarChar).Value = loginFieldR.Text;
           
            
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

        private void surnameFieldR_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginFieldR_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
