namespace ProjektLAB03;

public class Ship : OverfillException
{
    private static int counter = 1;
    public List<Container> Containers = new List<Container>();
    public int MaxSpeed { get; }
    public int MaxContainersAmount { get; }
    public int MaxContainersWeight { get; }
    public string Name;

    public Ship(int maxSpeed, int maxContainersAmount, int maxContainersWeight)
    {
        Name = "Statek_" + counter++;
        MaxSpeed = maxSpeed;
        MaxContainersAmount = maxContainersAmount;
        MaxContainersWeight = maxContainersWeight;
    }

    public void addContainerToShip(Container container)
    {
        int totalWeight = 0;
        foreach(Container con in Containers)
        {
            totalWeight =+ con.CargoMass;
        }

        if (totalWeight > MaxContainersWeight || Containers.Count > MaxContainersAmount)
        {
            throw new OverflowException("Too many containers/Too heavy containers");
        }
        Containers.Add(container);
    }

    public void removeContainerFromShip(string serialNumber)
    {
        foreach(Container con in Containers)
        {
            if (con.SerialNumber == serialNumber)
                Containers.Remove(con);
        }
    }
    public void switchContainer(string serialNumber1, Container c1)
    {
        foreach(Container con in Containers)
        {
            if (con.SerialNumber == serialNumber1)
                Containers.Remove(con);
                Containers.Add(c1);
        }
    }
    
    public string ToString()
    {
        return "Name: " + Name +
               ", MaxSpeed: " + MaxSpeed + 
               ", MaxContainersWeight: " + MaxContainersWeight + 
               ", MaxContainersAmount: " + MaxContainersAmount + 
               ", Containers: " + Containers.Count;
    }
}