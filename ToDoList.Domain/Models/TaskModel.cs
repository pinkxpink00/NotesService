using ToDoList.Domain.Models.Enum;

namespace ToDoList.Domain.Models;

public class TaskModel
{
    public long Id { get; set; }
    
    public string TaskName { get; set; }
    
    public string Description { get; set; }
    
    public Priority Priority { get; set; }
}