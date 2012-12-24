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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookSearcher
            // 
            this.bookSearcher.Location = new System.Drawing.Point(13, 14);
            this.bookSearcher.Margin = new System.Windows.Forms.Padding(5);
            this.bookSearcher.Name = "bookSearcher";
            this.bookSearcher.Size = new System.Drawing.Size(432, 502);
            this.bookSearcher.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(433, 63);
            this.listView1.Margin = new System.Windows.Forms.Padding(5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(556, 453);
            this.listView1.TabIndex = 1;
            this.listView1.Load += new System.EventHandler(this.listView1_Load);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(885, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Статистика";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 530);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.bookSearcher);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.Text = "LibroBuy";
            this.ResumeLayout(false);

        }

        #endregion

        private BookSearchTerminal.BookSearcher bookSearcher;
        private ListView.ListView listView1;
        private System.Windows.Forms.Button button1;
    }
}

