using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace GA
{
    public class Algorithm
    {
        List<Schedule> population;
        List<Group> groups;
        List<Curriculum> curriculum;
        List<Audience> audiences;
        List<Professor> professors;

        public Algorithm()
        {
            population = new List<Schedule>();
            IDataProvider dataProvider = DataProviderFactory.getTestDataProvider();
            groups = dataProvider.getGroups();
            curriculum = dataProvider.getCurriculum();
            audiences = dataProvider.getAudiences();
            professors = dataProvider.getProfessors();
        }

        public void generateInitialPopulation(int count)
        {
            RandomScheduleGenerator rnd = new RandomScheduleGenerator(groups,
                    curriculum, audiences, professors);
            for (int i = 0; i < count; i++)
            {
                population.Add(rnd.getRandomSchedule(i));
            }
        }
    }
}
