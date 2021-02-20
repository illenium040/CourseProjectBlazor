namespace CourseProjectBlazor.DataAccessLayer.Models.RamModels
{
    public class Ram : Product
    {
        public override int Id { get; set; }
        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
        
        public override string Model { get; set; }

        public int FormFactorId { get; set; }
        public FormFactor FormFactor { get; set; }

        public int TypeId { get; set; }
        public Type Type { get; set; }

        public int OneModuleSize { get; set; }
        public int ModuleAmount { get; set; }
        public int Frequency { get; set; }
        public int Throughput { get; set; }
        public int Latency { get; set; }
        public int RasToCasDelay { get; set; }
        public int RowPrechargeDelay { get; set; }
        public double Voltage { get; set; }

        public int CoolingId { get; set; }
        public Cooling Cooling { get; set; }

        public override int Price { get; set; }
        public string ManufacturerCode {get;set;}
    }
}