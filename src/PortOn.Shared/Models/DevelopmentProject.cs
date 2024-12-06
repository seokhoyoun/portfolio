using System;
using System.Collections.Generic;

namespace PortOn.Shared.Models
{
    public class DevelopmentProject
    {
        public required string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Company { get; set; }
        public string Role { get; set; }
        
        public List<string> TechStack { get; set; } = new List<string>(10);
    }
}
