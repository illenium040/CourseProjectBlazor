using System.Collections.Generic;

namespace CourseProjectBlazor.DataAccessLayer.Models.RamModels
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Ram> Rams { get; set; } = new List<Ram>();
    }
}