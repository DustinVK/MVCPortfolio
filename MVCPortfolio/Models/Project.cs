using System;
namespace MVCPortfolio.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Photo { get; set; }
        public string CodeLink { get; set; }
        public string ProjectLink { get; set; }
        public string Tags { get; set; }
        public bool Visible { get; set; }


        public Project()
        {
        }
    }
}
