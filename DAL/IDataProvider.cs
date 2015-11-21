using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public interface IDataProvider
    {
        List<Audience> getAudiences();
        List<Group> getGroups();
        List<Curriculum> getCurriculum();
        List<Professor> getProfessors();
    }
}
