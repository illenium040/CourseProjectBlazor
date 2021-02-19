using System.Diagnostics;
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

        public async Task<Ram> GetFirstRamById(int id)
        {
            return await Task.Run(() => _ramRepository.Get(id));
        }
    }
}