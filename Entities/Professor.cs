using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Professor
    {
        public int id { get; set; }
        public string name { get; set; }

        public List<TeachPossibility> canTeach = new List<TeachPossibility>();

        /*public Professor(int id, string name)
        {
            this.id = id;
            this.name = name;
        }*/

        public Professor(int id, string name, List<TeachPossibility> canTeach)
        {
            this.id = id;
            this.name = name;
            this.canTeach = canTeach;
        }

    }
}
