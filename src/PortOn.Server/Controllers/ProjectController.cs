using Microsoft.AspNetCore.Mvc;
using PortOn.Shared.Models;
using System;
using System.Collections.Generic;

namespace PortOn.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController : ControllerBase
    {
        private static List<DevelopmentProject> projects = new List<DevelopmentProject>
            {
                 new DevelopmentProject
                 {
                     Name = "BSA Battery Leak Tester",
                     Description = "Description for Project A",
                     Company = "Phoenixon Controls",
                     StartDate = new DateTime(2021, 7, 1),
                     EndDate = new DateTime(2021, 9, 1),
                     TechStack = new List<string> { "C#", ".NET", "WPF" }
                 },
                 new DevelopmentProject
                 {
                     Name = "Project B",
                     Description = "Description for Project B",
                     StartDate = new DateTime(2022, 7, 1),
                     EndDate = new DateTime(2022, 12, 1),
                     TechStack = new List<string> { "JavaScript", "React", "Node.js" }
                 },
                 new DevelopmentProject
                 {
                     Name = "Project C",
                     Description = "Description for Project C",
                     StartDate = new DateTime(2021, 3, 1),
                     EndDate = new DateTime(2021, 8, 1),
                     TechStack = new List<string> { "Python", "Django", "PostgreSQL" }
                 },
                 new DevelopmentProject
                 {
                     Name = "Project D",
                     Description = "Description for Project D",
                     StartDate = new DateTime(2020, 5, 1),
                     EndDate = new DateTime(2020, 10, 1),
                     TechStack = new List<string> { "Java", "Spring Boot", "MySQL" }
                 },
                 new DevelopmentProject
                 {
                     Name = "Project E",
                     Description = "Description for Project E",
                     StartDate = new DateTime(2019, 2, 1),
                     EndDate = new DateTime(2019, 7, 1),
                     TechStack = new List<string> { "Ruby", "Rails", "SQLite" }
                 },
                          new DevelopmentProject
                 {
                     Name = "Project F",
                     Description = "Description for Project F",
                     StartDate = new DateTime(2018, 4, 1),
                     EndDate = new DateTime(2018, 9, 1),
                     TechStack = new List<string> { "PHP", "Laravel", "MariaDB" }
                 },
                          new DevelopmentProject
                 {
                     Name = "Project G",
                     Description = "Description for Project G",
                     StartDate = new DateTime(2017, 6, 1),
                     EndDate = new DateTime(2017, 11, 1),
                     TechStack = new List<string> { "C++", "Qt", "SQLite" }
                 },
                          new DevelopmentProject
                 {
                     Name = "Project H",
                     Description = "Description for Project H",
                     StartDate = new DateTime(2016, 8, 1),
                     EndDate = new DateTime(2016, 12, 1),
                     TechStack = new List<string> { "Swift", "iOS", "CoreData" }
                 },
                 new DevelopmentProject
                 {
                     Name = "Project I",
                     Description = "Description for Project I",
                     StartDate = new DateTime(2015, 10, 1),
                     EndDate = new DateTime(2016, 3, 1),
                     TechStack = new List<string> { "Kotlin", "Android", "Room" }
                 },
                 new DevelopmentProject
                 {
                     Name = "Project J",
                     Description = "Description for Project J",
                     StartDate = new DateTime(2014, 12, 1),
                     EndDate = new DateTime(2015, 5, 1),
                     TechStack = new List<string> { "Go", "Gin", "MongoDB" }
                 }
            };

        [HttpGet]
        public ActionResult<List<DevelopmentProject>> GetProjects()
        {
            return Ok(projects);
        }
    }
}
