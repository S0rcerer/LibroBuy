using System;

namespace BasicClass
{
    [Serializable]
    public class User
    {
        public String login;        
        String password;
        public String address;
        public String firstName;
        public String lastName;
        public float aveBooksAtOnce;
        public float aveCostAtOnce;
        public int booksOfAllTime;
        public int costOfAllTime;

        public Book[][] history;

        public User(String login, String password, String Address, String FirstName, String LastName)
        {
            //Реазилазция от Артема
            this.login = login; //
            this.address = Address;
            this.firstName = FirstName;
            this.lastName = LastName;
        }
    }
}