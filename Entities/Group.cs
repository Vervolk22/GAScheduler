using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CountOfStudents { get; set; }

        public List<Subject> Attempts = new List<Subject>();

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

        public Group(int id, string name, int count, List<Subject> attempts)
        {
            Id = id;
            Name = name;
            CountOfStudents = count;
            Attempts = attempts;
        }
    }
}
