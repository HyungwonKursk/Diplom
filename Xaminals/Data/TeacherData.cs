using System;
using System.Collections.Generic;
using System.Text;
using Xaminals.Models;

namespace Xaminals.Data
{
    public static class TeacherData
    {

        public static IList<Teacher> Teachers { get; set; }

        static TeacherData()
        {
            Teachers = new List<Teacher>();

            Teachers.Add(new Teacher
            {
                Login = "Log123",
                Fio = "Иванов Иван Иванович",
                Password = "123456",
                Department = "Какая-то кафедра"
            });

            Teachers.Add(new Teacher
            {
                Login = "Log456",
                Fio = "Федоров Федор Федорович",
                Password = "7890",
                Department = "Какая-то кафедра"
            });

            Teachers.Add(new Teacher
            {
                Login = "Log789",
                Fio = "Иванов Иван Иванович",
                Password = "101112",
                Department = "Какая - то кафедра"
            });
        }

        public static bool CheckLogin(Teacher teacher)
        {
            for (int i = 0; i < Teachers.Count; i++)
            {
                if (Teachers[i].Login == teacher.Login)
                    return false;
            }
            for (int i = 0; i < StudentData.Students.Count; i++)
            {
                if (StudentData.Students[i].Login == teacher.Login)
                    return false;
            }
            return true;
        }

        }
    }
