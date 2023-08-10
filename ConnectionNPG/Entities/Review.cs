namespace ConnectionNPG.Entities;

public class Review
{
    public Guid Id { get; set; }
    public string? Description { get; set; }
    public string? Name { get; set; }
    public Guid? DescriptionCourse_Id { get; set; }
}