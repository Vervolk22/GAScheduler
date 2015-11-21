using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public class TestDataProvider : IDataProvider
    {
        internal TestDataProvider()
        {

        }

        public List<Audience> getAudiences()
        {
            return null;
        }

        public List<Group> getGroups()
        {
            return null;
        }

        public List<Curriculum> getCurriculum()
        {
            return null;
        }
        public List<Professor> getProfessors()
        {
            return null;
        }
    }
}
