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
        public LinkedList<SubjectCurriculum> curriculum { get; private set; }

        public Curriculum(int id, string name, LinkedList<SubjectCurriculum> curriculum)
        {
            this.id = id;
            this.name = name;
            this.curriculum = curriculum;
        }

        public static Curriculum copy(Curriculum original)
        {
            LinkedList<SubjectCurriculum> newList = new LinkedList<SubjectCurriculum>();
            foreach (SubjectCurriculum sc in original.curriculum)
            {
                newList.AddLast(SubjectCurriculum.copy(sc));
            }
            return new Curriculum(original.id, original.name, newList);
        }
    }
}
