using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Professor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Classes> CanTeach = new List<Classes>();

        public Professor(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Professor(int id, string name, List<Classes> teach)
        {
            Id = id;
            Name = name;
            CanTeach = teach;
        }

    }
}
