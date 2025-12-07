using System.Drawing;

namespace ConsoleApp.DesignArchitecture;

public interface IColor
{
    public Color Color { get; set; }
}

public class ColorBehavior : IColor
{
    public Color Color { get; set; }
}