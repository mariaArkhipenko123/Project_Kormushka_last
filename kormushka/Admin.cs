using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace kormushka
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            this.passwordField.AutoSize = false;
            this.passwordField.Size = new Size(this.passwordField.Size.Width,33);

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void buttonLogAdm_Click(object sender, EventArgs e)
        {
            String AdmLogin = loginField.Text;
            String AdmPassword = passwordField.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`=@AdL AND `password`=@AdP", db.getConnection());
            command.Parameters.Add("@AdL",MySqlDbType.VarChar).Value = AdmLogin;
            command.Parameters.Add("@AdP", MySqlDbType.VarChar).Value = AdmPassword;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                AdminMenu adminMenu = new AdminMenu();
                adminMenu.Show();
            }
            else
                MessageBox.Show("No");
        }
    }
}
