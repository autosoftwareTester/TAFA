using System.Drawing;

namespace ConsoleApp.DesignArchitecture.DuckDesign;

public class WoodenDuck : Duck<string>
{
    public WoodenDuck()
    {
        flyBehaviour = new FlyNoWays();
        quackBehaviour = new MuteBehaviour();
        color = new ColorBehavior { Color = Color.Gray };
        _flapWings = new QuackWithoutFlapWings();
    }
    public override string DisplayColor()
    {
        return $"Wooden Duck is: {color.Color.Name}";
    }
    

}