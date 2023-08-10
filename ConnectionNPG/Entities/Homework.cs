namespace ConnectionNPG.Entities;

public class Homework
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? ImgUrl { get; set; }
    public Guid? User_Id { get; set;}
    public Guid? Task_Id { get; set; }

}