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

namespace GHMForm
{
    public partial class Form1 : Form
    {

        public SqlConnection con;
        public Form1()
        {
            string source = @"Data Source = LAPTOP-QHBV0UP0\SQLEXPRESS01; Initial Catalog = GHM Member Details;  Integrated Security = True;";
            con = new SqlConnection(source);
            con.Open();
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gHM_Member_DetailsDataSet.AddressDetails' table. You can move, or remove it, as needed.
            this.addressDetailsTableAdapter.Fill(this.gHM_Member_DetailsDataSet.AddressDetails);

        }

        private void button1_Click(object sender, EventArgs e) //SUBMIT
        {
            SqlCommand insertCommand = new SqlCommand("INSERT INTO AddressDetails  ( FamilyHead, PArea, PCity, PState, PPincode, TArea, TCity, TState, TPincode) VALUES ( @fh, @pa,@pc,@ps,@pp,@ta,@tc,@ts,@tp)", con);
            insertCommand.Parameters.Add("@fh", SqlDbType.VarChar, 255, "FamilyHead").Value = textBox2.Text;
            insertCommand.Parameters.Add("@pa", SqlDbType.VarChar, 255, "PArea").Value = textBox3.Text;
            insertCommand.Parameters.Add("@pc", SqlDbType.VarChar, 255, "PCity").Value = textBox4.Text;
            insertCommand.Parameters.Add("@ps", SqlDbType.VarChar, 255, "PState").Value = textBox5.Text;
            insertCommand.Parameters.Add("@pp", SqlDbType.Int, 255, "PPincode").Value = int.Parse(textBox6.Text);
            insertCommand.Parameters.Add("@ta", SqlDbType.VarChar, 255, "TArea").Value = textBox7.Text;
            insertCommand.Parameters.Add("@tc", SqlDbType.VarChar, 255, "TCity").Value = textBox8.Text;
            insertCommand.Parameters.Add("@ts", SqlDbType.VarChar, 255, "TState").Value = textBox9.Text;
            insertCommand.Parameters.Add("@tp", SqlDbType.Int, 255, "TPincode").Value = int.Parse(textBox10.Text);
            
            int queryResult = insertCommand.ExecuteNonQuery();
            MessageBox.Show("Added.");

            SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM AddressDetails", con);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e) //goes to member details page
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e) //UPDATE
        {
            SqlCommand updateCommand = new SqlCommand("UPDATE [AddressDetails] SET FamilyHead=@fh, PArea=@pa, PCity=@pc, PState=@ps, PPincode=@pp, TArea=@ta, TCity=@tc, TState=@ts, TPincode=@tp where AddressCode=@ac", con);
            try
            {
                updateCommand.Parameters.AddWithValue("@ac", textBox1.Text);
                updateCommand.Parameters.AddWithValue("@fh", textBox2.Text);
                updateCommand.Parameters.AddWithValue("@pa", textBox3.Text);
                updateCommand.Parameters.AddWithValue("@pc", textBox4.Text);
                updateCommand.Parameters.AddWithValue("@ps", textBox5.Text);
                updateCommand.Parameters.AddWithValue("@pp", textBox6.Text);
                updateCommand.Parameters.AddWithValue("@ta", textBox7.Text);
                updateCommand.Parameters.AddWithValue("@tc", textBox8.Text);
                updateCommand.Parameters.AddWithValue("@ts", textBox9.Text);
                updateCommand.Parameters.AddWithValue("@tp", textBox10.Text);

                int queryResult = updateCommand.ExecuteNonQuery();
                MessageBox.Show("Updated.");
            }
            catch (Exception exp)
            {
                MessageBox.Show("Enter valid values to update.");
                Console.WriteLine(exp.Message);
            }

            SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM AddressDetails", con);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e) //DELETE
        {
            textBox1.Visible = true;
            label3.Visible = true;

            SqlCommand deleteCommand = new SqlCommand("DELETE FROM AddressDetails WHERE AddressCode=@ac", con);

            deleteCommand.Parameters.Add("@ac", SqlDbType.VarChar, 255, "AddressCode").Value = textBox1.Text;
            deleteCommand.Parameters.Add("@fh", SqlDbType.VarChar, 255, "FamilyHead").Value = textBox2.Text;
            deleteCommand.Parameters.Add("@pa", SqlDbType.VarChar, 255, "PArea").Value = textBox3.Text;
            deleteCommand.Parameters.Add("@pc", SqlDbType.VarChar, 255, "PCity").Value = textBox4.Text;
            deleteCommand.Parameters.Add("@ps", SqlDbType.VarChar, 255, "PState").Value = textBox5.Text;
            deleteCommand.Parameters.Add("@pp", SqlDbType.Int, 255, "PPincode").Value = int.Parse(textBox6.Text);
            deleteCommand.Parameters.Add("@ta", SqlDbType.VarChar, 255, "TArea").Value = textBox7.Text;
            deleteCommand.Parameters.Add("@tc", SqlDbType.VarChar, 255, "TCity").Value = textBox8.Text;
            deleteCommand.Parameters.Add("@ts", SqlDbType.VarChar, 255, "TState").Value = textBox9.Text;
            deleteCommand.Parameters.Add("@tp", SqlDbType.Int, 255, "TPincode").Value = int.Parse(textBox10.Text);

            int queryResult = deleteCommand.ExecuteNonQuery();
           // MessageBox.Show("Added.");

            SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM AddressDetails", con);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button6_Click(object sender, EventArgs e) //click edit to enter the address code and then change whatever is needed
        {
            textBox1.Visible = true;
            label3.Visible = true;

            
        }
    }
}
