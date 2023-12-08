using System;
using System.Collections.Generic;

public class TaskManager
{
    private TaskList taskList;

    public TaskManager()
    {
        taskList = new TaskList();
    }

    // ... (other methods remain the same)

    // Ensure correct parameter names in EditTask method
    public void EditTask(int taskId, string newTaskDescription, DateTime newDueDate, int newPriority)
    {
        taskList.EditTask(taskId, newTaskDescription, newDueDate, newPriority);
    }

    // ... (other methods remain the same)
}