using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BasicClass;
using UserStatistic;

namespace TestUserStatistic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            User testuser = new User("BookWorm", "123", "╔", "Book", "Worm");
            

            BookShopInfo shop = new BookShopInfo();
            shop.address = "asdasd";
            shop.name = "Bookstore";

            Book b1;
            b1.author = "author1";
            b1.copies = 2;
            b1.from = shop;
            b1.pages = 365;
            b1.price = 12;
            b1.time = new DateTime(10000000);
            b1.title= "Book 1";
            b1.tags = new String[1] { "adventure" };

            Book b2;
            b2.author = "author2";
            b2.copies = 6;
            b2.pages = 345;
            b2.price = 9;
            b2.from = shop;
            b2.time = new DateTime(20000000);
            b2.title= "Book 2";
            b2.from = shop;
            b2.tags = new String[1] { "adventure" };

            Book b3;
            b3.author = "author3";
            b3.copies = 6;
            b3.pages = 35;
            b3.price = 4;
            b3.time = new DateTime(100000000);
            b3.title= "Book 3";
            b3.from = shop;
            b3.tags = new String[1] { "adventure" };

            Book b4;
            b4.author = "author4";
            b4.copies = 6;
            b4.pages = 335;
            b4.price = 178;
            b4.time = new DateTime(25000000);
            b4.title= "Book 4";
            b4.from = shop;
            b4.tags = new String[1] { "adventure" };

            Book b5;
            b5.author = "author1";
            b5.copies = 4;
            b5.pages = 365;
            b5.price = 12;
            b5.time = new DateTime(110000000);
            b5.title= "Book 1";
            b5.from = shop;
            b5.tags = new String[1] { "adventure" };



            testuser.history = new Book[3][]
            {
                new Book[]{ b5,b4 },
                new Book[]{b1},
                new Book[]{ b2, b3}
            };

            UserStatistic.UserStatistic st = new UserStatistic.UserStatistic(testuser);
            st.Show();

        }
    }
}
