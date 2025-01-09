using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem_Core.Entities;
using TaskManagementSystem_Core.Repositories;
using TaskManagementSystem_DAL.Contexts;

namespace TaskManagementSystem_DAL.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(TaskManagementSystemDbContext _context) : base(_context)
        {
        }
    }
}
