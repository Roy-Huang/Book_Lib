using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'book_databaseDataSet.BookList_Table' table. You can move, or remove it, as needed.
            this.bookList_TableTableAdapter.Fill(this.book_databaseDataSet.BookList_Table);
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            try
            {
                this.bookList_TableTableAdapter.Update(this.book_databaseDataSet.BookList_Table);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Failed");
            }
            RefreshDataset();
        }

        private void RefreshDataset()
        {
            this.bookList_TableTableAdapter.Fill(this.book_databaseDataSet.BookList_Table);
        }
    }
}
