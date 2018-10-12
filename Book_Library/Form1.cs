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
            // TODO: This line of code loads data into the 'book_libDataSet.book_library' table. You can move, or remove it, as needed.
            this.book_libraryTableAdapter.Fill(this.book_libDataSet.book_library);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int newRegionID = 5;     
            try
            {
                this.book_libraryTableAdapter.Update(this.book_libDataSet.book_library);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Failed");
            }
            RefreshDataset();
        }

        private void RefreshDataset()
        {
            this.book_libraryTableAdapter.Fill(this.book_libDataSet.book_library);
        }
    }
}
