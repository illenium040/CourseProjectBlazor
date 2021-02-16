namespace CourseProjectBlazor.Models
{
    public class DatabaseService
    {
        private DatabaseContext _context;

        public DatabaseService(DatabaseContext context)
        {
            _context = context;
        }
    }
}