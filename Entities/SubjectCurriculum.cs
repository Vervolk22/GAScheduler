using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SubjectCurriculum
    {
        public int id { get; set; }
        public Subject subject { get; set; }
        public int lectureCount { get; set; }
        public int labsCount { get; set; }
        public int practiceCount { get; set; }

        public SubjectCurriculum(int id, Subject subject, int lectureCount,
                int labsCount, int practiceCount)
        {
            this.id = id;
            this.subject = subject;
            this.lectureCount = lectureCount;
            this.labsCount = labsCount;
            this.practiceCount = practiceCount;
        }
    }
}
