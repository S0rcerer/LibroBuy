using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BookSearchTerminal
{
    public partial class BookSearcher : UserControl
    {
        public Action<BasicClass.Book> SetQuery;
        public BookSearcher()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            BasicClass.Book FoundBooks = new BasicClass.Book();
            FoundBooks.title = BookTitle.Text;
            FoundBooks.author = BookAuthor.Text;
            if (BookCopies.Text != "") FoundBooks.copies = Convert.ToInt32(BookCopies.Text);
            else FoundBooks.copies = 0;

            if (BookPages.Text != "") FoundBooks.pages = Convert.ToInt32(BookPages.Text);
            else FoundBooks.pages = 0;

            if (BookPrice.Text != "") FoundBooks.price = Convert.ToDecimal(BookPrice.Text);
            else FoundBooks.price = 0;

            if (BookTags.Text != "")
            {
                FoundBooks.tags = new String[1];
                FoundBooks.tags[0] = BookTags.Text;
            }

            if (SetQuery!=null) SetQuery(FoundBooks);
        }
    }
}
