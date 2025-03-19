namespace ProjektLAB03;

public class Container
{
    public int CargoMass { get; set; }
    public int Height{ get; }
    public int OwnMass{ get; } 
    public int Depth{ get; }
    public string SerialNumber{ get; set;  }
    public int Volume{ get; }

    public Container(int cargoMass, int height, int ownMass, int depth, int volume)
    {
        this.CargoMass = cargoMass;
        this.Height = height;
        this.OwnMass = ownMass;
        this.Depth = depth;
        this.Volume = volume;
    }

    public virtual void ClearCargo()
    {
        CargoMass = 0;
    }
    
    public void SetCargo(int cargoMass)
    {
        if (cargoMass > Volume)
            throw new OverflowException("Cargo mass cannot be greater than the volume.");
            
        CargoMass = cargoMass;
    }
    
    public virtual string ToString()
    {
        return SerialNumber + " " + CargoMass + " " + Height + " " + OwnMass + " " + Depth + " " + Volume;
    }
}