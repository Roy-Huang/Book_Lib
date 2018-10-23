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

namespace Book_Library
{
    public partial class Form2 : Form
    {
        string Constr = @"Persist Security Info=False;Integrated Security=true;
                     Initial Catalog=book_database;Server=.\SQLExpress";
        SqlCommand cmd;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_ISBN.Text != "" && textBox_Bookname.Text != "")
            {
                SqlConnection con = new SqlConnection(Constr);
                cmd = new SqlCommand("insert into BookList_Table(ISBN, BookName, author, publishing_house) values(@isbn, @bookname, @author, @publishing_house)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@isbn", textBox_ISBN.Text);
                cmd.Parameters.AddWithValue("@bookname", textBox_Bookname.Text);
                cmd.Parameters.AddWithValue("@author", textBox_author.Text);
                cmd.Parameters.AddWithValue("@publishing_house", textBox_publishingHouse.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                Form1 main_view = new Form1();
                this.Visible = false;
                main_view.Visible = true;
            }
            else
            {
                MessageBox.Show("Please check your info");
            }       
        }
    }
}
