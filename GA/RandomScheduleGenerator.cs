using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace GA
{
    protected internal class RandomScheduleGenerator
    {
        List<Group> groups;
        List<Curriculum> curriculum;
        List<Audience> audiences;
        List<Professor> professors;

        protected internal RandomScheduleGenerator(List<Group> groups, List<Curriculum> curriculum,
                List<Audience> audiences, List<Professor> professors)
        {
            this.groups = groups;
            this.curriculum = curriculum;
            this.audiences = audiences;
            this.professors = professors;
        }

        protected internal Schedule getRandomSchedule(int scheduleId)
        {
            // TODO
            throw new NotImplementedException();
        }
    }
}
