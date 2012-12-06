using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BasicClass;

namespace BookDateBase
{
    public interface IBookDateBase
    {
        /// <summary>
        /// Задаёт путь к базам данных
        /// </summary>
        /// <param name="path">Путь к базам данных</param>
        void setFolder(String path);

        /// <summary>
        /// Ищет по заданному пути все базы данных книг
        /// </summary>
        void findAllBase();

        /// <summary>
        /// Возвращает из найденных баз данных все книги
        /// </summary>
        /// <returns>Массив книг из всех магазинов</returns>
        Book[] getAllBook();
    }
}
