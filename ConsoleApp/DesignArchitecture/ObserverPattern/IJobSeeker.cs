namespace ConsoleApp.DesignArchitecture.ObserverPattern;

public interface IJobSeeker // Observer/Subscriber / Java, C#, Python Developer
{
    // Common shared behaviours - Association - * -> 1
    public void Update();
}

public class JavaDev : IJobSeeker // Observer/Subscriber
{
    public void Update()
    {
        Console.WriteLine("Job seeker has been notified about a new job posting");
    }
}

public class CSharpDev : IJobSeeker // Observer/Subscriber
{
    public void Update()
    {
        Console.WriteLine("Job seeker has been notified about a new job posting");
    }
}

public class PythonDev : IJobSeeker // Observer/Subscriber
{
    public void Update()
    {
        Console.WriteLine("Job seeker has been notified about a new job posting");
    }
}