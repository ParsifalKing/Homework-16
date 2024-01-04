namespace task_3;

public class Lamp : IDevice
{

    public string TurnOn()
    {
        return "The lamp is turned on";
    }
    public string TurnOff()
    {
        return "The lamp is turned off";
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

}
