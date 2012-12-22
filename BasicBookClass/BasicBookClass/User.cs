using System;

namespace BasicClass
{
    [Serializable]
    public class User
    {
        public String login;        
        String password;
        String address;
        String firstName;
        String lastName;
        float aveBooksAtOnce;
        float aveCostAtOnce;
        int booksOfAllTime;
        int costOfAllTime;

        public Book[][] history;

        public User(String login, String password, String Address, String FirstName, String LastName)
        {
            //Реазилазция от Артема
            this.login = login; //

        }
    }
}