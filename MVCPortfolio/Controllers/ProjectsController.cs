using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MVCPortfolio.Data;
using MVCPortfolio.Models;

namespace MVCPortfolio.Controllers
{


    [Route("api/projects")]
    [ApiController]
    public class ProjectsController : Controller
    {
        private readonly MockPortfolioRepo _repo = new MockPortfolioRepo();

        [HttpGet]
        public ActionResult<IEnumerable<Project>> GetVisibleProjects()
        {
            var projectItems = _repo.GetVisibleProjects();

            return Ok(projectItems);
        }

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Project>> GetProjectsById(int Id)
        {
            var projectItem = _repo.GetProjectById(Id);

            return Ok(projectItem);
        }


    }
}
