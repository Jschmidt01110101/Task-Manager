public class Task
{
    public int TaskID { get; set; }
    public string TaskDescription { get; set; }
    public DateTime DueDate { get; set; }
    public int Priority { get; set; }
    public bool CompletionStatus { get; set; }

    public Task(int taskId, string taskDescription, DateTime dueDate, int priority)
    {
        TaskID = taskId;
        TaskDescription = taskDescription;
        DueDate = dueDate;
        Priority = priority;
        CompletionStatus = false; // default value
    }
}