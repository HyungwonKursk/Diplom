using System;
using System.Collections.Generic;
using System.Text;

namespace Xaminals.Models
{
    public class Student
    {
        public static Student CurrentUser { get;  set; } // текущий пользователь системы (singleton)
        //public int Id { get; set; }
        public string Login { get; set; }
        public string Fio { get; set; }
        public string Password { get; set; }
        public bool Type { get; set; }
        public int Group { get; set; }

        public Student(string _fio, string _password, string _login, int _group)
        {
            Fio = _fio;
            Password = _password;
            Login = _login;
            Type = false;
            Group = _group;

        }
        public Student()
        {
            Fio = "";
            Password = "";
            Type = false;
            Login = "";
            Group = 0;
        }
    }
}
