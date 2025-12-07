namespace ConsoleApp.DesignArchitecture.ObserverPattern;

public interface IHeadHunter // Interface Subject/Publisher
{
    // Abstraction: Common shared behaviours - Association - 1 -> *
    public void RegisterObserver();
    public void RemoveObserver();
    public void NotifyObserver();
}

public class OfferZen : IHeadHunter // Concrete Subject/Publisher 
{
    public void NotifyObserver()
    {
        Console.WriteLine("Notifying all registered observers about new job postings");
    }

    public void RegisterObserver()
    {
        Console.WriteLine("Registering a new observer for job notifications");
    }

    public void RemoveObserver()
    {
        Console.WriteLine("Removing an observer from job notifications");
    }
}

public class IQX : IHeadHunter // Concrete Subject/Publisher 
{
    public void NotifyObserver()
    {
        Console.WriteLine("Notifying all registered observers about new job postings");
    }

    public void RegisterObserver()
    {
        Console.WriteLine("Registering a new observer for job notifications");
    }

    public void RemoveObserver()
    {
        Console.WriteLine("Removing an observer from job notifications");
    }
}
public class PNET : IHeadHunter // Concrete Subject/Publisher
{
    public void NotifyObserver()
    {
        Console.WriteLine("Notifying all registered observers about new job postings");
    }

    public void RegisterObserver()
    {
        Console.WriteLine("Registering a new observer for job notifications");
    }

    public void RemoveObserver()
    {
        Console.WriteLine("Removing an observer from job notifications");
    }
}