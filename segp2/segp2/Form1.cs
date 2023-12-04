using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace segp2
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
            panel3.Visible = true;
            panel2.Visible = false;
            panel4.Visible = false;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel3.Visible = false;
            panel2.Visible = false;
            panel4.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loaddb_Click(object sender, EventArgs e)
        {
           DBConnection dbConn = DBConnection.getInstanceOfDBConnection();
            DataSet datasetCompany =  dbConn.getDataSet("select * From Company");
            dgvCompany.DataSource = datasetCompany.Tables[0];

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
