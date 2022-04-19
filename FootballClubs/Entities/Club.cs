using System;
using System.ComponentModel.DataAnnotations;

namespace FootballClubs.Entities
{
    public class Club
    {
        [Required]
        public Guid ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Stadium { get; set; }
    }
}