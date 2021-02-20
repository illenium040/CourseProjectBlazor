using System.Collections.Generic;
using System.Linq;
using CourseProjectBlazor.DataAccessLayer.Contexts;
using CourseProjectBlazor.DataAccessLayer.Models.RamModels;
using Microsoft.EntityFrameworkCore;

namespace CourseProjectBlazor.DataAccessLayer.RamRepository
{
    public class RamRepository : Repository<Ram>, IRamRepository
    {
        public RamContext RamContext { get {return Context as RamContext;}}
        public RamRepository(DbContext context) : base(context)
        {
        }

        //as an example
        public override Ram Get(int id)
        {
            return RamContext.Rams.FirstOrDefault(x => x.Id == id);
        }

        public override IEnumerable<Ram> GetAll()
        {
            return RamContext.Rams
                .Include(x => x.Manufacturer)
                .Include(x => x.Cooling)
                .Include(x => x.FormFactor)
                .AsNoTracking()
                .AsEnumerable();
        }
    }
}