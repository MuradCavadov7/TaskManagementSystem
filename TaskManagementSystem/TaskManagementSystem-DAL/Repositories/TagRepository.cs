using TaskManagementSystem_Core.Entities;
using TaskManagementSystem_Core.Repositories;
using TaskManagementSystem_DAL.Contexts;

namespace TaskManagementSystem_DAL.Repositories
{
    public class TagRepository : GenericRepository<Tag>, ITagRepository
    {
        public TagRepository(TaskManagementSystemDbContext _context) : base(_context)
        {
        }
    }
}
