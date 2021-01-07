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
                Name = "Понедельник",
                
            });
            Lessons.Add(new Animal
            {
                Name = "Функциональное программирование",
                Location = "Селиванова Ирина Васильевна",
                Details = "Лекция",
                ImageUrl = "8:00"
            });
            Lessons.Add(new Animal
            {
                Name = "Верификация программного обеспечения",
                Location = "Макаров Константин Сергеевич",
                Details = "Практика",
                ImageUrl = "9:40"
            });
            Lessons.Add(new Animal
            {
                Name = "Верификация программного обеспечения",
                Location = "Макаров Константин Сергеевич",
                Details = "Лекция",
                ImageUrl = "11:20"
            });
            
        }
    }
}
