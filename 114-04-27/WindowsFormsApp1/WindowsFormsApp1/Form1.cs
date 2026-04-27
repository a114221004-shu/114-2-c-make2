using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public struct Book
        {
            public string BookName;
            public string Author;
            public DateTime PublishDate;
            public int Cost;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Book book;
            book.BookName = txtBookName.Text;
            book.Author = txtAuthor.Text;
            book.PublishDate = DTPPublishDate.Value;
            book.Cost = int.Parse(txtCost.Text);

            string msg = "";
            msg = msg + "書籍名稱" + book.BookName + "\n";
            msg = msg + "作者" + book.Author + "\n";
            msg = msg + "出版日期" + book.PublishDate.ToShortDateString() + "\n";
            msg = msg + "價格" + book.Cost;

            MessageBox.Show(msg, "struct書籍架構範例");

        }
    }
}
