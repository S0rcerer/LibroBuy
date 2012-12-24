using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BasicClass;
using UserManagerLibrary;

namespace LibroBuy
{
    public partial class LogIn : Form
    {
        Action<User> putHere;
        UserManager userManager = new UserManager();

        private LogIn()
        {
            InitializeComponent();
        }

        public LogIn(Action<User> f)
        {
            putHere = f;
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            putHere(userManager.Authentification(textBox1.Text, textBox2.Text));

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            putHere(userManager.Register(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text));

            this.Close();
        }
    }
}
