using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BasicClass;
using QueryManager;

namespace ListView
{
    public partial class ListView : UserControl
    {
        
        public Func<User, int[], int[], bool> BuyLambda;

        public List<int> BuyIndexes;
        public List<int> BuyCount;

        public ListView()
        {
            InitializeComponent();         
        }

        private void buyBookButton_Click(object sender, EventArgs e)
        {
            if (queryBookList.SelectedItems.Count != 0)
            {

                ListViewItem selectedBook = queryBookList.SelectedItems[0];
                int count = int.Parse(selectedBook.SubItems[4].Text);
                CountDialog d = new CountDialog();
                d.numericUpDown1.Maximum = count;
                if (d.ShowDialog() == DialogResult.OK)
                {
                    bool finded = false;
                    foreach (ListViewItem book in purchaseBookList.Items)
                    {
                        if (book.Text == selectedBook.Text)
                        {
                            finded = true;
                            book.SubItems[4].Text = (int.Parse(book.SubItems[4].Text) + d.numericUpDown1.Value).ToString();
                        }
                    }
                    if (!finded)
                    {
                        ListViewItem newPurchasedBook = new ListViewItem(selectedBook.Text);
                        newPurchasedBook.SubItems.Add(selectedBook.SubItems[1]);
                        newPurchasedBook.SubItems.Add(selectedBook.SubItems[2]);
                        newPurchasedBook.SubItems.Add(selectedBook.SubItems[3]);
                        newPurchasedBook.SubItems.Add(d.numericUpDown1.Value.ToString());
                        newPurchasedBook.SubItems.Add(selectedBook.SubItems[5]);

                        purchaseBookList.Items.Add(newPurchasedBook);

                        BuyIndexes.Add(int.Parse(newPurchasedBook.SubItems[5].Text.ToString()));
                        BuyCount.Add(int.Parse(newPurchasedBook.SubItems[4].Text.ToString()));
                    }
                    if (d.numericUpDown1.Value == count)
                    {
                        queryBookList.Items.Remove(selectedBook);
                    }
                    else
                    {
                        selectedBook.SubItems[4].Text = (count - d.numericUpDown1.Value).ToString();
                    }
                        
                        
                    

                }
            }
        }

        private void returnBookButton_Click(object sender, EventArgs e)
        {
            if (purchaseBookList.SelectedItems.Count != 0)
            {

                ListViewItem selectedBook = purchaseBookList.SelectedItems[0];
                int count = int.Parse(selectedBook.SubItems[4].Text);
                CountDialog d = new CountDialog();
                d.numericUpDown1.Maximum = count;
                if (d.ShowDialog() == DialogResult.OK)
                {
                    bool finded = false;
                    foreach (ListViewItem book in queryBookList.Items)
                    {
                        if (book.Text == selectedBook.Text)
                        {
                            finded = true;
                            book.SubItems[4].Text = (int.Parse(book.SubItems[4].Text) + d.numericUpDown1.Value).ToString();
                        }
                    }
                    if (!finded)
                    {
                        ListViewItem newQueryBook = new ListViewItem(selectedBook.Text);
                        newQueryBook.SubItems.Add(selectedBook.SubItems[1]);
                        newQueryBook.SubItems.Add(selectedBook.SubItems[2]);
                        newQueryBook.SubItems.Add(selectedBook.SubItems[3]);
                        newQueryBook.SubItems.Add(d.numericUpDown1.Value.ToString());
                        queryBookList.Items.Add(newQueryBook);
                    }
                    if (d.numericUpDown1.Value == count)
                    {
                        purchaseBookList.Items.Remove(selectedBook);
                        BuyIndexes.Remove(int.Parse(selectedBook.SubItems[5].Text.ToString()));
                        BuyCount.Remove(int.Parse(selectedBook.SubItems[4].Text));
                    }
                    else
                    {
                        selectedBook.SubItems[4].Text = (count - d.numericUpDown1.Value).ToString();
                        for (int i = 0; i < BuyIndexes.Count; i++)
                        {
                            if (BuyIndexes[i] == int.Parse(selectedBook.SubItems[5].Text.ToString())) BuyCount[i] = (int)(count - d.numericUpDown1.Value);
                        }
                    }




                }
            }
        }

        private void ListView_Resize(object sender, EventArgs e)
        {
            queryBookList.Width = (this.Width - 4 * 3 - 41) / 2;
            purchaseBookList.Width = (this.Width - 4 * 3 - 41) / 2;
            buyBookButton.Left = (this.Width - 41) / 2;
            label1.Left = queryBookList.Width / 2 - 40;

            label2.Left = purchaseBookList.Left + purchaseBookList.Width / 2 - 40;

            returnBookButton.Left = (this.Width - 41) / 2;
            purchaseBookList.Left = (this.Width + 41) / 2+ 3;

        }

        public void SetBookList(object sender, QueryEventArgs e)
        {
            BuyIndexes = new List<int>();
            BuyCount = new List<int>();

            Book[] books = e.Answer;
            queryBookList.Items.Clear();
            //purchaseBookList.Items.Clear();
            for (int i = 0; i < e.Answer.Length; i++)
            {
                Book book = e.Answer[i];
                ListViewItem newBook = new ListViewItem(book.title);
                newBook.SubItems.Add(book.author);
                newBook.SubItems.Add(book.from.address);
                newBook.SubItems.Add(book.from.name);
                newBook.SubItems.Add(book.copies.ToString());
                newBook.SubItems.Add(e.Indexes[i].ToString()); //  

                queryBookList.Items.Add(newBook);
            }
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
           // if (BuyIndexes.Count != 0) BuyLambda(BuyIndexes, BuyCount);
        }



    }
}
