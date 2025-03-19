namespace ProjektLAB03;

public class ContainerCooler : Container
{
    private static int typeCounter = 0;
    static Dictionary<string, double> dict = new Dictionary<string, double>
    {
        {"Bananas", 13.3},
        {"Chocolate", 18},
        {"Fish", 2},
        {"Meat", -15},
        {"Ice Cream", -18},
        {"Frozen pizza", -30},
        {"Cheese", 7.5},
        {"Sausage", 5},
        {"Butter", 20.5},
        {"Eggs", 19}
    };

    public string Type;
        
    public ContainerCooler(int cargoMass, int height, int ownMass, int depth, int volume, string type) : 
        base(cargoMass, height, ownMass, depth, volume)
    {
        SerialNumber = "KON-C-" + typeCounter++;

        if (!dict.ContainsKey(type))
        {
            Console.WriteLine("Container cannot contain " + type);
            throw new KeyNotFoundException();
        }
        Type = type;
    }
    
    public void SetCargo(int cargoMass, string type)
    {
        if (!dict.ContainsKey(type))
        {
            Console.WriteLine("Container cannot contain " + type);
            throw new KeyNotFoundException();
        }
        Type = type;
        CargoMass = cargoMass;
    }
    
    public virtual string ToString()
    {
        return "SerialNumber: " + SerialNumber + 
               ", CargoMass: " + CargoMass + 
               ", Height: " + Height + 
               ", OwnMass: " + OwnMass + 
               ", Depth:  " + Depth + 
               ", Volume: " + Volume + 
               ", Type: " + Type;
    }
}