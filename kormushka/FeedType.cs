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
    public partial class FeedType : Form
    {
        public FeedType()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxFeedT.Text == "")
            {
                MessageBox.Show("fill in the field!");
                return;
            }
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("UPDATE `feeder` SET feed = @feed WHERE login = @login", db.getConnection());

            command.Parameters.Add("@feed", MySqlDbType.VarChar).Value = comboBoxFeedT.Text;
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = labelU2.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("ok");
            else
                MessageBox.Show("No");

            db.closeConnection();
            this.Hide();

        }

        private void FeedType_Load(object sender, EventArgs e)
        {
            labelU2.Text = DataBank.Text;
        }

        private void labelU2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxFeedT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
