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

namespace Book_Library
{
    public partial class Form1 : Form
    {
        //for method 2-- initial catalog is database table
        string Constr = @"Persist Security Info=False;Integrated Security=true;
                     Initial Catalog=book_database;Server=.\SQLExpress";
        //--------------


        public Form1()
        {
            InitializeComponent();

            //for method 2--
            try
            {
                SqlConnection con2sql = new SqlConnection(Constr);
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
    }
}
