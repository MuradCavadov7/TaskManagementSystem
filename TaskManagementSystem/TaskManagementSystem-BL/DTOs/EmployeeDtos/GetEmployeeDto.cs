namespace TaskManagementSystem_BL.DTOs.EmployeeDtos
{
    public class GetEmployeeDto 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<string> Assignments { get; set; }
    }
}
