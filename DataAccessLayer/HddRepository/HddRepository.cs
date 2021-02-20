using System.Collections.Generic;
using System.Linq;
using CourseProjectBlazor.DataAccessLayer.Contexts;
using CourseProjectBlazor.DataAccessLayer.Models.HddModels;
using Microsoft.EntityFrameworkCore;

namespace CourseProjectBlazor.DataAccessLayer.HddRepository
{
    public class HddRepository : Repository<Hdd>, IHddRepository
    {
        public HddContext HddContext { get {return Context as HddContext;}}
        public HddRepository(DbContext context) : base(context)
        {
        }

        public override Hdd Get(int id)
        {
            return HddContext.Hdds.FirstOrDefault(x => x.Id == id);
        }

        public override IEnumerable<Hdd> GetAll()
        {
            return HddContext.Hdds
                .Include(x => x.Manufacturer)
                .Include(x => x.Interface)
                .Include(x => x.FormFactor)
                .AsNoTracking()
                .AsEnumerable();
        }
    }
}