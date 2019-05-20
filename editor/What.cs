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
    public partial class What : Form
    {
        public What()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Naslovna n = new Naslovna();
            n.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            About aaa = new About();
            aaa.Show();
        }
    }
}
