using System;
using System.Collections.Generic;
using System.Text;

namespace Xaminals.Models
{
    ///<summary>
    ///класс недели
    ///</summary>
    class Week
    {
        private int id;//номер недели
        public int Id { get => id; set => id = value; }
        private int day;//день недели
        public int Day { get => day; set => day = value; }

        private string parity; //числитель-знаменатель
        public string Parity { get => parity; set => parity = value; }


        public Week()
        {
            id = 0;
            day = 0;
            parity = "";
        }
        public Week(int _id , int _day, string _parity)
        {
            id = _id;
            day = _day;
            parity = _parity;
        }

        public Week(Week week)
        {
            id = week.id;
            day = week.day;
            parity = week.parity;
        }
    }
}
