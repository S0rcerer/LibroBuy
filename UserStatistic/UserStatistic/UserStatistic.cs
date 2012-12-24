using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BasicClass;

namespace UserStatistic
{
    public partial class UserStatistic : Form
    {
        User statisticOwner;

        public UserStatistic(User user)
        {
            InitializeComponent();
            this.Text = user.login;

            statisticOwner = user;

            OutputUserProfile();
            OutputHistory();
        }

        private void OutputUserProfile()
        {
            label1.Text += statisticOwner.login;
            label2.Text += statisticOwner.address;
            label3.Text += statisticOwner.firstName + " " + statisticOwner.lastName;
        }

        private void OutputHistory()
        {
            decimal price = 0;
            int totalBooks = 0;

            if (statisticOwner.history == null) return;

            foreach (Book[] books in statisticOwner.history)
            {
                foreach (Book book in books)
                {
                    String purchase = book.time.ToShortDateString() + " куплена книга " + book.title + ": " + book.copies + "*" + book.price + "$";
                    listBox1.Items.Add(purchase);
                    price += book.copies*book.price;
                    totalBooks += book.copies;
                }
            }

            float aveBooksAtOnce = totalBooks / statisticOwner.history.Length;
            float aveCostAtOnce = (float)price / statisticOwner.history.Length;

            label4.Text += aveBooksAtOnce.ToString();
            label5.Text += aveCostAtOnce.ToString() + "$";

            label6.Text += totalBooks;
            label7.Text += price + "$";

        }



        
    }
}
