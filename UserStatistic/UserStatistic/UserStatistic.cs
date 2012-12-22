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
        public UserStatistic(User user)
        {
            InitializeComponent();
            this.Text = user.login;
        }
    }
}
