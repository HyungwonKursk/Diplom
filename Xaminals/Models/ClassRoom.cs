using System;
using System.Collections.Generic;
using System.Text;

namespace Xaminals.Models
{
    /// <summary>
    /// Аудитория
    /// Необходимо продумать ситуация с общим количеством мест, местами за компьютерами,наличие проектора и тд.
    /// </summary>
    class ClassRoom
    {
        private int id;
        public int Id { get => id; set => id = value; }
        private int capacity;//вместимость
        public int Capacity { get => capacity; set => capacity = value; }
        private string type;
        public string Type { get => type; set => type = value; }//тип аудитории

        public ClassRoom()
        {
            id = 0;
            capacity = 0;
            type = "";
        }

        public ClassRoom(int _id,int _capacity,string _type)
        {
            id = _id;
            capacity = _capacity;
            type = _type;
        }

        public ClassRoom(ClassRoom classRoom)
        {
            id = classRoom.id;
            capacity = classRoom.capacity;
            type = classRoom.type;
        }

    }
}
