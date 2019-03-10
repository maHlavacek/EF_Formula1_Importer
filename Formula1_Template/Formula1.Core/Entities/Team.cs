using Formula1.Core.Contracts;
using System.Collections.Generic;

namespace Formula1.Core.Entities
{
    public class Team : ICompetitor
    {

        public string Name { get; set; }

        public string Nationality { get; set; }
        public ICollection<Driver> Drivers { get; set; }

        public Team()
        {
            Drivers = new List<Driver>();
        }


        public override string ToString()
        {
            return $"{Name} Nationalität: {Nationality}";
        }

    }
}
