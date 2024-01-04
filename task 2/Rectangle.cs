namespace task_2;

public class Rectangle : Shape
{

    int length;
    int width;

    public Rectangle(int _length, int _width)
    {
        length = _length;
        width = _width;
    }

    public void PrintArea()
    {
        System.Console.WriteLine((length * width) * 2);
    }


}
