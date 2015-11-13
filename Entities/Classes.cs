using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Classes
    {
        public Week Week { get; set; }
        public ClassTime Time { get; set; }
        public DayOfWeek Day { get; set; }
        public Audience Audience { get; set; }
        public Group Group { get; set; }
        public Professor Professor { get; set; }
        public Subject Subject { get; set; }

    }


    //I don't know how to do this enum...
    enum ClassTime
    {
        
    }

    enum Week
    {
        First = 1,
        Second = 2,
        Third = 3,
        Fourth = 4
    }

}
