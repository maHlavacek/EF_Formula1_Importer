using System;
using System.Collections.Generic;

namespace Formula1.Core.Entities
{
    public class Race
    {
        public int? Number { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public DateTime Date { get; set; }

        public IEnumerable<Result> Results { get; set; }

        public Race()
        {
            Results = new List<Result>();
        }

        public override string ToString()
        {
            return $"{Number} {Date.ToShortDateString()} {Country}";
        }
    }
}
