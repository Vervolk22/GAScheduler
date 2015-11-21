using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace GA
{
    class RandomScheduleGenerator
    {
        List<Group> groups;
        List<Curriculum> curriculum;
        List<Audience> audiences;
        List<Professor> professors;

        internal RandomScheduleGenerator(List<Group> groups, List<Curriculum> curriculum,
                List<Audience> audiences, List<Professor> professors)
        {
            this.groups = groups;
            this.curriculum = curriculum;
            this.audiences = audiences;
            this.professors = professors;
        }

        internal Schedule getRandomSchedule(int scheduleId)
        {
            // TODO
            return null;
        }
    }
}
