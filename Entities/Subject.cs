using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Subject
    {        
        public int id { get; protected set; }
        public string name { get; protected set; }
        public List<TeachPossibility> canTeached { get; protected set; }
        
        public Subject(int id, string name, List<TeachPossibility> canTeached)
        {
            this.id = id;
            this.name = name;
            this.canTeached = canTeached;
        }

        public static Subject copy(Subject original) {
            List<TeachPossibility> newList = new List<TeachPossibility>();
            foreach (TeachPossibility tp in original.canTeached)
            {
                newList.Add(TeachPossibility.copy(tp));
            }
            return new Subject(original.id, original.name, newList);
        }
    }
}
