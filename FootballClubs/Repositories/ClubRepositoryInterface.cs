using System;
using System.Collections.Generic;
using FootballClubs.Entities;

namespace FootballClubs.Repositories
{
    public interface ClubRepositoryInterface
    {
        public IEnumerable<Club> GetClubs();
        public Club GetClub(Guid id);
        public void CreateClub(Club club);
        public void UpdateClub(Club club);
        public void DeleteClub(Guid id);
    }
}