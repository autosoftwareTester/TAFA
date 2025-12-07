using System.Drawing;
using ConsoleApp.DesignArchitecture.DuckDesign;

namespace ConsoleApp.DesignArchitecture;

public class RubberDuck : Duck<string>
{
    public RubberDuck()
    {
        color = new ColorBehavior();
        quackBehaviour = new SqueakBehaviour();
        flyBehaviour = new FlyNoWays();
    }

    public override string DisplayColor()
    {
        color.Color = Color.Yellow;
        return $"Rubber duck color is {color.Color.Name}";
    }
}