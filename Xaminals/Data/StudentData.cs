using System;
using System.Collections.Generic;
using System.Text;
using Xaminals.Models;

namespace Xaminals.Data
{
    public class StudentData
    {
        public static IList<Student> Students { get; set; }

        static StudentData()
        {
            Students = new List<Student>();

            Students.Add(new Student
            {
                Login = "123Log",
                Fio = "Иванов Иван Иванович",
                Password = "123456",
                Type = false,
                Group = 111
            });

            Students.Add(new Student
            {
                Login = "456Log",
                Fio = "Федоров Федор Федорович",
                Type = false,
                Group = 111
            });

            Students.Add(new Student
            {
                Login = "789Log",
                Fio = "Иванов Иван Иванович",
                Type = false,
                Group = 111
            });
        }

        public static bool CheckLogin(Student student)
        {
            for (int i = 0; i < TeacherData.Teachers.Count; i++)
            {
                if (TeacherData.Teachers[i].Login == student.Login)
                    return false;
            }
            for (int i = 0; i< Students.Count;i++)
            {
                if (Students[i].Login == student.Login)
                    return false;
            }

            return true;
        }
    }
}
