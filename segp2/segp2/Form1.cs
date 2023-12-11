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
using System.Data.Common;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace segp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\salim\Source\Repos\life\segp2\segp2\segp3.mdf;Integrated Security=True");
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

        private void button2_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel3.Visible = false;
            panel2.Visible = false;
            panel4.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
         
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

        private void button3_Click(object sender, EventArgs e)
        {
            String username, user_password;

            username = txt_username.Text;
            user_password = txt_password.Text;

            try
            {
                String querry = "SELECT * FROM User WHERE username = '" + txt_username.Text + "' AND password = '" + txt_password.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0)
                {
                    username = txt_username.Text;
                    user_password = txt_password.Text;


                }
                else
                {
                     MessageBox.Show("Invalid Login details","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_username.Clear();
                    txt_password.Clear();

                    //to focus username
                    txt_username.Focus();
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            finally
            {
                conn.Close();
            }

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();

            txt_username.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            string username = textBox3.Text;
            string password = textBox6.Text;
            string Com_Password = textBox1.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(Com_Password))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            if (!password.Equals(Com_Password))
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }
            textBox3.Clear();
            textBox6.Clear();
            textBox1.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DBConnection dbConn = DBConnection.getInstanceOfDBConnection();
            DataSet datasetCompany = dbConn.getDataSet("select * From Product ");
            dgvCompany.DataSource = datasetCompany.Tables[0];
        }

        private void dvgLocation_Click(object sender, EventArgs e)
        {
            DBConnection dbConn = DBConnection.getInstanceOfDBConnection();
            DataSet datasetCompany = dbConn.getDataSet("select * From Location");
            dgvCompany.DataSource = datasetCompany.Tables[0];
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DBConnection dbConn = DBConnection.getInstanceOfDBConnection();
            DataSet datasetCompany = dbConn.getDataSet("select * From Review");
            dgvCompany.DataSource = datasetCompany.Tables[0];
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            string username = textBox3.Text;
            string password = textBox6.Text;
            string Com_Password = textBox1.Text;

            
            textBox3.Clear();
            textBox6.Clear();
            textBox1.Clear();
        }
    }
}
