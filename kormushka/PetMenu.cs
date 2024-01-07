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
    public partial class PetMenu : Form
    {
        public PetMenu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pet pet = new Pet();
            pet.Show();
        }

        private void PetMenu_Load(object sender, EventArgs e)
        {
            labelP.Text = DataBank.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command_i = new MySqlCommand("SELECT * FROM feeder WHERE kormushkaname = @uLi", db.getConnection());
            command_i.Parameters.AddWithValue("@uLi", labelP.Text);
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


                object name = drb.GetValue(0);
                object feed = drb.GetValue(1);
                object condition = drb.GetValue(2);
                object ligin =drb.GetValue(3);

                listBox1.Items.Add("FEEDER NAME:");
                listBox1.Items.Add(drb["kormushkaname"]);
                listBox1.Items.Add("TYPE OF FEED:");
                listBox1.Items.Add(drb["feed"]);
                listBox1.Items.Add("CONDITION:");
                listBox1.Items.Add(drb["condition"]);
                listBox1.Items.Add("OWNER:");
                listBox1.Items.Add(drb["login"]);
                listBox1.Items.Add("----------------------------");

                // listBox1.(("id:\t" + id + "\nlogin:\t" + login + "\nname:\t" + name + "\nsname:\t" + surname + "\nmail:\t" + mail + "\nage:\t" + age));
                db.closeConnection();
            }
            else
                MessageBox.Show("User not found =(");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelP.Text = DataBank.Text;
            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command_i = new MySqlCommand("SELECT * FROM feeder WHERE kormushkaname = @uLi", db.getConnection());
            command_i.Parameters.AddWithValue("@uLi", labelP.Text);
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
                label2.Text = drb["condition"].ToString();

                db.closeConnection();
            }
            int cond = 0;
            cond = int.Parse(label2.Text.ToString());
            int eat = 5;
            int res = cond - eat;
            if (res < 0)
            {
                MessageBox.Show("feeder is empty!");
                return;
                
            }
            string res_cond = res.ToString();
           
            MySqlCommand command = new MySqlCommand("UPDATE `feeder` SET `condition`= @condition WHERE `kormushkaname`=@kormushkaname", db.getConnection());

            command.Parameters.Add("@condition", MySqlDbType.VarChar).Value = res_cond;
            command.Parameters.Add("@kormushkaname", MySqlDbType.VarChar).Value = labelP.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("ok");
            else
                MessageBox.Show("No");

            db.closeConnection();
            
        }
    }
    
}
