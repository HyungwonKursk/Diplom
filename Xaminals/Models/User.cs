using System;
using System.Collections.Generic;
using System.Text;

namespace Xaminals.Models
{
    public class User
    {
        public static User CurrentUser { get; private set; } // текущий пользователь системы (singleton)
        public int Id { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }

        #region Constructors
        
        private User(int id, string Name, string login) 
        {
            this.Id = id;
            this.Name = Name;
            this.Login = login;
        }

        public static User setUser(User user)
        {
            CurrentUser = user;
            return CurrentUser;
        }

        public static User setUser(int id, string name, string login)
        {
            CurrentUser = new User(id, name, login);
            return CurrentUser;
        }
        #endregion
    }
}
