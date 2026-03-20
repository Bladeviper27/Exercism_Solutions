// TODO implement the IRemoteControlCar interface

using Exercism;

public interface IRemoteControlCar
{
    public int DistanceTravelled { get; }
    public void Drive();
}

public class ProductionRemoteControlCar : IRemoteControlCar, IComparable
{
    public int DistanceTravelled { get; private set; }
    public int NumberOfVictories { get; set; }

    public void Drive()
    {
        DistanceTravelled += 10;
    }


    public int CompareTo(object? obj)
    {
        if (obj == null) return -1;

        ProductionRemoteControlCar other = obj as ProductionRemoteControlCar;
        return this.DistanceTravelled.CompareTo(other.DistanceTravelled);        
    } 
}

public class ExperimentalRemoteControlCar : IRemoteControlCar
{
    public int DistanceTravelled { get; private set; }

    public void Drive()
    {
        DistanceTravelled += 20;
    }
}

public static class TestTrack
{
    public static void Race(IRemoteControlCar car)
    {
        car.Drive();
    }

    public static List<ProductionRemoteControlCar> GetRankedCars(ProductionRemoteControlCar prc1,
        ProductionRemoteControlCar prc2)
    {
        if (prc1.CompareTo(prc2) < 0)
        {
            return new List<ProductionRemoteControlCar>{prc1, prc2 };            
        }
        return new List<ProductionRemoteControlCar> { prc2, prc1 };
        
    }
}
