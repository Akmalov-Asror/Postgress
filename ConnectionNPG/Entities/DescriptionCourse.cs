namespace ConnectionNPG.Entities;

public class DescriptionCourse
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public string? Review { get; set; }
    public Guid? Course_Id { get; set; }
}