namespace TaskManagementSystem_BL.DTOs.AssignmentDtos
{
    public class CreateAssignmentDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public int EmployeeId {  get; set; }
        public int TopicId { get; set; }
        public List<int> TagId { get; set; }

    }
}
