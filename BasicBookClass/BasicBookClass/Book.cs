using System;

namespace BasicClass
{
    [Serializable]
    public struct Book
    {
        public string title;        //Название
        public string author;       //Автор
        public int copies;          //Число копий
        public int pages;           //Число страниц        
        public decimal price;       //Цена
        public string[] tags;       //Теги
        public DateTime time;
        /*
            Так как BookShopInfo класс, то он хранится указателем тем самым можно не хранить
            Избыточную информацию
         */
        public BookShopInfo from;   //Откуда книга    
    }
}