namespace BookSearchTerminal
{
    partial class BookSearcher
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BookTitle = new System.Windows.Forms.TextBox();
            this.BookAuthor = new System.Windows.Forms.TextBox();
            this.BookCopies = new System.Windows.Forms.TextBox();
            this.BookPages = new System.Windows.Forms.TextBox();
            this.BookPrice = new System.Windows.Forms.TextBox();
            this.BookTags = new System.Windows.Forms.TextBox();
            this.BookTitleLabel = new System.Windows.Forms.Label();
            this.BookAuthorLabel = new System.Windows.Forms.Label();
            this.BookCopiesLabel = new System.Windows.Forms.Label();
            this.BookPagesLabel = new System.Windows.Forms.Label();
            this.BookPriceLabel = new System.Windows.Forms.Label();
            this.BookTagsLabel = new System.Windows.Forms.Label();
            this.BookMainLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BookTitle
            // 
            this.BookTitle.Location = new System.Drawing.Point(129, 55);
            this.BookTitle.Name = "BookTitle";
            this.BookTitle.Size = new System.Drawing.Size(158, 20);
            this.BookTitle.TabIndex = 0;
            // 
            // BookAuthor
            // 
            this.BookAuthor.Location = new System.Drawing.Point(129, 101);
            this.BookAuthor.Name = "BookAuthor";
            this.BookAuthor.Size = new System.Drawing.Size(158, 20);
            this.BookAuthor.TabIndex = 1;
            // 
            // BookCopies
            // 
            this.BookCopies.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BookCopies.Location = new System.Drawing.Point(206, 152);
            this.BookCopies.Name = "BookCopies";
            this.BookCopies.Size = new System.Drawing.Size(81, 20);
            this.BookCopies.TabIndex = 2;
            // 
            // BookPages
            // 
            this.BookPages.Location = new System.Drawing.Point(206, 197);
            this.BookPages.Name = "BookPages";
            this.BookPages.Size = new System.Drawing.Size(81, 20);
            this.BookPages.TabIndex = 3;
            // 
            // BookPrice
            // 
            this.BookPrice.Location = new System.Drawing.Point(206, 240);
            this.BookPrice.Name = "BookPrice";
            this.BookPrice.Size = new System.Drawing.Size(81, 20);
            this.BookPrice.TabIndex = 4;
            // 
            // BookTags
            // 
            this.BookTags.Location = new System.Drawing.Point(129, 289);
            this.BookTags.Name = "BookTags";
            this.BookTags.Size = new System.Drawing.Size(158, 20);
            this.BookTags.TabIndex = 5;
            // 
            // BookTitleLabel
            // 
            this.BookTitleLabel.AutoSize = true;
            this.BookTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookTitleLabel.Location = new System.Drawing.Point(33, 55);
            this.BookTitleLabel.Name = "BookTitleLabel";
            this.BookTitleLabel.Size = new System.Drawing.Size(74, 16);
            this.BookTitleLabel.TabIndex = 6;
            this.BookTitleLabel.Text = "Название";
            // 
            // BookAuthorLabel
            // 
            this.BookAuthorLabel.AutoSize = true;
            this.BookAuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookAuthorLabel.Location = new System.Drawing.Point(33, 101);
            this.BookAuthorLabel.Name = "BookAuthorLabel";
            this.BookAuthorLabel.Size = new System.Drawing.Size(48, 16);
            this.BookAuthorLabel.TabIndex = 7;
            this.BookAuthorLabel.Text = "Автор";
            // 
            // BookCopiesLabel
            // 
            this.BookCopiesLabel.AutoSize = true;
            this.BookCopiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookCopiesLabel.Location = new System.Drawing.Point(33, 152);
            this.BookCopiesLabel.Name = "BookCopiesLabel";
            this.BookCopiesLabel.Size = new System.Drawing.Size(128, 16);
            this.BookCopiesLabel.TabIndex = 8;
            this.BookCopiesLabel.Text = "Количество копий";
            // 
            // BookPagesLabel
            // 
            this.BookPagesLabel.AutoSize = true;
            this.BookPagesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookPagesLabel.Location = new System.Drawing.Point(33, 197);
            this.BookPagesLabel.Name = "BookPagesLabel";
            this.BookPagesLabel.Size = new System.Drawing.Size(143, 16);
            this.BookPagesLabel.TabIndex = 9;
            this.BookPagesLabel.Text = "Количество страниц";
            // 
            // BookPriceLabel
            // 
            this.BookPriceLabel.AutoSize = true;
            this.BookPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookPriceLabel.Location = new System.Drawing.Point(33, 240);
            this.BookPriceLabel.Name = "BookPriceLabel";
            this.BookPriceLabel.Size = new System.Drawing.Size(41, 16);
            this.BookPriceLabel.TabIndex = 10;
            this.BookPriceLabel.Text = "Цена";
            // 
            // BookTagsLabel
            // 
            this.BookTagsLabel.AutoSize = true;
            this.BookTagsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookTagsLabel.Location = new System.Drawing.Point(33, 289);
            this.BookTagsLabel.Name = "BookTagsLabel";
            this.BookTagsLabel.Size = new System.Drawing.Size(39, 16);
            this.BookTagsLabel.TabIndex = 11;
            this.BookTagsLabel.Text = "Теги";
            // 
            // BookMainLabel
            // 
            this.BookMainLabel.AutoSize = true;
            this.BookMainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookMainLabel.Location = new System.Drawing.Point(92, 17);
            this.BookMainLabel.Name = "BookMainLabel";
            this.BookMainLabel.Size = new System.Drawing.Size(122, 24);
            this.BookMainLabel.TabIndex = 12;
            this.BookMainLabel.Text = "Поиск Книг";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(187, 345);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(100, 23);
            this.SearchButton.TabIndex = 13;
            this.SearchButton.Text = "Начать поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // BookSearcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.BookMainLabel);
            this.Controls.Add(this.BookTagsLabel);
            this.Controls.Add(this.BookPriceLabel);
            this.Controls.Add(this.BookPagesLabel);
            this.Controls.Add(this.BookCopiesLabel);
            this.Controls.Add(this.BookAuthorLabel);
            this.Controls.Add(this.BookTitleLabel);
            this.Controls.Add(this.BookTags);
            this.Controls.Add(this.BookPrice);
            this.Controls.Add(this.BookPages);
            this.Controls.Add(this.BookCopies);
            this.Controls.Add(this.BookAuthor);
            this.Controls.Add(this.BookTitle);
            this.Name = "BookSearcher";
            this.Size = new System.Drawing.Size(324, 408);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BookTitle;
        private System.Windows.Forms.TextBox BookAuthor;
        private System.Windows.Forms.TextBox BookCopies;
        private System.Windows.Forms.TextBox BookPages;
        private System.Windows.Forms.TextBox BookPrice;
        private System.Windows.Forms.TextBox BookTags;
        private System.Windows.Forms.Label BookTitleLabel;
        private System.Windows.Forms.Label BookAuthorLabel;
        private System.Windows.Forms.Label BookCopiesLabel;
        private System.Windows.Forms.Label BookPagesLabel;
        private System.Windows.Forms.Label BookPriceLabel;
        private System.Windows.Forms.Label BookTagsLabel;
        private System.Windows.Forms.Label BookMainLabel;
        private System.Windows.Forms.Button SearchButton;
    }
}
