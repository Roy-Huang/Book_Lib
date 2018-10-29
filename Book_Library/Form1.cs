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
using System.Deployment.Application;
using System.IO;

namespace Book_Library
{
    public partial class Form1 : Form
    {
  
        
        //---use server connect----------
        //string Constr = @"Persist Security Info=False;
        //                  Integrated Security=true;
        //                  Initial Catalog=book_database;
        //                  Server=.\SQLExpress";
        //---relative path sql-----------
        //---use offline mdf file connect-
        string localtest = @"Data Source=(LocalDB)\MSSQLLocalDB;
                             Initial Catalog=Book_ListDatabase;
                             AttachDbFilename=|DataDirectory|\Book_ListDatabase.mdf;
                             Integrated Security=True";

        //AttachDbFilename=" + Application.StartupPath + @"\book_database.mdf;
        //AttachDbFilename=|DataDirectory|\book_database.mdf;
        public Form1()
        {
            InitializeComponent();
         
            //for method 2--
            try
            {
                SqlConnection con2sql = new SqlConnection(localtest);
                string Sqlstr = "select * from BookList_Table";     //Inquire command           
                SqlDataAdapter da = new SqlDataAdapter(Sqlstr, con2sql); //SqlDataAdapter will be auto connect & close
                DataSet ds = new DataSet();  //Create dataset to save table
                da.Fill(ds); //SqlDataAdapter inquire result add to dataset
                this.dataGridView2.DataSource = ds.Tables[0].DefaultView; //use datagridview display dsData
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //--------------
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //for method1--
            // TODO: This line of code loads data into the 'book_databaseDataSet.BookList_Table' table. You can move, or remove it, as needed.
            this.bookList_TableTableAdapter.Fill(this.book_databaseDataSet.BookList_Table);
            //-------------
        }
        //for method1--
        private void button1_Click(object sender, EventArgs e)
        {   
            try
            {
                this.bookList_TableTableAdapter.Update(this.book_databaseDataSet.BookList_Table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            RefreshDataset();
        }
        private void RefreshDataset()
        {
            this.bookList_TableTableAdapter.Fill(this.book_databaseDataSet.BookList_Table);
        }
        //-------------

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 add_data_view = new Form2();
            this.Visible = false;

            add_data_view.Visible = true;
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            //---get selected row index number---
            int rowIndex = dataGridView2.CurrentRow.Index;
            try
            {
                //---get index number cell 0 value(type is object)---
                int selectISBN = Convert.ToInt32(dataGridView2.Rows[rowIndex].Cells[0].Value); //cells[0] is ISBN position

                SqlConnection con2sql = new SqlConnection(localtest);
                string sql_inquire_cmd = "select image From BookList_Table where ISBN in ('" + selectISBN + "')";
                con2sql.Open();
                SqlCommand cmd = new SqlCommand(sql_inquire_cmd, con2sql); //use sqlcommand ,so... need sql open before
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                byte[] img = (byte[])(reader[0]);
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
                con2sql.Close();
            }
            catch (Exception ex)
            {
                pictureBox1.Image = Image.FromFile(@"NoImage.jpg");
                MessageBox.Show(ex.Message);
            }
        }
    }
}
