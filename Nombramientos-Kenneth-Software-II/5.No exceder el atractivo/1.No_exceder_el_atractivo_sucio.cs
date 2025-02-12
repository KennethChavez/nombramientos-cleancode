public class HomeTasks
{
    private List<string> _tasks = new List<string>();
    public void AddTask(string task) 
    { 
        if (!_tasks.Contains(task))
        {
            _tasks.Add(task); 
        }
    }
    public void DisplayTasks() 
    { 
        foreach (var task in _tasks)
        {
            Console.WriteLine(task + " - Tarea doméstica");
        }
    }
}