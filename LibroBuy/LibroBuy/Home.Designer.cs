namespace LibroBuy
{
    partial class Home
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.bookSearcher = new BookSearchTerminal.BookSearcher();
            this.listView1 = new ListView.ListView();
            this.SuspendLayout();
            // 
            // bookSearcher
            // 
            this.bookSearcher.Location = new System.Drawing.Point(10, 11);
            this.bookSearcher.Name = "bookSearcher";
            this.bookSearcher.Size = new System.Drawing.Size(324, 408);
            this.bookSearcher.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(325, 51);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(417, 368);
            this.listView1.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 431);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.bookSearcher);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.Text = "LibroBuy";
            this.ResumeLayout(false);

        }

        #endregion

        private BookSearchTerminal.BookSearcher bookSearcher;
        private ListView.ListView listView1;
    }
}

