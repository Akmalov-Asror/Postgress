using System.ComponentModel.DataAnnotations.Schema;

namespace ConnectionNPG.Entities;

public class DescriptionCourse
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public string? Review { get; set; }
    public Guid? CourseId { get; set; }
    [ForeignKey(nameof(CourseId))]
    public Course? Course { get; set; }
}