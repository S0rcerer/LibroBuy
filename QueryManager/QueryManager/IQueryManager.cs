using System;
using BasicClass;

namespace QueryManager
{
    public interface IQueryManager
    {
        event EventHandler<QueryEventArgs> Query;

        void OnQuery(Book mask);
    }
}
