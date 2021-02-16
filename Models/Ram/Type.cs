using System.Collections.Generic;

namespace CourseProjectBlazor.Models.Ram
{
    public class Type
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Ram> Rams { get; set; } = new List<Ram>();
    }
}