using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Classes
    {
        public static const string[] CLASS_TIME = { "8.00 - 9.35", "9.45 - 11.20", 
                                                    "11.40 - 13.15", "13.25 - 15.00", 
                                                    "15.20 - 16.55", "17.05 - 18.40", 
                                                    "18.45 - 20.20" };

        public Week week { get; protected set; }
        public ClassTime time { get; protected set; }
        public DayOfWeek day { get; protected set; }
        public Audience audience { get; protected set; }
        public Group group { get; protected set; }
        public Professor professor { get; protected set; }
        public Subject subject { get; protected set; }

        public Classes(Week week, ClassTime time, DayOfWeek day, Audience audience,
                Group group, Professor professor, Subject subject)
        {
            this.week = week;
            this.time = time;
            this.day = day;
            this.audience = audience;
            this.group = group;
            this.professor = professor;
            this.subject = subject;
        }
    }


    //I don't know how to do this enum...
    enum ClassTime
    {
        First = 0,
        Second = 1,
        Third = 2,
        Fourth = 3,
        Fifth = 4,
        Sixth = 5,
        Seventh = 6
    }

    enum ClassType
    {
        Lecture = 0,
        Lab = 1,
        Practice = 2
    }

    enum Week
    {
        First = 1,
        Second = 2,
        Third = 3,
        Fourth = 4
    }

}
