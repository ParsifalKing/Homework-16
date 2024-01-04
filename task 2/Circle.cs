using System.Drawing;

namespace task_2;

public class Circle : Shape
{

    int radius;

    public Circle(int _radius)
    {
        radius = _radius;
    }

    public void PrintArea()
    {
        System.Console.WriteLine(radius * radius * 3.14);
    }


}
