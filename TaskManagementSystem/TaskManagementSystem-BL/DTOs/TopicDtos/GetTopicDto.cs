namespace TaskManagementSystem_BL.DTOs.TopicDtos;

public class GetTopicDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<string> Assignments { get; set; }
}