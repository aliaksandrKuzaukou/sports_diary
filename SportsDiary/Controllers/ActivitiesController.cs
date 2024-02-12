using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsDiary.Models;

namespace SportsDiary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivitiesController : ControllerBase
    {
        private readonly IEnumerable<Activity> _activities;

        public ActivitiesController()
        {
            _activities = new List<Activity>
            {
                new Activity
                {
                    Id = Guid.Parse("1e1d8669-0e8d-4b3c-bfd0-896d08c9da03"),
                    Name = "Swimming"
                },
                new Activity
                {
                    Id = Guid.Parse("d7064179-1667-4363-ab9c-e09788d20f5f"),
                    Name = "Gym"
                },
                new Activity
                {
                    Id = Guid.Parse("d7064179-1667-4363-ab9c-e09788d20f5f"),
                    Name = "Workout"
                }
            };
        }

        [HttpGet]
        public IActionResult GetActivities()
        {
            return Ok(_activities);
        }
    }
}
