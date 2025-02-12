public class HomeTasks
{
    private List<string> _tasks = new List<string>();
    public void A(string tsk) { _tasks.Add(tsk); }
    public void B() { _tasks.ForEach(t => Console.WriteLine(t)); }
}