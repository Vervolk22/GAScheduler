using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TeachPossibility
    {
        public Subject subject { get; protected set; }
        public bool canLecture { get; protected set; }

        public TeachPossibility(Subject subject, bool canLecture)
        {
            this.subject = subject;
            this.canLecture = canLecture;
        }
    }
}
