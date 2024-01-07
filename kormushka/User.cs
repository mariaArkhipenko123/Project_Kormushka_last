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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
            this.passwordField.AutoSize = false;
            this.passwordField.Size = new Size(this.passwordField.Size.Width, 33);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void buttonLogUs_Click(object sender, EventArgs e)
        {
            String UsLogin = loginFieldUS.Text;
            String UsPassword = passwordField.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `usercat` WHERE `login`=@UsL AND `password`=@UsP", db.getConnection());
            command.Parameters.Add("@UsL", MySqlDbType.VarChar).Value = UsLogin;
            command.Parameters.Add("@UsP", MySqlDbType.VarChar).Value = UsPassword;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                DataBank.Text = loginFieldUS.Text;
                this.Hide();
                UserMenu userMenu = new UserMenu();
                userMenu.Show();
            }
            else
                MessageBox.Show("No");

            //UserMenu usMenu = new UserMenu();
            //usMenu.Txt = this.loginFieldUS.Text;

           
            

        }
       

    }
}
