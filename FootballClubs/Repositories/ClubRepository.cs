using System;
using System.Linq;
using System.Collections.Generic;
using FootballClubs.Entities;

namespace FootballClubs.Repositories
{
    public class ClubRepository : ClubRepositoryInterface
    {
        private readonly List<Club> clubs = new()
        {
            new Club
            {
                ID = Guid.NewGuid(),
                Name = "Real Madrid",
                City = "Madrid",
                Stadium = "Santiago Bernabeu"
            },
            new Club
            {
                ID = Guid.NewGuid(),
                Name = "Chelsea",
                City = "London",
                Stadium = "Stamford Bridge"
            },
            new Club
            {
                ID = Guid.NewGuid(),
                Name = "Juventus",
                City = "Turin",
                Stadium = "Allianz Stadium"
            }
        };

        public IEnumerable<Club> GetClubs()
        {
            return clubs;
        }

        public Club GetClub(Guid id)
        {
            return clubs.Where(m => m.ID == id).SingleOrDefault();
        }

        public void CreateClub(Club club)
        {
            clubs.Add(club);
        }

        public void UpdateClub(Club club)
        {
            var index = clubs.FindIndex(currentClub => currentClub.ID == club.ID);
            clubs[index] = club;
        }

        public void DeleteClub(Guid id)
        {
            var index = clubs.FindIndex(currentClub => currentClub.ID == id);
            clubs.RemoveAt(index);
        }
    }
}