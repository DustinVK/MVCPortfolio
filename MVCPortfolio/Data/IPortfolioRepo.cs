using System;
using System.Collections.Generic;
using MVCPortfolio.Models;

namespace MVCPortfolio.Data
{
    public interface IPortfolioRepo
    {
        IEnumerable<Project> GetVisibleProjects();
        IEnumerable<Project> GetProjectsByTag(string tag);
        Project GetProjectById(int id);
    }
}
