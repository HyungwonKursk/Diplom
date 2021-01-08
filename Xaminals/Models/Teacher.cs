﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Xaminals.Models
{
    /// <summary>
    /// Преподаватель
    /// </summary>
    public class Teacher
    {
        //public int Id { get; set; }
        public string Login { get; set; }
        public string Fio { get; set; }
        public string Password { get; set; }
        public string Department { get; set; }

        public Teacher( string _fio, string _password,string _login,string _department)
        {
            Fio = _fio;
            Password = _password;
            Login = _login;
            Department = _department;

        }
        public Teacher()
        {
            Fio = "";
            Password = "";
            Login = "";
            Department = "";
        }

    }
}
