using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PMS.mdf;Integrated Security=True");
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
                MessageBox.Show("Connection Established");
            }
            else
            {
                MessageBox.Show("Connection Failed");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
