using TaskManagementSystem_Core.Entities.Common;

namespace TaskManagementSystem_Core.Entities
{
    public class Topic : BaseEntity
    {
        public string Name {  get; set; }
        public ICollection<Assignment> Assignments {  get; set; } 
    }
}
