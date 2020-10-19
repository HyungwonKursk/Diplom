using System;
using System.Collections.Generic;
using System.Text;

namespace Xaminals.Models
{
    class Group
    {
        ///<summary>
        ///numb-номер группы ключ
        ///prof-профиль подготовки
        ///col_st-кол-во студентов в группе
        ///
        ///course-курс
        ///</summary>

        private int numb;
        public int Numb { get=>numb; set=> numb = value; }
        private string prof;
        public string Prof { get => prof; set=>prof=value; }

        private int col_st;
        public int Col_St { get => col_st; set => col_st = value; }

        private int course;
        public int Course { get => course; set => course = value; }

        public Group()
        {
            numb = 0; 
            prof = ""; 
            col_st = 0; 
            course = 0;
        }
        public Group(int n, string p, int cs, int c)
        {
            numb = n; 
            prof = p; 
            col_st = cs; 
            course = c;
        }

        public Group(Group group)
        {
            numb = group.numb;
            prof = group.prof;
            col_st = group.col_st;
            course = group.course;
        }
    }
}
