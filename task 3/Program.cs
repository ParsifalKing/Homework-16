using task_3;

var lamp = new Lamp();
System.Console.Write("Please, enter 'true' or 'false' for lamp : ");
System.Console.WriteLine(lamp.IsTurnedOnOrOff(Convert.ToBoolean(System.Console.ReadLine())));
System.Console.WriteLine();


var thermostat = new Thermostat();
System.Console.Write("Please, enter 'true' or 'false' for thermostat : ");
System.Console.WriteLine(thermostat.IsTurnedOnOrOff(Convert.ToBoolean(System.Console.ReadLine())));
System.Console.WriteLine();

var _lock = new Lock();
bool openOrClose = false;

if (openOrClose == true)
{
    System.Console.WriteLine(_lock.OpenLock());
}
else
{
    System.Console.WriteLine(_lock.CloseLock());
}




