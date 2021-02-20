using System.Collections.Generic;

namespace CourseProjectBlazor.DataAccessLayer.Models.HddModels
{
    public class Interface
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Hdd> Hdds { get; set; }
    }
}