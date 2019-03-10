using Formula1.Core.Contracts;
using System.ComponentModel.DataAnnotations;

namespace Formula1.Core.Entities
{
    public class Driver : ICompetitor
    {
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public int DriverId { get; set; }

        public override string ToString()
        {
            return $"{LastName} {FirstName}";
        }

        public string Name => ToString();
    }
}
