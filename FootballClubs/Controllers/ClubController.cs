using System;
using System.Collections.Generic;
using FootballClubs.Entities;
using FootballClubs.Repositories;
using Microsoft.AspNetCore.Mvc;
using FootballClubs.DTO;

namespace FootballClubs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClubController : ControllerBase
    {
        private readonly ClubRepositoryInterface repository;

        public ClubController(ClubRepositoryInterface repositoryInterface)
        {
            repository = repositoryInterface;
        }

        [HttpGet]
        public IEnumerable<Club> GetClubs()
        {
            return repository.GetClubs();
        }

        [HttpGet("{id}")]
        public ActionResult<Club> GetClub(Guid id)
        {
            var club = repository.GetClub(id);

            if (club == null)
            {
                return NotFound();
            }

            return club;
        }

        [HttpPost]
        public ActionResult<ClubDTO> CreateClub(ClubDTO clubDTO)
        {
            Club newClub = new(){
                ID = Guid.NewGuid(),
                Name = clubDTO.Name,
                City = clubDTO.City,
                Stadium = clubDTO.Stadium
            };

            repository.CreateClub(newClub);

            return CreatedAtAction(nameof(GetClub), new { id = newClub.ID }, newClub);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateClub(Guid id, ClubDTO clubDTO)
        {
            var currentClub = repository.GetClub(id);

            if(currentClub == null)
            {
                return NotFound();
            }

            currentClub.Name = clubDTO.Name;
            currentClub.City = clubDTO.City;
            currentClub.Stadium = clubDTO.Stadium;

            repository.UpdateClub(currentClub);

            return Ok(currentClub);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteClub(Guid id)
        {
            var currentClub = repository.GetClub(id);

            if (currentClub == null)
            {
                return NotFound();
            }

            repository.DeleteClub(id);

            return NoContent();
        }
    }
}