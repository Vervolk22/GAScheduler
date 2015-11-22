using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Audience
    {
        public int id { get; protected set; }
        public string name { get; protected set; }
        //public int numberOfSeats { get; protected set; }
        public ClassType audienceType { get; protected set; }

        /*public Audience(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public Audience(int id, string name, int count)
        {
            this.id = id;
            this.name = name;
            //this.numberOfSeats = count;
        }

        public Audience(int id, string name, int count, bool isSpecial)
        {
            this.id = id;
            this.name = name;
            //this.numberOfSeats = count;
        }*/

        public Audience(int id, string name, ClassType audienceType)
        {
            this.id = id;
            this.name = name;
            this.audienceType = audienceType;
        }
    }
}
