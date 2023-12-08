
using System;
using System.Collections.Generic;
using System.Linq;

public class TaskList
{
    private List<Task> tasks;

    public TaskList()
    {
        tasks = new List<Task>();
    }

    public void AddTask(Task task)
    {
        tasks.Add(task);
    }

    public void EditTask(int taskId, string newTaskDescription, DateTime newDueDate, int newPriority)
    {
        Task task = GetTask(taskId);
        if (task != null)
        {
            task.TaskDescription = newTaskDescription;
            task.DueDate = newDueDate;
            task.Priority = newPriority;
        }
    }

    public void DeleteTask(int taskId)
    {
        Task task = GetTask(taskId);
        if (task != null)
        {
            tasks.Remove(task);
        }
    }

    public Task GetTask(int taskId)
    {
        return tasks.FirstOrDefault(t => t.TaskID == taskId);
    }

    public List<Task> GetAllTasks()
    {
        return tasks;
    }

    public int GetTaskCount()
    {
        return tasks.Count;
    }

    public void MarkTaskAsComplete(int taskId)
    {
        Task task = GetTask(taskId);
        if (task != null)
        {
            task.CompletionStatus = true;
        }
    }
}