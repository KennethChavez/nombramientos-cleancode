public class HomeTasks
{
    private List<string> _tasks = new List<string>();
    public void AddTask(string task) { _tasks.Add(task); }
    public void DisplayTasks() { _tasks.ForEach(task => Console.WriteLine(task)); }
}