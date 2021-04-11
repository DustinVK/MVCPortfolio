using System;
using System.Collections.Generic;
using MVCPortfolio.Models;

namespace MVCPortfolio.Data
{
    public class MockPortfolioRepo : IPortfolioRepo
    {
        public MockPortfolioRepo()
        {
        }

        public IEnumerable<Project> GetVisibleProjects()
        {
            var projects = new List<Project>
            {
                new Project{Id=1, Title="This Website", Body="This Website was built with .NET Core",
                    Tags="C#,.Net,MVC,Web Development", CodeLink="codelink", Photo="PhotoLink", ProjectLink="projLink",
                    Visible=true},
                new Project{Id=2, Title="Something else", Body="this is the something else body",
                    Tags="Other", CodeLink="this is the something else codelink", Photo="this is the somethingelse PhotoLink",
                    ProjectLink="somethingelseprojLink",
                    Visible=true},
                new Project{Id=3, Title="This sadasdasdasdsf", Body="asdasdasdasdad",
                    Tags="Cdasdasddas", CodeLink="dsadasdasdasda", Photo="sdfdsfreffvd", ProjectLink="vdsvsdvvs",
                    Visible=true},

            };
            return projects;
        }

        public IEnumerable<Project> GetProjectsByTag(string tag)
        {
            var projects = new List<Project>
            {
                new Project{Id=4, Title="This Website", Body="This Website was built with .NET Core",
                    Tags="C#,.Net,MVC,Web Development", CodeLink="codelink", Photo="PhotoLink", ProjectLink="projLink",
                    Visible=true},
                new Project{Id=5, Title="Something else", Body="this is the something else body",
                    Tags="Other", CodeLink="this is the something else codelink", Photo="this is the somethingelse PhotoLink",
                    ProjectLink="somethingelseprojLink",
                    Visible=true},
                new Project{Id=6, Title="This sadasdasdasdsf", Body="asdasdasdasdad",
                    Tags="Cdasdasddas", CodeLink="dsadasdasdasda", Photo="sdfdsfreffvd", ProjectLink="vdsvsdvvs",
                    Visible=true},

            };
            return projects;

        }

        public Project GetProjectById(int id)
        {
            return new Project
            {
                Id = id,
                Title = "This Website",
                Body = "This Website was built with .NET Core",
                Tags = "C#,.Net,MVC,Web Development",
                CodeLink = "codelink",
                Photo = "PhotoLink",
                ProjectLink = "projLink",
                Visible = true
            };
        }
    }
}
