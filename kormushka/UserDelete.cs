using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace kormushka
{
    public partial class UserDelete : Form
    {
        public UserDelete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isUserExist1())
                return;

            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand($"DELETE FROM usercat WHERE login = @val", db.getConnection());
            cmd.Parameters.AddWithValue("@val", userDeleteLogin.Text);
            MySqlDataReader dbr;
            db.openConnection();
            dbr = cmd.ExecuteReader();
            MessageBox.Show("Updated");
            db.closeConnection();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserManagment userManagment = new UserManagment();
            userManagment.Show();
        }
        public bool isUserExist1()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `usercat` WHERE `login`=@UsL", db.getConnection());
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
    }
}
