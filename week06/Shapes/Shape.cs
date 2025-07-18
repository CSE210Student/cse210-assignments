using System.Runtime.InteropServices;

public abstract class Shape
{
    private string _color;

    public string GetColor()
    {
        return "";
    }

    public void SetColor(string color)
    {

    }

    public abstract double GetArea();
}