using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace BasicClass
{
    public class BookBase
    {
        //public Books books;
        public Book[] books;
        string path;
        SoapFormatter deser = new SoapFormatter();

        public BookBase(Book[] bs, String p)
        {
            //books = new Books();
            //books.books = bs;
            books = bs;
            path = p;
            if (!Save()) throw new ArgumentException();
        }

        public BookBase(string p)
        {
            path = p;
            if (!Load()) throw new ArgumentException();
        }

        /*
        public Book this[int index]
        {
            get
            {
                return books.books[index];
            }

            set
            {
                books.books[index] = value;
            }
        }*/

        public bool Load()
        {
            try
            {
                Stream s = File.OpenRead(path);
                books = ((Books)deser.Deserialize(s)).books;
                s.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Save()
        {
            try
            {
                Stream s = File.OpenWrite(path);
                Books bks = new Books();
                bks.books = books;
                deser.Serialize(s, bks);
                s.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
