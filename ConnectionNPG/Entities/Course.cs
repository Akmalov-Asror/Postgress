﻿namespace ConnectionNPG.Entities;

public class Course
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public decimal? Price { get; set; }
    public string? ImgUrl { get; set; }
    public Guid? DescriptionCourse_Id { get; set;}
}