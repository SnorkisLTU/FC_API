using System;
using System.ComponentModel.DataAnnotations;

namespace FootballClubs.DTO
{
    public class ClubDTO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Stadium { get; set; }
    }
}