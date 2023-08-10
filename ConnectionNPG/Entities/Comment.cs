namespace ConnectionNPG.Entities;

public class Comment
{   
    public Guid Id { get; set; }
    public Guid? Task_Id { get; set; }
    public Guid? User_Id { get; set; }
    public string? Desc { get; set; }
    public string? DocumentPath { get; set; }
}