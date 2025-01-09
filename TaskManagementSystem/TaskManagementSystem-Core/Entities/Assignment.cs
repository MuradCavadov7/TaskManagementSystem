using TaskManagementSystem_Core.Entities.Common;

namespace TaskManagementSystem_Core.Entities
{
    public class Assignment : BaseEntity
    {
        public string Title {  get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public int EmployeeId {  get; set; }
        public Employee Employee { get; set; }
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}
