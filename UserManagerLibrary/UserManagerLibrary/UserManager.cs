using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BasicClass;

namespace UserManagerLibrary
{
    public class UserManager
    {

        public Dictionary<string, User> users;
        //Так как ты не можешь сериализовать просто какой-то тип, придется создать видимый только для этого
        //Неймспейса класс с полем типа Dictionary<string, User> сериализовывать и десериализовывать его
        //И простод делать присвоения из него к твоему Dictionary<>
        //См. класс BookBase

        
        public UserManager()
        {
            users = new Dictionary<string, User>();
            //Сделать загрузку из файла тут
        }

        /// <summary>
        /// Регистрация
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <param name="name"></param>
        /// <param name="familyName"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        public User Register(string login, string password, string name, string familyName, string address)
        {
            User newUser;
            try
            {
                newUser = new User(login, password, name, familyName, address);
            }
            catch (Exception)
            {
                newUser = null;
                //throw;
            }

            return newUser;
            //В случае удачной регистрации пользователь должен быть добавлен к users и записан на диск
            //Иначе (если такой логин уже занят) вернуться null
        }

        /// <summary>
        /// Аутентификация, подробности внутри
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public User Authentification(string login, string password)
        {
            //Должен возвращаться null в случае неудачной попытки аутентификации

            User user;

            if (users.TryGetValue(login, out user))
            {
                if (user.password == password)
                {
                    return user;
                    //return true;
                }
                else
                {
                    return null;
                    //return false;
                }
            }
            else
            {
                return null;
                //return false;
            }

        }

    }
}