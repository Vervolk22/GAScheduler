using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Group
    {
        public int id { get; set; }
        public string name { get; set; }
        public int countOfStudents { get; set; }
        public Curriculum plan { get; set; }

        /*public Group(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Group(int id, string name, int count)
        {
            Id = id;
            Name = name;
            CountOfStudents = count;
        }*/

        public Group(int id, string name, int count, Curriculum plan)
        {
            this.id = id;
            this.name = name;
            this.countOfStudents = count;
            this.plan = plan;
        }

        public bool isIncomplete()
        {
            if (plan.curriculum.Count > 0)
                return true;
            else
                return false;
        }

        public static Group copy(Group original)
        {
            return new Group(original.id, original.name, original.countOfStudents,
                    original.plan);
        }
    }
}
