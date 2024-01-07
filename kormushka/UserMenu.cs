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
    public partial class UserMenu : Form
    {
        //public string Txt
        //{
        //    get { return petBox.Text;  }
        //    set { petBox.Text = value; }
        //}

        public UserMenu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            User user = new User();
            user.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (isUserExist())
            //    return;

            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command_i = new MySqlCommand("SELECT * FROM feeder WHERE login = @uLi", db.getConnection());
            command_i.Parameters.AddWithValue("@uLi", labelU.Text);
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


                listBox1.Items.Add("FEEDER NAME:");
                listBox1.Items.Add(drb["kormushkaname"]);
                listBox1.Items.Add("TYPE OF FEED:");
                listBox1.Items.Add(drb["feed"]);
                listBox1.Items.Add("CONDITION:");
                listBox1.Items.Add(drb["condition"]);
                listBox1.Items.Add("----------------------------");

                // listBox1.(("id:\t" + id + "\nlogin:\t" + login + "\nname:\t" + name + "\nsname:\t" + surname + "\nmail:\t" + mail + "\nage:\t" + age));
                db.closeConnection();
            }
            else
                MessageBox.Show("User not found =(");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserMenu_Load(object sender, EventArgs e)
        {
            labelU.Text = DataBank.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            FeedType feedType = new FeedType();
            feedType.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labelU.Text = DataBank.Text;
            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command_i = new MySqlCommand("SELECT * FROM feeder WHERE login = @uLi", db.getConnection());
            command_i.Parameters.AddWithValue("@uLi", labelU.Text);
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
                int cond = 0;
                cond = Int32.Parse(label2.Text);

                if (cond==100)
                {
                    MessageBox.Show("Feeder is full!!!");
                }
                else
                {
                    Replenish replenish = new Replenish();
                    replenish.Show();
                }
               
            }
        }

        private void labelU_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
