using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GHMForm
{

    public partial class Form3 : Form
    {
        public SqlConnection con;
        public String columnNames = "";
        public Form3()
        {
            string source = @"Data Source = LAPTOP-QHBV0UP0\SQLEXPRESS01; Initial Catalog =  GHM Member Details ; Integrated Security = True;";
            con = new SqlConnection(source);
            con.Open();
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //shows selected columns from the tables
        {
            String TrimResult = columnNames.Trim();
            
           String finalResult = TrimResult.Replace(" ", ",");
            Console.WriteLine(finalResult);

            String viewResult = "SELECT "+finalResult+" FROM MainDetails";
            SqlDataAdapter adp = new SqlDataAdapter(viewResult, con);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            columnNames = "";
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Enabled == true) {
                columnNames = columnNames + "Name ";
            }
           
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Enabled == true) {
                columnNames = columnNames + "Gender ";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Enabled == true) {
                columnNames = columnNames + "DOB ";
            }
        }
    }
}
