using System;
using System.Collections.Generic;
using System.Text;

namespace Xaminals.Models
{
    class TimeTable
    {
        private string name;
        public string Name { get=>name; set=>name=value; }
        public DateTime Time { get; set; }
        public string ImageUrl { get; set; }
    }
}
