using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Audience
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfSeats { get; set; }
        public bool IsSpecial { get; set; }

        public Audience(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Audience(int id, string name, int count)
        {
            Id = id;
            Name = name;
            NumberOfSeats = count;
        }

        public Audience(int id, string name, int count, bool isSpecial)
        {
            Id = id;
            Name = name;
            NumberOfSeats = count;
            IsSpecial = isSpecial;
        }
    }
}
