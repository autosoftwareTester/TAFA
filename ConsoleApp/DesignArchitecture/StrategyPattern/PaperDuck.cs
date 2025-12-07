using System.Drawing;

namespace ConsoleApp.DesignArchitecture.DuckDesign;

public class PaperDuck : Duck<string>
{
    public PaperDuck()
    {
        // SubTypes of IQuackBehaviour and IFlyBehaviour
        quackBehaviour = new MuteBehaviour();
        flyBehaviour = new FlyNoWays();
        _flapWings = new QuackWithoutFlapWings();
        color = new ColorBehavior
        {
            Color = Color.Brown
        };
    }

    public override string DisplayColor()
    {
        return $"Rubber duck color is {color.Color.Name}";
    }
}