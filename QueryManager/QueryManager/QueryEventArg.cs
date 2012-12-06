using System;
using BasicClass;

namespace QueryManager
{
    /// <summary>
    /// Событие ответа на запрос
    /// </summary>
    public class QueryEventArgs: EventArgs
    {
        private Book[] answer;
        
        /// <summary>
        /// Конструктор события ответа на запрос
        /// </summary>
        /// <param name="ans">Потоко небезопасная передача ответа на запрос</param>
        public QueryEventArgs(Book[] ans)
        {
            answer = ans;
        }

        public Book[] Answer
        {
            get { return answer; }
        }
    }
}