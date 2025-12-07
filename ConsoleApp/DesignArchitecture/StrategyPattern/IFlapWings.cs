namespace ConsoleApp.DesignArchitecture.DuckDesign;

public interface IFlapWings
{
    public void FlapWings();
}

public class QuackWithFlapWings : IFlapWings
{
    public void FlapWings()
    {
        Console.WriteLine("Duck is flapping its wings while quacking");
    }
}
public class QuackWithoutFlapWings : IFlapWings
{
    public void FlapWings()
    {
        Console.WriteLine("Duck is quacking without flapping its wings");
    }
}