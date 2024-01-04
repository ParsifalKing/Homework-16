namespace task_1;

public class Student : Person
{

    public void Study()
    {
        System.Console.WriteLine($"{Name} studying");
    }
    public void ShowAge()
    {
        System.Console.WriteLine($"{Name}'s age : {Age} years old");
    }



}
