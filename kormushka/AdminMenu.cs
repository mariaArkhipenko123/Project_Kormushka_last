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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin();
            admin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserManagment userManagment = new UserManagment();
            userManagment.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Hide();
            FeederMonitoring feederMonitoring = new  FeederMonitoring();
           feederMonitoring.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddFeed addFeed = new AddFeed();
            addFeed.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            PetManagment petManagment = new PetManagment();
            petManagment.Show();
        }
    }
}
