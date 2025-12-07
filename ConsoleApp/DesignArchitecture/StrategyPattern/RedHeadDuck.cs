using System.Drawing;
using ConsoleApp.DesignArchitecture.DuckDesign;

namespace ConsoleApp.DesignArchitecture;

public class RedHeadDuck : Duck<string>
{
    public RedHeadDuck()
    {
        quackBehaviour = new QuackBehaviour(); 
        flyBehaviour = new FlyWithWings();
        _flapWings = new QuackWithFlapWings();
        color = new ColorBehavior
        {
            Color = Color.GreenYellow
        };
    }
    public override string DisplayColor()
    {
        return $"RedHead duck color is {color.Color.Name}";
    }
}