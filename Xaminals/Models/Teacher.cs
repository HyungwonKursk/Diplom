using System;
using System.Collections.Generic;
using System.Text;

namespace Xaminals.Models
{
    /// <summary>
    /// Преподаватель
    /// </summary>
    class Teacher
    {
        private int id;
        public int Id { get => id; set => id = value; }

        private string firstName;
        public string FirstName { get => firstName; set => firstName = value; }
        private string secondName;
        public string SecondName { get => secondName; set => secondName = value; }
        private string lastName;
        public string LastName { get => lastName; set => lastName = value; }//фио

        private string position; //должность
        public string Position { get => position; set => position = value; }

        private string title; //звание
        public string Title { get => title; set => title = value; }

        private string department; //кафедра
        public string Department { get => department; set => department = value; }

        public Teacher(int _id,string _firstName, string _secondName, 
            string _lastName, string _position,string _title,string _department)
        {
            id = _id;
            firstName = _firstName;
            secondName = _secondName;
            lastName = _lastName;
            position = _position;
            title = _title;
            department = _department;

        }
        public Teacher()
        {
            id = 0;
            firstName = "";
            secondName = "";
            lastName = "";
            position = "";
            title = "";
            department = "";
        }

        public Teacher(Teacher teacher)
        {
            id = teacher.id;
            firstName = teacher.firstName;
            secondName = teacher.secondName;
            lastName = teacher.lastName;
            position = teacher.position;
            title = teacher.title;
            department = teacher.department;
        }
    }
}
