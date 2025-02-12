public class HomeTasks
{
    private List<string> _tasks = new List<string>();
    public void A(string task) { _tasks.Add(task); }
    public void B() { _tasks.ForEach(task => Console.WriteLine(task)); }
}