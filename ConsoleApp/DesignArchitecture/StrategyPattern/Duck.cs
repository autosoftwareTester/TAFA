namespace ConsoleApp.DesignArchitecture.DuckDesign;

public abstract class Duck<T>
{
    // supertypes
    // Aggregation and Association relationship
    protected IFlyBehaviour? flyBehaviour;
    protected IQuackBehaviour? quackBehaviour;
    protected IColor? color;
    protected IFlapWings? _flapWings;
    protected ISwimable _swimable;

    // Abstract methods - Changes
    // Subclasses are forced to implement
    // Subclasses use their own different types of implementations for subclasses

    public abstract T DisplayColor();

    // Non Abstract methods - Share and Same for all subclasses
    // Subclasses are not forced to implement
    // Subclasses use same implementations for subclasses

    public void PerformQuack()
    {
        quackBehaviour.Quack();
    }

    public void PerformFly()
    {
        flyBehaviour.Fly();
        _flapWings.FlapWings();
    }
    public void PerformSwim()
    {
        _swimable.Swim();
    }
}