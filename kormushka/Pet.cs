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
    public partial class Pet : Form
    {
        public Pet()
        {
            InitializeComponent();
            this.passwordField.AutoSize = false;
            this.passwordField.Size = new Size(this.passwordField.Size.Width, 33);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void buttonLogUs_Click(object sender, EventArgs e)
        {
            String PetLogin = loginField.Text;
            String PetPassword = passwordField.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `pet` WHERE `login`=@PL AND `password`=@PP", db.getConnection());
            command.Parameters.Add("@PL", MySqlDbType.VarChar).Value = PetLogin;
            command.Parameters.Add("@PP", MySqlDbType.VarChar).Value = PetPassword;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                DataBank.Text = loginField.Text;
                this.Hide();
                PetMenu petMenu = new PetMenu();
                petMenu.Show();
            }
            else
                MessageBox.Show("No");
        }

        private void Pet_Load(object sender, EventArgs e)
        {
           
        }
    }
}
