using Formula1.Core.Contracts;

namespace Formula1.Core.Entities
{
    public class Driver : ICompetitor
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Nationality { get; set; }


        public override string ToString()
        {
            return $"{LastName} {FirstName}";
        }

        public string Name => ToString();
    }
}
