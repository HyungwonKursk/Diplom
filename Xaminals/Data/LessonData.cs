using System;
using System.Collections.Generic;
using Xaminals.Models;
using System.Text;

namespace Xaminals.Data
{
    public static class LessonData
    {
        //временно используется сторонний класс за неимением базы данных
        public static IList<Animal> Lessons { get; private set; }
        static LessonData()
        {
            Lessons = new List<Animal>();

            Lessons.Add(new Animal
            {
                Name = "Вычислительная математика",
                Location = "Селиванова Ирина Васильевна",
                Details = "Практика",
                ImageUrl = "14:15"
            });
            Lessons.Add(new Animal
            {
                Name = "Программирование #",
                Location = "Селиванова Ирина Васильевна",
                Details = "Лекция",
                ImageUrl = "14:15"
            });
            Lessons.Add(new Animal
            {
                Name = "sdfrgthyju",
                Location = "Селиванова Ирина Вастльевна",
                Details = "Семинар",
                ImageUrl = "14:15"
            });
            Lessons.Add(new Animal
            {
                Name = "wedrthbvcx",
                Location = "Селиванова Ирина Вастльевна",
                Details = "Математика",
                ImageUrl = "14:15"
            });
            Lessons.Add(new Animal
            {
                Name = "sdfghjkmnbv",
                Location = "Селиванова Ирина Вастльевна",
                Details = "Математика",
                ImageUrl = "14:15"
            });
        }
    }
}
