using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace editor
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-BC1Q6PE\tihana;Initial Catalog=diplomski1;User ID=sa");
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from user1 where username = '" + txtUsername.Text + "' and password '" + txtPassword.Text + "'", cn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            int count = 0;
            while (dr.Read())
            {
                count += 1;
            }
            if (count == 1)
            {
                MessageBox.Show("OK");
                Naslovna naa = new Naslovna();
                naa.Show();
            }
            else if (count > 0)
            {
                MessageBox.Show("Duplicirano username i password");

            }
            else
            {
                MessageBox.Show("Username i password nisu ispravni");
            }
            txtPassword.Clear();
            txtUsername.Clear();
        }
    }
}
