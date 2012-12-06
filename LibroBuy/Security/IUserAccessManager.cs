using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Security
{
    public interface IUserAccessManager
    {
        bool Authentication(String login, String password);
        bool Registration(String login, String password, String Address, String FirstName, String LastName);
    }
}
