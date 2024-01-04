namespace task_1;

public class Person
{
    public int Age { get; set; }
    public string Name { get; set; }

    public void Greet()
    {
        System.Console.WriteLine("Hello!");
    }
    public void SetAge(int age)
    {
        Age = age;
    }


}
