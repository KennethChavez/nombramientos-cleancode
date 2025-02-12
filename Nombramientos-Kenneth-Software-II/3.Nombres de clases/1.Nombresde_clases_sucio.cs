public class A
{
    private List<string> _tasks = new List<string>();
    public void Add(string task) { _tasks.Add(task); }
    public void Show() { _tasks.ForEach(task => Console.WriteLine(task)); }
}

public class B
{
    public void Start()
    {
        A a = new A();
        a.Add("Barrer");
        a.Add("Cocinar");
        a.Show();
    }
}