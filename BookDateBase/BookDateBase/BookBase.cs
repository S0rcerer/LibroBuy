using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BasicClass;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace BookDateBase
{
    public class BookBase
    {
        Stream path;
        SoapFormatter deser = new SoapFormatter();

        public BookBase(string p)
        {
            path = File.OpenRead(p);
            if (!Load()) throw new ArgumentException();
        }

        [Serializable]
        public Book[] books;

        public Book this[int index]

        {
            get
            {
                return books[index];
            }

            set
            {
                books[index] = value;
            }
        }

        public bool Load()
        {
            try
            {
                books = (Book[])deser.Deserialize(path);
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
                deser.Serialize(path, books);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}