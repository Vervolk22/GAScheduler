using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Schedule
    {
        public int Id { get; set; }
        public List<Classes> Classes = new List<Classes>();

        public Schedule(int id, List<Classes> classes)
        {
            Classes = classes;
        }
    }
}
