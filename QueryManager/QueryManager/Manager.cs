using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using BasicClass;

namespace QueryManager
{
    public class Manager
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
            List<int> Indexes = new List<int>();
            /*
            foreach (BookBase bb in AllBase)
            {
                Result.AddRange(
                    from b in bb.books.books
                    where b.likeMask(mask)
                    select b
                    );
            }
             */
            int ids = 0;
            for (int i = 0; i < AllBase.Length; i++)
            {
                for (int j = 0; j < AllBase[i].books.Length; j++)
                {
                    ids++;
                    if (AllBase[i].books[j].likeMask(mask))
                    {
                        Result.Add(AllBase[i].books[j]);
                        Indexes.Add(ids);
                    }
                }
            }

            Query(this, new QueryEventArgs(Result.ToArray(), Indexes.ToArray()));
        }

        public bool Buy(User user, int[] ids, int[] copies)
        {
            try
            {
                for (int i = 0; i < ids.Length; i++)
                {
                    int j = 0;
                    while (ids[i] > AllBase[j].books.Length)
                    {
                        ids[i] -= AllBase[j].books.Length;
                        j++;
                    }

                    if (AllBase[j].books[ids[i]].copies < copies[i])
                        return false;
                }

                List<Book> bs = new List<Book>();

                for (int i = 0; i < ids.Length; i++)
                {
                    
                    int j = 0;
                    while (ids[i] > AllBase[j].books.Length)
                    {
                        ids[i] -= AllBase[j].books.Length;
                        j++;
                    }

                    bs.Add(AllBase[j].books[ids[i]]);
                    Book b = bs.Last();
                    b.copies = copies[i];
                    b.time = DateTime.Today;
                    AllBase[j].books[ids[i]].copies -= copies[i];
                    user.AddHistory(bs.ToArray());
                }
                    
                return true;
            }

            catch
            {
                return false;
            }
        }
    }
}