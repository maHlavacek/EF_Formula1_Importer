using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Formula1.Core.Entities
{
    public class Race
    {
        public int? Number { get; set; }
        [MaxLength(200)]
        public string Country { get; set; }
        [MaxLength(200)]
        public string City { get; set; }
        public DateTime Date { get; set; }
        public int RaceId { get; set; }

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
