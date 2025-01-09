namespace TaskManagementSystem_BL.DTOs.AssignmentDtos
{
    public class GetAssignmentDto
    {
        public int Id {  get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public string Employee { get; set; }
        public string Topic { get; set; }
        public List<string> Tag { get; set; }
    }
}
