using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace BasicClass
{
    public class BookBase
    {
        public Books books;
        string path;
        SoapFormatter deser = new SoapFormatter();

        public BookBase(Book[] bs, String p)
        {
            books = new Books();
            books.books = bs;
            path = p;
            if (!Save()) throw new ArgumentException();
        }

        public BookBase(string p)
        {
            path = p;
            if (!Load()) throw new ArgumentException();
        }

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
        }

        public bool Load()
        {
            try
            {
                Stream s = File.OpenRead(path);
                books = (Books)deser.Deserialize(s);
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
                deser.Serialize(s, books);
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
