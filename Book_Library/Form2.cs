using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Library
{
    public partial class Form2 : Form
    {
        //---use server connect----------
        string Constr = @"Persist Security Info=False;Integrated Security=true;
                     Initial Catalog=book_database;Server=.\SQLExpress";
        //---relative path sql-----------
        //---use offline mdf file connect-
        string localstr = @"Data Source=.\SQLEXPRESS;                        
                          Integrated Security=True;
                          AttachDbFilename=|DataDirectory|\book_database.mdf;
                          Initial Catalog=book_database;
                          User Instance=True";
        SqlCommand cmd;
        string imgPath;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_ISBN.Text != "" && textBox_Bookname.Text != "")
            {
                //---for image use---
                byte[] img = null;
                FileStream fs = new FileStream(imgPath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                //-------------------
                SqlConnection con = new SqlConnection(localstr);
                cmd = new SqlCommand("insert into BookList_Table(ISBN, BookName, author, publishing_house, image) values(@isbn, @bookname, @author, @publishing_house, @image)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@isbn", textBox_ISBN.Text);
                cmd.Parameters.AddWithValue("@bookname", textBox_Bookname.Text);
                cmd.Parameters.AddWithValue("@author", textBox_author.Text);
                cmd.Parameters.AddWithValue("@publishing_house", textBox_publishingHouse.Text);
                cmd.Parameters.AddWithValue("@image", img);
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

        //---upload img and display---
        private void button_uploadimg_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opfile = new OpenFileDialog();
                opfile.Filter = "JPG Files (*.jpg)|*.jpg|All Files(*.*)|*.*";
                opfile.Title = "select image file";
                if(opfile.ShowDialog() == DialogResult.OK)
                {
                    imgPath = opfile.FileName.ToString();
                    pictureBox_book.ImageLocation = imgPath;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //----------------------------
    }
}
