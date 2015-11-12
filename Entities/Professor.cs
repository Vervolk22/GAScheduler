using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Professor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //need dynamic collections, but now let be static array
        public Classes[] CanTeach = new Classes[5];

        public Professor(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Professor(int id, string name, Classes[] teach)
        {
            Id = id;
            Name = name;
            CanTeach = teach;
        }

    }
}
