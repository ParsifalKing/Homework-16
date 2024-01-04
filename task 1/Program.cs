

using task_1;

var student = new Student();
System.Console.Write("Enter your name : ");
student.Name = System.Console.ReadLine();
System.Console.Write("Enter your age : ");
student.Age = Convert.ToInt32(System.Console.ReadLine());
student.Study();
student.ShowAge();
System.Console.WriteLine();


var teacher = new Teacher();
System.Console.Write("Enter teacher's name : ");
teacher.Name = System.Console.ReadLine();
teacher.Explain();
