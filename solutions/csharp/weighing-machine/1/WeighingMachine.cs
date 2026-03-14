class WeighingMachine
{
    public int Precision { get; }

    public double Weight { get; set
        {
            field = value >= 0 ? value : throw new ArgumentOutOfRangeException();
        }
    }
    public double TareAdjustment { get; set; } = 5.0;
    public string DisplayWeight
    {
        get
        {
            return Math.Round(Weight - TareAdjustment, Precision).ToString($"F{Precision}") + " kg" ;
        }
    }

    public WeighingMachine(int precision)
    {
        Precision = precision;
    }
}
