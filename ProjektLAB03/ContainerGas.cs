namespace ProjektLAB03;

public class ContainerGas : Container, IHazardNotifier
{
    private static int typeCounter = 1;
    public int Pressure;
    
    public ContainerGas(int cargoMass, int height, int ownMass, int depth, int volume, int pressure) : 
        base(cargoMass, height, ownMass, depth, volume)
    {
        SerialNumber = "KON-G-" + typeCounter++;
        Pressure = pressure;
    }

    public override void ClearCargo()
    {
        CargoMass = (int)(0.05 * CargoMass);
    }
    
    public virtual void SendHazardMessage(string message)
    {
        Console.WriteLine(message + " -> " + SerialNumber);
    }
    
    public virtual string ToString()
    {
        return "SerialNumber: " + SerialNumber + 
               ", CargoMass: " + CargoMass + 
               ", Height: " + Height + 
               ", OwnMass: " + OwnMass + 
               ", Depth:  " + Depth + 
               ", Volume: " + Volume + 
               ", Pressure: " + Pressure;
    }
}