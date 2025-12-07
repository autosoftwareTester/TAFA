using System.Drawing;

namespace ConsoleApp.DesignArchitecture;

public interface IFlyBehaviour
{
    public void Fly();
}

// Different Types of Fly Behaviours - Abstraction - Changes
public class FlyWithWings : IFlyBehaviour
{
    public void Fly()
    {
        Console.WriteLine("Non real-life duck can fly with wings");
    }

    public Color Color { get; set; }
}

public class FlyNoWays : IFlyBehaviour, IColor
{
    public virtual void Fly()
    {
        Console.WriteLine("Non real-life duck cannot fly");
    }

    public Color Color { get; set; }
}