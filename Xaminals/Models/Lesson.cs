using System;
using System.Collections.Generic;
using System.Text;

namespace Xaminals.Models
{
    class Lesson
    {
        private int id;//id занятия
        public int Id { get => id; set => id = value; }

        private int? id_classroom;//id аудитории
        public int? Id_classroom { get => id_classroom; set => id_classroom = value; }

        private int? id_group;//id группы у которой занятие
        public int? Id_group { get => id_group; set => id_group = value; }

        private string type;//id тип занятия. лекция, практика и тд.
        public string Type { get => type; set => type = value; }

        private int? id_subject;//id  предмета
        public int? Id_subject { get => id_subject; set => id_subject = value; }

        private int? id_teacher;//id  преподавателя
        public int? Id_teacher { get => id_teacher; set => id_teacher = value; }

        private int? id_week;//id недели
        public int? Id_week { get => id_week; set => id_week = value; }

        private int? id_time;//id  времени
        public int? Id_time { get => id_time; set => id_time = value; }

        public Lesson(int _id, int _classroom, int _group, string _type,
            int _subject, int _teacher, int _week, int _time)
        {
            id = _id;
            id_classroom = _classroom;
            id_group = _group;
            type = _type;
            id_subject = _subject;
            id_teacher = _teacher;
            id_week = _week;
            id_time = _time;
        }

        public Lesson()
        {
            id = 0;
            id_classroom = 0;
            id_group = 0;
            type = "";
            id_subject = 0;
            id_teacher = 0;
            id_week = 0;
            id_time = 0;
        }

        public Lesson(Lesson lesson)
        {
            id = lesson.id;
            id_classroom = lesson.id_classroom;
            id_group = lesson.id_group;
            type = lesson.type;
            id_subject = lesson.id_subject;
            id_teacher = lesson.id_teacher;
            id_week = lesson.id_week;
            id_time = lesson.id_time;
        }

    }
}
