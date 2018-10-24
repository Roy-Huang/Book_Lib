namespace Book_Library
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ISBN = new System.Windows.Forms.TextBox();
            this.textBox_Bookname = new System.Windows.Forms.TextBox();
            this.textBox_author = new System.Windows.Forms.TextBox();
            this.textBox_publishingHouse = new System.Windows.Forms.TextBox();
            this.pictureBox_book = new System.Windows.Forms.PictureBox();
            this.button_uploadimg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_book)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(47, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "*ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(47, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "*BookName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(47, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(47, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Publishing_House";
            // 
            // textBox_ISBN
            // 
            this.textBox_ISBN.Location = new System.Drawing.Point(177, 26);
            this.textBox_ISBN.Name = "textBox_ISBN";
            this.textBox_ISBN.Size = new System.Drawing.Size(291, 22);
            this.textBox_ISBN.TabIndex = 9;
            // 
            // textBox_Bookname
            // 
            this.textBox_Bookname.Location = new System.Drawing.Point(177, 80);
            this.textBox_Bookname.Name = "textBox_Bookname";
            this.textBox_Bookname.Size = new System.Drawing.Size(291, 22);
            this.textBox_Bookname.TabIndex = 10;
            // 
            // textBox_author
            // 
            this.textBox_author.Location = new System.Drawing.Point(177, 132);
            this.textBox_author.Name = "textBox_author";
            this.textBox_author.Size = new System.Drawing.Size(291, 22);
            this.textBox_author.TabIndex = 11;
            // 
            // textBox_publishingHouse
            // 
            this.textBox_publishingHouse.Location = new System.Drawing.Point(177, 190);
            this.textBox_publishingHouse.Name = "textBox_publishingHouse";
            this.textBox_publishingHouse.Size = new System.Drawing.Size(291, 22);
            this.textBox_publishingHouse.TabIndex = 12;
            // 
            // pictureBox_book
            // 
            this.pictureBox_book.Location = new System.Drawing.Point(484, 28);
            this.pictureBox_book.Name = "pictureBox_book";
            this.pictureBox_book.Size = new System.Drawing.Size(153, 183);
            this.pictureBox_book.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_book.TabIndex = 13;
            this.pictureBox_book.TabStop = false;
            // 
            // button_uploadimg
            // 
            this.button_uploadimg.Location = new System.Drawing.Point(514, 217);
            this.button_uploadimg.Name = "button_uploadimg";
            this.button_uploadimg.Size = new System.Drawing.Size(96, 23);
            this.button_uploadimg.TabIndex = 14;
            this.button_uploadimg.Text = "Upload_image";
            this.button_uploadimg.UseVisualStyleBackColor = true;
            this.button_uploadimg.Click += new System.EventHandler(this.button_uploadimg_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 326);
            this.Controls.Add(this.button_uploadimg);
            this.Controls.Add(this.pictureBox_book);
            this.Controls.Add(this.textBox_publishingHouse);
            this.Controls.Add(this.textBox_author);
            this.Controls.Add(this.textBox_Bookname);
            this.Controls.Add(this.textBox_ISBN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "ADD_DATA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_book)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_ISBN;
        private System.Windows.Forms.TextBox textBox_Bookname;
        private System.Windows.Forms.TextBox textBox_author;
        private System.Windows.Forms.TextBox textBox_publishingHouse;
        private System.Windows.Forms.PictureBox pictureBox_book;
        private System.Windows.Forms.Button button_uploadimg;
    }
}