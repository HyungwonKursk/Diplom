using System;
using System.Collections.Generic;
using System.Text;

namespace Xaminals.Models
{
    class Time
    {
        ///<summary>
        ///Время пар.
        ///1 пара, например, в 8:00 и тд
        ///</summary>
        private int number;
        public int Number { get => number; set => number = value; }

        private int hour;
        public int Hour { get => hour; set => hour = value; }

        private int minute;
        public int Minute { get => minute; set => minute = value; }


        public Time()
        {
            number = 0;
            hour = 0;
            minute = 0;
        }
        public Time(int _name, int _hour, int _minute)
        {
            number = _name;
            hour = _hour;
            minute = _minute;
        }

        public Time(Time time)
        {
            number = time.number;
            hour = time.hour;
            minute = time.minute;
        }
    }
}
