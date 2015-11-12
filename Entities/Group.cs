using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CountOfStudents { get; set; }
        //need a dynamic array, but it will be later
        public Classes[] Attempts = new Classes[15];

        public Group(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Group(int id, string name, int count)
        {
            Id = id;
            Name = name;
            CountOfStudents = count;
        }

        public Group(int id, string name, int count, Classes[] attempts)
        {
            Id = id;
            Name = name;
            CountOfStudents = count;
            Attempts = attempts;
        }
    }
}
