namespace ConnectionNPG.Entities;

public class Task
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Desc { get; set; }
    public DateTime Date { get; set; }
    public Step Status { get; set; }
    public Guid? Lesson_Id { get; set;}
    public Guid? Comment_Id { get; set; }
}