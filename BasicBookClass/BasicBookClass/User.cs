using System;

namespace BasicClass
{
    [Serializable]
    class User
    {
        String login;        
        String password;
        String address;
        String firstName;
        String lastName;
        float aveBooksAtOnce;
        float aveCostAtOnce;
        int booksOfAllTime;
        int costOfAllTime;

        Book[][] history;

        User(String login, String password, String Address, String FirstName, String LastName)
        {
            //Реазилазция от Артема
        }
    }
}