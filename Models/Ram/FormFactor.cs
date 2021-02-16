using System.Collections.Generic;

namespace CourseProjectBlazor.Models.Ram
{
    public class FormFactor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Ram> Rams { get; set; } = new List<Ram>();
    }
}