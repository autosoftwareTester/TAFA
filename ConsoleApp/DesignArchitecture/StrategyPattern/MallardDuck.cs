using System.Drawing;

namespace ConsoleApp.DesignArchitecture.DuckDesign;

public class MallardDuck : Duck<string>
{
    public MallardDuck()
    {
        // Composition on behaviours - subtypes
        flyBehaviour = new FlyWithWings();
        quackBehaviour = new QuackBehaviour();
        color = new ColorBehavior
        {
            Color = Color.Bisque
        };
        _flapWings = new QuackWithFlapWings();
        _swimable = new SwimBehaviour();
    }

    public override string DisplayColor()
    {
        //Change -> Problem/Task -> Ask -> Solution (algorithm, flowchart, pseudocode )
        return $"MallardDuck Color is: {color.Color.Name} and Black";
    }
}