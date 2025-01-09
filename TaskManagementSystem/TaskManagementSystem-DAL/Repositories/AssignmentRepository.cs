using TaskManagementSystem_Core.Entities;
using TaskManagementSystem_Core.Repositories;
using TaskManagementSystem_DAL.Contexts;

namespace TaskManagementSystem_DAL.Repositories
{
    public class AssignmentRepository : GenericRepository<Assignment>, IAssignmentRepository
    {
        public AssignmentRepository(TaskManagementSystemDbContext _context) : base(_context)
        {
        }
    }
}
