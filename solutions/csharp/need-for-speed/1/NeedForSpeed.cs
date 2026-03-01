class RemoteControlCar
{
    int _speed;
    int _batteryDrain;
    int _batteryStatus;
    int _distanceDriven;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        _speed = speed;
        _batteryDrain = batteryDrain;
        _batteryStatus = 100;
    }

    public bool BatteryDrained() => _batteryStatus <= 0 || _batteryDrain > _batteryStatus;
    public int DistanceDriven() => _distanceDriven;
    public void Drive()
    {
        if (BatteryDrained()) { return; }
        _batteryStatus -= _batteryDrain;
        _distanceDriven += _speed;
        
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    private int _distance;
    
    public RaceTrack(int distance) 
    {
        _distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (car.DistanceDriven() < _distance)
        {
            if (car.BatteryDrained()) return false;
            car.Drive();
        }
        return true;

    }
}
