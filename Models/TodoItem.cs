namespace TodoApi.Models;

public class TodoItem
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public Boolean IsCompleted { get; set; }
    public string? Secret { get; set; }
}