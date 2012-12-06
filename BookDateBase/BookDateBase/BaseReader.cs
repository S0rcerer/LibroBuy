using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BasicClass;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace BookDateBase
{
    public class BaseReader : IBookDateBase
    {
        DirectoryInfo directory;
        BookBase[] AllBase;

        public void setFolder(String path)
        {
            directory = new DirectoryInfo(path);
        }

        public void findAllBase()
        {
            FileInfo[] fi = directory.GetFiles("*.bdb");
            AllBase = new BookBase[fi.Length];
            for (int i = 0; i < AllBase.Length; i++)
            {
                AllBase[i] = new BookBase();
                AllBase[i].path = fi[i].ToString();
            }
        }

        public Book[] getAllBook()
        {
            SoapFormatter deserializer = new SoapFormatter();
            Stream s;
            String path;

            path = AllBase[0].path;
            s = File.OpenRead(path);
            AllBase[0] = (BookBase)deserializer.Deserialize(s);
            s.Close();
            AllBase[0].path = path;
            Book[] ans = AllBase[0].books;

            for (int i = 1; i < AllBase.Length; i++)
            {
                path = AllBase[i].path;
                s = File.OpenRead(path);
                AllBase[i] = (BookBase)deserializer.Deserialize(s);
                s.Close();
                AllBase[i].path = path;
                ans.CopyTo(AllBase[i].books, ans.Length);
            }
            return ans;
        }
    }
}