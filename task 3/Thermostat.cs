namespace task_3;

public class Thermostat : IDevice
{

    public string TurnOn()
    {
        return "The thermostat is turned on";
    }
    public string TurnOff()
    {
        return "The thermostat is turned off";
    }

    public string IsTurnedOnOrOff(bool found)
    {
        if (found == true)
        {
            return TurnOn();
        }
        else
        {
            return TurnOff();
        }
    }

    public void ThermostatOnTime()
    {
        System.Console.WriteLine("Thermostat was turned on 1 hour ago ");
    }
    public void ThermostatOffTime()
    {
        System.Console.WriteLine("Thermostat was turned off 1 hour ago ");
    }



}
