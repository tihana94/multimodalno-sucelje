using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;
using System.Media;

namespace editor
{
    public partial class Naslovna : Form
    {
        

        public Naslovna()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Start();
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            else if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }
            else if(pictureBox3.Visible==true)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }
            else if(pictureBox4.Visible==true)
            {
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
            }
            else if (pictureBox5.Visible==true)
            {
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
            }
            else if (pictureBox6.Visible==true)
            {
                pictureBox6.Visible = false;
                pictureBox7.Visible = true;
            }
            else if(pictureBox7.Visible==true)
            {
                pictureBox7.Visible = false;
                pictureBox9.Visible = true;
            }
            else if (pictureBox9.Visible==true)
            {
                pictureBox9.Visible = false;
                pictureBox10.Visible = true;
            }
            else if (pictureBox10.Visible==true)
            {
                pictureBox10.Visible = false;
                pictureBox1.Visible = true;
            }
        }

        private void circularButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l1 = new Login();
            l1.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void circularButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            About a = new About();
            a.Show();

        }
    }
}
