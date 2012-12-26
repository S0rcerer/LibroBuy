using System;
using System.Collections.Generic;

namespace BasicClass
{
    [Serializable]
    public class User
    {
        public String login;
        public String password;
        public String address;
        public String firstName;
        public String lastName;
        public float aveBooksAtOnce;
        public float aveCostAtOnce;
        public int booksOfAllTime;
        public int costOfAllTime;

        public List<Book[]> history;

        public User(String login, String password, String Address, String FirstName, String LastName)
        {
            this.login = login;
            this.password = password;
            this.address = Address;
            this.firstName = FirstName;
            this.lastName = LastName;
        }

        public void AddHistory(Book[] newBooks)
        {
            history.Add(newBooks);
        }
    }
}