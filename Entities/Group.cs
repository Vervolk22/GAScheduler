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
        
        public List<Classes> Attempts = new List<Classes>();

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

        public Group(int id, string name, int count, List<Classes> attempts)
        {
            Id = id;
            Name = name;
            CountOfStudents = count;
            Attempts = attempts;
        }
    }
}
