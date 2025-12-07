namespace ConsoleApp.DesignArchitecture;

public interface ISwimable
{
    public void Swim();
}

public class SwimBehaviour : ISwimable
{
    public void Swim()
    {
        Console.WriteLine("Real life duck swims can on water");
    }
}

public class FloatBehaviour : ISwimable
{
    public void Swim()
    {
        Console.WriteLine("In animate duck floats on water or swims with a user pushing");
    }
}

public class SinkBehaviour : ISwimable
{
    public void Swim()
    {
        Console.WriteLine("In animate wooden duck will sink in water");
    }
}