using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CourseProjectBlazor.DataAccessLayer.Contexts;
using CourseProjectBlazor.DataAccessLayer.HddRepository;
using CourseProjectBlazor.DataAccessLayer.Models.HddModels;
using CourseProjectBlazor.DataAccessLayer.Models.RamModels;
using CourseProjectBlazor.DataAccessLayer.RamRepository;

namespace CourseProjectBlazor.Services
{
    public class DatabaseService
    {
        private RamRepository _ramRepository;
        private HddRepository _hddRepository;
        public DatabaseService(
            RamContext ramContext,
            HddContext hddContext)
        {
            _ramRepository = new RamRepository(ramContext);
            _hddRepository = new HddRepository(hddContext);
        }

        public async Task<IEnumerable<Ram>> GetAllRam()
        {
           return await Task.FromResult(_ramRepository.GetAll().ToList());
        }

        public async Task<IEnumerable<Hdd>> GetAllHdd() 
        {
            return await Task.FromResult(_hddRepository.GetAll().ToList());
        }
    }
}