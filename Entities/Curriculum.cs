using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Curriculum
    {
        public int id { get; private set; }
        public string name { get; private set; }
        public List<SubjectCurriculum> curriculum { get; private set; }

        public Curriculum(int id, string name, List<SubjectCurriculum> curriculum)
        {
            this.id = id;
            this.name = name;
            this.curriculum = curriculum;
        }
    }
}
