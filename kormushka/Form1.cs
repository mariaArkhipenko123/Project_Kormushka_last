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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            User user = new User();
            user.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pet pet = new Pet();
            pet.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin =new Admin();
            admin.Show(); 
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
