﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ConnectionNPG.Entities;

public class Task
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Desc { get; set; }
    public DateTime Date { get; set; }
    public Step Status { get; set; }
    public Guid? LessonId { get; set;}
    [ForeignKey(nameof(LessonId))]
    public Lesson? Lesson { get; set; }
    public Guid? CommentId { get; set; }
    [ForeignKey(nameof(CommentId))]
    public Comment? Comment { get; set; }

}