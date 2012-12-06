using System;
using BasicClass;

namespace QueryManager
{
    public static class BookExtension
    {
        /// <summary>
        /// Проверяет удовлетворяет ли данная книга, некоторой маске
        /// </summary>
        /// <param name="mask">Маска</param>
        public static bool likeMask(this Book b, Book mask)
        {
            bool result = ((b.title == mask.title) || (mask.title == "")) &&
                        ((b.author == mask.author) || (mask.author == "")) &&
                        ((Math.Abs(b.pages - mask.pages) < 10) || (mask.pages == 0)) &&
                        ((b.price <= mask.price) || (mask.price == 0));

            //&&((b.from.name == mask.from.name) || (mask.from.name == ""));

            if (mask.tags == null) return result;

            int i, j, count = 0;
            for (i = 0; i < b.tags.Length; i++)
                for (j = 0; j < mask.tags.Length; j++)
                    if (b.tags[i] == mask.tags[j]) count++;

            result = result && (count == mask.tags.Length);

            return result;
        }
    }
}