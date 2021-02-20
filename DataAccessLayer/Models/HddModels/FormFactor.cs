using System.Collections.Generic;

namespace CourseProjectBlazor.DataAccessLayer.Models.HddModels
{
    public class FormFactor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Hdd> Hdds { get; set; }
    }
}