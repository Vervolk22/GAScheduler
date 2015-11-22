using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Audiences
    {
        public List<Audience> lectionAudiences { get; protected set; }
        public List<Audience> labAudiences { get; protected set; }
        public List<Audience> practiceAudiences { get; protected set; }

        public Audiences(List<Audience> lectionAudiences, List<Audience> labAudiences,
                List<Audience> practiceAudiences)
        {
            this.lectionAudiences = lectionAudiences;
            this.labAudiences = labAudiences;
            this.practiceAudiences = practiceAudiences;
        }
    }
}
