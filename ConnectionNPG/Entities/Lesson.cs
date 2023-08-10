namespace ConnectionNPG.Entities;

public class Lesson
{
    public Guid Id { get; set; }
    public Guid? Course_Id { get; set; }
    public string? Title { get; set; }
    public List<string>? VideoUrl { get; set; }
    public List<string>? Info { get; set; }
 }