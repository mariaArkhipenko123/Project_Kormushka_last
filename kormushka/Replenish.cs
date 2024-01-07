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
    public partial class Replenish : Form
    {
        public Replenish()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxR.Text == "")
            {
                MessageBox.Show("fill in the field!");
                return;
            }
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("UPDATE `feeder` SET `condition`= @condition WHERE `login`=@login", db.getConnection());

            command.Parameters.Add("@condition", MySqlDbType.VarChar).Value = comboBoxR.Text;
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = labelR.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("ok");
            else
                MessageBox.Show("No");

            db.closeConnection();
            this.Hide();

        }

        private void Replenish_Load(object sender, EventArgs e)
        {
            labelR.Text = DataBank.Text;
            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command_i = new MySqlCommand("SELECT * FROM feeder WHERE login = @uLi", db.getConnection());
            command_i.Parameters.AddWithValue("@uLi", labelR.Text);
            MySqlDataReader drb;
            db.openConnection();
            drb = command_i.ExecuteReader();
            db.closeConnection();

            adapter.SelectCommand = command_i;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                db.openConnection();
                drb = command_i.ExecuteReader();
                drb.Read();


                
                object condition = drb.GetValue(0);



                label4.Text = drb["condition"].ToString();
               

               
                db.closeConnection();
            }
        }
    }
}
