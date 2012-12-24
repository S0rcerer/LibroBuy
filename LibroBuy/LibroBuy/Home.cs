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
using UserStatistic;
using UserManagerLibrary;

namespace LibroBuy
{
    public partial class Home : Form
    {
        Manager manager;
        User user;
        public Home()
        {
            
            (new LogIn((u) => user = u)).ShowDialog();
            if (user == null)
                MessageBox.Show("Не правильные данные");

            InitializeComponent();

            manager = new Manager(@".\");
            bookSearcher.SetQuery = manager.OnQuery;
            manager.Query += listView1.SetBookList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new UserStatistic.UserStatistic(user)).ShowDialog();
        }

        private void listView1_Load(object sender, EventArgs e)
        {

        }
    }
}