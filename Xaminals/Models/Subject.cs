using System;
using System.Collections.Generic;
using System.Text;

namespace Xaminals.Models
{
    class Subject
    {
        ///<summary>
        ///дисциплина
        ///</summary>
        private int id;//номер недели
        public int Id { get => id; set => id = value; }

        private string name; //числитель-знаменатель
        public string Name { get => name; set => name = value; }

        private string attestation;
        public string Attestation { get => attestation; set => attestation = value; }

        public Subject()
        {
            id = 0;
            name = "";
            attestation = "";
        }
        public Subject(int _id, string _name, string _attestation)
        {
            id = _id;
            name = _name;
            attestation = _attestation;
        }

        public Subject(Subject subject)
        {
            id = subject.id;
            name = subject.name;
            attestation = subject.attestation;
        }
    }
}
