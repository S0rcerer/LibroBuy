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
        User user;          //Текущий пользователь

        public Home()
        {
            
            (new LogIn((u) => user = u)).ShowDialog();
            //Форма LogIn использует класс UserManager для регистрации и аутентификации пользователей.
            //Передача данных осуществляется при помощи делегата -
                //в данном случае анонимного созданного с помощью синтаксиса лямбда выражений
                //с применением замыкания.
            //Для передачи данных делегат предпочтительнее простой ссылки, так как
                //оставляет возможность реализовать потокобезопасную передачу данных,
                //либо не реализовывать её, как в данном случае.
            //Потокобезопасность могла бы потребоваться в случае вызова метода Show() вместо ShowDialog()
            
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