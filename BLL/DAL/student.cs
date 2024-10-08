namespace BLL.DAL;

public class Student
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public DateTime BirthDate { get; set; }
    public decimal Gpa { get; set; }
}