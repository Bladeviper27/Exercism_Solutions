class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int minutesInOven)
    {
        return this.ExpectedMinutesInOven() - minutesInOven;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int amountLayers)
    {
        return amountLayers * 2;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int minutesInOven)
    {
        return this.PreparationTimeInMinutes(layers) + minutesInOven;
    }
}
