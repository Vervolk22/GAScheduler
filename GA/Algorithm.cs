using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace GA
{
    public class Algorithm
    {
        List<Schedule> population;

        public Algorithm()
        {
            population = new List<Schedule>();
        }

        public void generateInitialPopulation(int count)
        {
            for (int i = 0; i < count; i++)
            {
                population.Add(getRandomIndividual());
            }
        }

        protected Schedule getRandomIndividual(int scheduleId)
        {
            Random rnd = new Random();
            List<Classes> classes = new List<Classes>();
            // TODO fill classes list
            Schedule schedule = new Schedule(scheduleId, classes);
        }
    }
}
