using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CourseProjectBlazor.DataAccessLayer.Contexts;
using CourseProjectBlazor.DataAccessLayer.Models.RamModels;
using CourseProjectBlazor.DataAccessLayer.RamRepository;

namespace CourseProjectBlazor.Services
{
    public class DatabaseService
    {
        private RamRepository _ramRepository;
        public DatabaseService(RamContext context)
        {
            _ramRepository = new RamRepository(context);
            Debug.Print("Repository initialized");
        }

        public async Task<IEnumerable<Ram>> GetAllRam()
        {
           return await Task.FromResult(_ramRepository.GetAll().ToList());
        }

        public async Task<Ram> GetRam(int id) 
        {
            return await Task.FromResult(_ramRepository.Get(id));
        }
    }
}