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
    public partial class Form2 : Form
    {
        public SqlConnection con;
        public Form2()
        {
            string source = @"Data Source = LAPTOP-QHBV0UP0\SQLEXPRESS01; Initial Catalog =  GHM Member Details ; Integrated Security = True;";
            con = new SqlConnection(source);
            con.Open();

            DateTime timestamp =DateTime.Now;
            String sm = timestamp.ToString();
            char[] stc = { '/', ':', ' ' };
            String[] smmani= sm.Split(stc);
            String tbf = "";
            foreach (String s in smmani)
            {
                tbf = tbf + s;
            }
           
             Console.WriteLine(tbf);
           
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gHM_Member_DetailsDataSet.MainDetails' table. You can move, or remove it, as needed.
            this.mainDetailsTableAdapter.Fill(this.gHM_Member_DetailsDataSet.MainDetails);

        }

        private void button1_Click(object sender, EventArgs e) //SUBMIT
        {
            DateTime timestamp = DateTime.Now;
            String sm = timestamp.ToString();
            char[] stc = { '/', ':', ' ' };
            String[] smmani = sm.Split(stc);
            String tbf = "";
            foreach (String s in smmani)
            {
                tbf = tbf + s;
            }

            Console.WriteLine(tbf);
            SqlCommand insertCommand = new SqlCommand("INSERT INTO MainDetails (RegistrationNumber, Name, Gender, DOB, MaritalStatus," +
                "Relation, ReligiousBackground, DateofReceivingChrist, DateofWaterBaptism, ReceivedHolySpirit, EducationalQualifications, " +
                "Profession, KnownLanguages, Talents, DateofJoiningGHM, MobileNumber1," +
                " MobileNumber2, ChurchTransportation, CareCellNumber, CallinginGod, ExperienceinServingGod, AddressCode) " +
                "VALUES (@rno,@n,@g,@dob,@marstat,@rel,@relbg,@dorc,@dowb,@rechs,@eduq,@prof,@lang,@talents,@dojghm,@mob1," +
                "@mob2,@ctrans,@ccno,@callig,@expisg, @ac)", con);


            insertCommand.Parameters.AddWithValue("@rno", tbf); //map the value to column in database
            insertCommand.Parameters.Add("@n", SqlDbType.VarChar, 255, "Name").Value = textBox2.Text;
            insertCommand.Parameters.Add("@g", SqlDbType.VarChar, 255, "Gender").Value = comboBox5.Text;
            insertCommand.Parameters.Add("@dob", SqlDbType.Date, 10, "DOB").Value = dateTimePicker1.Text;
            insertCommand.Parameters.Add("@marstat", SqlDbType.VarChar, 255, "MaritalStatus").Value = comboBox1.Text;
            insertCommand.Parameters.Add("@rel", SqlDbType.VarChar, 255, "Relation").Value = textBox3.Text;
            insertCommand.Parameters.Add("@relbg", SqlDbType.VarChar, 255, "ReligiousBackground").Value = comboBox2.Text;
            insertCommand.Parameters.Add("@dorc", SqlDbType.Date, 10, "DateofReceivingChrist").Value = dateTimePicker2.Text;
            insertCommand.Parameters.Add("@dowb", SqlDbType.Date, 10, "DateofWaterBaptism").Value = dateTimePicker3.Text;
            insertCommand.Parameters.Add("@rechs", SqlDbType.VarChar, 255, "ReceivedHolySpirit").Value = comboBox3.Text;
            insertCommand.Parameters.Add("@eduq", SqlDbType.VarChar, 255, "EducationalQualifications").Value = textBox4.Text;
            insertCommand.Parameters.Add("@prof", SqlDbType.VarChar, 255, "Profession").Value = textBox5.Text;
            insertCommand.Parameters.Add("@lang", SqlDbType.VarChar, 255, "KnownLanguages").Value = textBox6.Text;
            insertCommand.Parameters.Add("@talents", SqlDbType.VarChar, 255, "Talents").Value = textBox7.Text;
            insertCommand.Parameters.Add("@dojghm", SqlDbType.Date, 10, "DateofJoiningGHM").Value = dateTimePicker4.Text;
            insertCommand.Parameters.Add("@mob1", SqlDbType.Int, 255, "MobileNumber1").Value = int.Parse(textBox8.Text);
            insertCommand.Parameters.Add("@mob2", SqlDbType.Int, 255, "Mobile Number2").Value = int.Parse(textBox9.Text);
            insertCommand.Parameters.Add("@ctrans", SqlDbType.VarChar, 255, "ChurchTransportation").Value = comboBox4.Text;
            insertCommand.Parameters.Add("@ccno", SqlDbType.Int, 255, "CareCellNumber").Value = int.Parse(textBox10.Text);
            insertCommand.Parameters.Add("@callig", SqlDbType.VarChar, 255, "CallinginGod").Value = textBox13.Text;
            insertCommand.Parameters.Add("@expisg", SqlDbType.VarChar, 255, "ExperienceinServingGod").Value = textBox11.Text;
            insertCommand.Parameters.Add("@ac", SqlDbType.Int, 10, "AddressCode").Value = int.Parse(textBox10.Text);



            int queryResult = insertCommand.ExecuteNonQuery();
            MessageBox.Show("Added.");

            SqlDataAdapter adp = new SqlDataAdapter("SELECT * from MainDetails", con);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e) //UPDATE
        {
            textBox1.Visible = true;
            label4.Visible = true;
            
        }

        private void button3_Click(object sender, EventArgs e) //DELETE
        {
            textBox1.Visible = true;
            label4.Visible = true;

            SqlCommand deleteCommand = new SqlCommand("DELETE FROM MainDetails WHERE RegistrationNumber=@rno ", con);

            deleteCommand.Parameters.Add("@rno", SqlDbType.VarChar, 255, "RegistrationNumber").Value = textBox1.Text;
            deleteCommand.Parameters.Add("@n", SqlDbType.VarChar, 255, "Name").Value = textBox2.Text;
            deleteCommand.Parameters.Add("@g", SqlDbType.VarChar, 255, "Gender").Value = comboBox5.Text;
            deleteCommand.Parameters.Add("@dob", SqlDbType.Date, 10, "DOB").Value = dateTimePicker1.Text;
            deleteCommand.Parameters.Add("@marstat", SqlDbType.VarChar, 255, "MaritalStatus").Value = comboBox1.Text;
            deleteCommand.Parameters.Add("@rel", SqlDbType.VarChar, 255, "Relation").Value = textBox3.Text;
            deleteCommand.Parameters.Add("@relbg", SqlDbType.VarChar, 255, "ReligiousBackground").Value = comboBox2.Text;
            deleteCommand.Parameters.Add("@dorc", SqlDbType.Date, 10, "DateofReceivingChrist").Value = dateTimePicker2.Text;
            deleteCommand.Parameters.Add("@dowb", SqlDbType.Date, 10, "DateofWaterBaptism").Value = dateTimePicker3.Text;
            deleteCommand.Parameters.Add("@rechs", SqlDbType.VarChar, 255, "ReceivedHolySpirit").Value = comboBox3.Text;
            deleteCommand.Parameters.Add("@eduq", SqlDbType.VarChar, 255, "EducationalQualifications").Value = textBox4.Text;
            deleteCommand.Parameters.Add("@prof", SqlDbType.VarChar, 255, "Profession").Value = textBox5.Text;
            deleteCommand.Parameters.Add("@lang", SqlDbType.VarChar, 255, "KnownLanguages").Value = textBox6.Text;
            deleteCommand.Parameters.Add("@talents", SqlDbType.VarChar, 255, "Talents").Value = textBox7.Text;
            deleteCommand.Parameters.Add("@dojghm", SqlDbType.Date, 10, "DateofJoiningGHM").Value = dateTimePicker4.Text;
            deleteCommand.Parameters.Add("@mob1", SqlDbType.Int, 255, "MobileNumber1").Value = int.Parse(textBox8.Text);
            deleteCommand.Parameters.Add("@mob2", SqlDbType.Int, 255, "Mobile Number2").Value = int.Parse(textBox9.Text);
            deleteCommand.Parameters.Add("@ctrans", SqlDbType.VarChar, 255, "ChurchTransportation").Value = comboBox4.Text;
            deleteCommand.Parameters.Add("@ccno", SqlDbType.Int, 255, "CareCellNumber").Value = int.Parse(textBox10.Text);
            deleteCommand.Parameters.Add("@callig", SqlDbType.VarChar, 255, "CallinginGod").Value = textBox13.Text;
            deleteCommand.Parameters.Add("@expisg", SqlDbType.VarChar, 255, "ExperienceinServingGod").Value = textBox11.Text;
            deleteCommand.Parameters.Add("@ac", SqlDbType.VarChar, 255, "AddressCode").Value = textBox12.Text;


            int queryResult = deleteCommand.ExecuteNonQuery();
            //MessageBox.Show("Added.");

            SqlDataAdapter adp = new SqlDataAdapter("SELECT * from MainDetails", con);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlCommand updateCommand = new SqlCommand("UPDATE [MainDetails] SET Name=@n, Gender=@g, DOB=@dob, MaritalStatus=@marstat," +
                "Relation=@rel, ReligiousBackground=@relbg, DateofReceivingChrist=@dorc, DateofWaterBaptism=@dowb, ReceivedHolySpirit=@rechs, EducationalQualifications=@eduq, " +
                "Profession=@prof, KnownLanguages=@lang, Talents=@talents, DateofJoiningGHM=@dojghm, MobileNumber1=@mob1," +
                " MobileNumber2=@mob2, ChurchTransportation=@ctrans, CareCellNumber=@ccno, CallinginGod=@callig, ExperienceinServingGod=@expisg, AddressCode=@ac WHERE RegistrationNumber=@rno ", con);
            try
            {
                updateCommand.Parameters.AddWithValue("@rno", textBox1.Text);
                updateCommand.Parameters.AddWithValue("@n", textBox2.Text);
                updateCommand.Parameters.AddWithValue("@g", comboBox5.Text);
                updateCommand.Parameters.AddWithValue("@dob", Convert.ToDateTime(dateTimePicker1.Text));
                updateCommand.Parameters.AddWithValue("@marstat", comboBox1.Text);
                updateCommand.Parameters.AddWithValue("@rel", textBox3.Text);
                updateCommand.Parameters.AddWithValue("@relbg", comboBox2.Text);
                updateCommand.Parameters.AddWithValue("@dorc", Convert.ToDateTime(dateTimePicker2.Text));
                updateCommand.Parameters.AddWithValue("@dowb", Convert.ToDateTime(dateTimePicker3.Text));
                updateCommand.Parameters.AddWithValue("@rechs", comboBox3.Text);
                updateCommand.Parameters.AddWithValue("@eduq", textBox4.Text);
                updateCommand.Parameters.AddWithValue("@prof", textBox5.Text);
                updateCommand.Parameters.AddWithValue("@lang", textBox6.Text);
                updateCommand.Parameters.AddWithValue("@talents", textBox7.Text);
                updateCommand.Parameters.AddWithValue("@dojghm", Convert.ToDateTime(dateTimePicker4.Text));
                updateCommand.Parameters.AddWithValue("@mob1", textBox8.Text);
                updateCommand.Parameters.AddWithValue("@mob2", textBox9.Text);
                updateCommand.Parameters.AddWithValue("@ctrans", comboBox4.Text);
                updateCommand.Parameters.AddWithValue("@ccno", textBox10.Text);
                updateCommand.Parameters.AddWithValue("@callig", textBox13.Text);
                updateCommand.Parameters.AddWithValue("@expisg", textBox11.Text);
                updateCommand.Parameters.AddWithValue("@ac", textBox12.Text);


                int queryResult = updateCommand.ExecuteNonQuery();
                MessageBox.Show("Updated.");
            }
            catch (Exception exp)
            {
                MessageBox.Show("Enter valid values to update.");
                Console.WriteLine(exp.Message);
            }

            SqlDataAdapter adp = new SqlDataAdapter("SELECT * from MainDetails", con);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
