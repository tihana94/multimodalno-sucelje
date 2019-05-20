using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace editor
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            What w = new What();
            w.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Naslovna na = new Naslovna();
            na.Show();
        }
    }
}
