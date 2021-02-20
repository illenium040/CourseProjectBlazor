namespace CourseProjectBlazor.DataAccessLayer.Models.HddModels
{
    public class Hdd : Product
    {
        public override int Id { get; set; }
        
        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }

        public override string Model { get; set; }
        public string ManufacturerCode { get; set; }
        
        public int FormFactorId { get; set; }
        public FormFactor FormFactor { get; set; }

        public int InterfaceId { get; set; }
        public Interface Interface { get; set; }

        public int Size { get; set; }
        public int BufferSize { get; set; }
        public int Speed { get; set; }
        public override int Price { get; set; }

        public bool IsOem { get; set; }
    }
}