namespace ConsoleApp.DesignArchitecture;

public interface IQuackBehaviour
{
    public void Quack();
}

// Different Types of Quack Behaviours - Abstraction - Changes
public class SqueakBehaviour : IQuackBehaviour
{
    public void Quack()
    {
        Console.WriteLine("Rubber duck will squeak when a user squeeze it");
    }
}

public class MuteBehaviour : IQuackBehaviour
{
    public void Quack()
    {
        Console.WriteLine("Non real-life duck will mute");
    }
}

public class QuackBehaviour : IQuackBehaviour
{
    public void Quack()
    {
        Console.WriteLine("Real life duck can quack");
    }
}