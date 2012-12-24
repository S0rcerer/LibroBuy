using System;
using BasicClass;

namespace QueryManager
{
    /// <summary>
    /// Событие ответа на запрос
    /// </summary>
    public class QueryEventArgs: EventArgs
    {
        readonly public Book[] Answer;

        readonly public int[] Indexes;
        /// <summary>
        /// Конструктор события ответа на запрос
        /// </summary>
        /// <param name="ans">Потоко небезопасная передача ответа на запрос</param>
        public QueryEventArgs(Book[] ans, int[] ids)
        {
            Answer = ans;
            Indexes = ids;
        }
    }
}