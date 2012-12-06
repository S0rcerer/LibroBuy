using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BookSearchTerminal;
using ListView;
using QueryManager;
using BasicClass;

namespace LibroBuy
{
    public partial class Home : Form
    {
        Manager manager;
        public Home()
        {
            (new LogIn()).ShowDialog();
            InitializeComponent();
            //Book[] bs = new Book[1];
            //bs[0].author = "Няша";
            //bs[0].title = "Как выбрать имя для вашей книги";
            //bs[0].copies = 100;
            //bs[0].pages = 10;
            //bs[0].price = 2.56M;
            //bs[0].tags = new string[] { "Траливали" };
            //bs[0].from = new BookShopInfo();
            //bs[0].from.address = "ул. Адресомагазинная";
            //bs[0].from.name = "Книго мир";

            //new BookBase(bs, "./pp.bdb");

            manager = new Manager(@".\");
            bookSearcher.SetQuery = manager.OnQuery;
            manager.Query += listView1.SetBookList;
        }
    }
}