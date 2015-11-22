using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Professor
    {
        public int id { get; protected set; }
        public string name { get; protected set; }
        public int busyness { get; protected set; }

        public Professor(int id, string name)
        {
            this.id = id;
            this.name = name;
            busyness = 0;
        }

        /*public Professor(int id, string name, List<TeachPossibility> canTeach)
        {
            this.id = id;
            this.name = name;
            this.canTeach = canTeach;
        }*/

        public static Professor copy(Professor original)
        {
            return new Professor(original.id, original.name);
        }
    }
}
