using ProjektLAB03;

List<Ship> shipList = new List<Ship>();
List<Container> containerList = new List<Container>();


while (true)
{
    Console.Clear();
    DisplayStatus();
    Console.WriteLine("Możliwe akcje:");
    Console.WriteLine("1. Dodaj kontenerowiec");
    if (shipList.Count > 0)
    {
        Console.WriteLine("2. Usuń kontenerowiec");
        Console.WriteLine("3. Dodaj kontener (liquid)");
        Console.WriteLine("4. Dodaj kontener (gas)");
        Console.WriteLine("5. Dodaj kontener (cooler)");
        Console.WriteLine("6. Usuń kontener");
    }
    Console.Write("Wybierz opcję: ");
    string choice = Console.ReadLine();

    switch (choice)
    {        
        case "1":
            Console.Write("Podaj dane statku (int maxSpeed, int maxContainersAmount, int maxContainersWeight): \n");
            Console.Write("Podaj int maxSpeed: ");
            int maxSpeed = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj int maxContainersAmount: ");
            int maxContainersAmount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj int maxContainersWeight: ");
            int maxContainersWeight = Convert.ToInt32(Console.ReadLine());
            shipList.Add(new Ship(maxSpeed, maxContainersAmount, maxContainersWeight));
            break;
        case "2": 
            if (shipList.Count < 0) 
                Console.Write("Lista jest pusta");
            else
            {
                Console.Write("Podaj id listy kontenerowca do usuniecia: ");
                int id = Convert.ToInt32(Console.ReadLine());
                if (containerList.Count >= id)
                    Console.Write("Podano bledne id");
                else
                    shipList.Remove(shipList[id]);
            }
            break;
        case "3":
        {
            Console.Write("Podaj dane kontener (int cargoMass, int height, int ownMass, int depth, int volume, bool hazardous): \n");
            Console.Write("Podaj int cargoMass: ");
            int cargoMass = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj int height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj int ownMass: ");
            int ownMass = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj int depth: ");
            int depth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj int volume: ");
            int volume = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj bool hazardous: ");
            bool hazardous = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Podaj do ktorego statku dodac kontener (id): ");
            int id = Convert.ToInt32(Console.ReadLine());
                containerList.Add(new ContainerLiquid(cargoMass, height, ownMass, depth, volume, hazardous));
                shipList[id].addContainerToShip(containerList.Last());

            break;
        }
        case "4":
        {
            Console.Write("Podaj dane kontener (int cargoMass, int height, int ownMass, int depth, int volume, int pressure): \n");
            Console.Write("Podaj int cargoMass: ");
            int cargoMass = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj int height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj int ownMass: ");
            int ownMass = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj int depth: ");
            int depth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj int volume: ");
            int volume = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj bool hazardous: ");
            int pressure = Convert.ToInt32(Console.ReadLine());
            containerList.Add(new ContainerGas(cargoMass, height, ownMass, depth, volume, pressure));
            Console.Write("Podaj do ktorego statku dodac kontener (id): ");
            int id = Convert.ToInt32(Console.ReadLine());
                containerList.Add(new ContainerGas(cargoMass, height, ownMass, depth, volume, pressure));
                shipList[id].addContainerToShip(containerList.Last());

            break;
        }
        case "5":
        {
            Console.Write(
                "Podaj dane kontenerowca (int cargoMass, int height, int ownMass, int depth, int volume, string type): \n");
            Console.Write("Podaj int cargoMass: ");
            int cargoMass = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj int height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj int ownMass: ");
            int ownMass = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj int depth: ");
            int depth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj int volume: ");
            int volume = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj string type: ");
            string type = Convert.ToString(Console.ReadLine());
            Console.Write("Podaj do ktorego statku dodac kontener (id): ");
            int id = Convert.ToInt32(Console.ReadLine());
                containerList.Add(new ContainerCooler(cargoMass, height, ownMass, depth, volume, type));
                shipList[id].addContainerToShip(containerList.Last());
            break;
        }
        case "6":
        {
            Console.Write(
                "Podaj id kontenera do usuniecia: \n");
            int id = Convert.ToInt32(Console.ReadLine());
            
            if (containerList.Count < 0) 
                Console.Write("Lista jest pusta");
            else
            {
                foreach (var ship in shipList)
                {
                    if (ship.Containers.Contains(containerList[id]))
                        ship.Containers.Remove(containerList[id]);
                }
                containerList.Remove(containerList[id]);
            }

            break;
        }
        default: Console.WriteLine("Nieprawidłowa opcja"); break;
    }
}
void DisplayStatus()
{
    
    Console.WriteLine("Lista kontenerowców:");
    if (shipList.Count == 0) 
        Console.WriteLine("Brak");
    else
    {
        int i = 0;
        foreach (var ship in shipList) Console.WriteLine(i++ + " -> " + ship.ToString());
    }

    Console.WriteLine("Lista kontenerów:");
    if (containerList.Count == 0) 
        Console.WriteLine("Brak");
    else
    {
        int i = 0;
        foreach (var container in containerList) Console.WriteLine(i++ + " -> " + container.ToString());
    }

    Console.WriteLine();
}


/*
List<Ship> shipList = new List<Ship>();
List<Container> containerList = new List<Container>();

while (true)
{
    Console.WriteLine("Ships List: ");
    if (shipList.Count == 0)
        Console.WriteLine("Empty");
    else
    {
        foreach (Ship ship in shipList)
        {
            Console.Write(ship.toString());
        }
    }
    Console.WriteLine("Containers List: ");
    if (containerList.Count == 0)
        Console.WriteLine("Empty");
    else
    {
        foreach (Container container in containerList)
        {
            Console.Write(container.toString());
        }
    }
    
}


ContainerLiquid containerLiquid = new ContainerLiquid(1, 1, 1, 1, 1, true);
ContainerLiquid containerLiquid2 = new ContainerLiquid(1, 1, 1, 1, 1, false);
ContainerLiquid containerLiquid3 = new ContainerLiquid(1, 1, 1, 1, 1, true);
ContainerLiquid containerLiquid4 = new ContainerLiquid(1, 1, 1, 1, 1, false);
ContainerLiquid containerLiquid5 = new ContainerLiquid(1, 1, 1, 1, 1, true);
Console.WriteLine(containerLiquid.SerialNumber);
Console.WriteLine(containerLiquid2.SerialNumber);
Console.WriteLine(containerLiquid3.SerialNumber);
Console.WriteLine(containerLiquid4.SerialNumber);
Console.WriteLine(containerLiquid5.SerialNumber);

Console.WriteLine(containerLiquid3.CargoMass);
containerLiquid3.ClearCargo();
Console.WriteLine(containerLiquid3.CargoMass);
// containerLiquid3.SetCargo(327461);

containerLiquid3.SendHazardMessage("skibidi");

ContainerGas containerGas1 = new ContainerGas(1, 1, 1, 1, 1, 1);
containerGas1.SetCargo(1);

Ship ship = new Ship(1, 9999, 9999);
ship.addContainerToShip(containerLiquid);
ship.addContainerToShip(containerLiquid2);
ship.addContainerToShip(containerLiquid3);
ship.addContainerToShip(containerLiquid4);
ship.addContainerToShip(containerLiquid5);
ship.addContainerToShip(containerGas1);


Console.WriteLine(containerLiquid3.toString());
Console.WriteLine(containerGas1.toString());

Console.WriteLine(ship.toString());

ContainerCooler containerCooler = new ContainerCooler(9, 9, 9, 9, 9, "Bananas");
ship.addContainerToShip(containerCooler);
Console.WriteLine(ship.toString());
Console.WriteLine(containerCooler.toString());
containerCooler.SetCargo(2, "Fish");
Console.WriteLine(containerCooler.toString());
Console.WriteLine(ship.toString());
*/