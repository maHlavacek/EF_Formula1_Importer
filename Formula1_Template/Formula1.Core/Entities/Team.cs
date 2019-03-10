using Formula1.Core.Contracts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Formula1.Core.Entities
{
    public class Team : ICompetitor
    {
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Nationality { get; set; }
        public ICollection<Driver> Drivers { get; set; }

        public int TeamId { get; set; }

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
