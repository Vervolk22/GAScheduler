using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TeachPossibility
    {
        public Professor professor { get; protected set; }
        public bool canLecture { get; protected set; }

        public TeachPossibility(Professor professor, bool canLecture)
        {
            this.professor = professor;
            this.canLecture = canLecture;
        }

        public static TeachPossibility copy(TeachPossibility original)
        {
            return new TeachPossibility(Professor.copy(original.professor), 
                original.canLecture);
        }
    }
}
