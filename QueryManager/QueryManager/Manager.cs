using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using BasicClass;

namespace QueryManager
{
    public class Manager: IQueryManager
    {
        BookBase[] AllBase;
        public event EventHandler<QueryEventArgs> Query;       

        public Manager(String path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] fi = directory.GetFiles("*.bdb");
            AllBase = new BookBase[fi.Length];
            for (int i = 0; i < AllBase.Length; i++)
            {
                AllBase[i] = new BookBase(fi[i].ToString());
            }
        }

        public void OnQuery(Book mask)
        {
            if (AllBase==null) return;
            List<Book> Result = new List<Book>();
            foreach (BookBase bb in AllBase)
            {
                Result.AddRange(
                    from b in bb.books.books
                    where b.likeMask(mask)
                    select b
                    );
            }

            Query(this, new QueryEventArgs(Result.ToArray()));
        }
 
    }
}