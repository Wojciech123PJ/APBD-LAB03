namespace ProjektLAB03;

public class ContainerLiquid : Container, IHazardNotifier
{
    private static int typeCounter = 1;
    public bool Hazardous { get; set; }
    
    public ContainerLiquid(int cargoMass, int height, int ownMass, int depth, int volume, bool hazardous) : 
        base(cargoMass, height, ownMass, depth, volume)
    {
        SerialNumber = "KON-L-" + typeCounter++;
        Hazardous = hazardous;
    }
    
    public virtual void SendHazardMessage(string message)
    {
        Console.WriteLine(message + " -> " + SerialNumber);
    }
    
    public void SetCargo(int cargoMass, bool hazardous)
    {
        if (hazardous)
        {
            Hazardous = true;
            if (cargoMass > Volume/2)
                Console.WriteLine("Hazardous operation - operation denied");
            else
            {
                CargoMass = cargoMass;
            }
        }
        else
        {
            if (cargoMass > Volume*0.9)
                Console.WriteLine("Hazardous operation - operation denied");
            else
            {
                CargoMass = cargoMass;
            }
        }
    }
    
    public virtual string ToString()
    {
        return "SerialNumber: " + SerialNumber + 
               ", CargoMass: " + CargoMass + 
               ", Height: " + Height + 
               ", OwnMass: " + OwnMass + 
               ", Depth:  " + Depth + 
               ", Volume: " + Volume + 
               ", Hazardous: " + Hazardous;
    }
}