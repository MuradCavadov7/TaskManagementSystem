using TaskManagementSystem_Core.Entities.Common;

namespace TaskManagementSystem_Core.Entities;

public class Employee : BaseEntity
{
    public string Name {  get; set; }
    public string Surname {  get; set; }
    public ICollection<Assignment> Assignments { get; set; }
}
