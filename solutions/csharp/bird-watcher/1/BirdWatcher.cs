class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => new int[] {0, 2, 5, 3, 7, 8, 4};

    public int Today() => this.birdsPerDay[this.birdsPerDay.Length - 1];

    public void IncrementTodaysCount()
    {
        this.birdsPerDay[this.birdsPerDay.Length - 1] += 1;        
    }

    public bool HasDayWithoutBirds()
    {
        foreach (int count in this.birdsPerDay)
        {
            if (count == 0) return true;
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int result = 0;

        for (int i = 0; i < numberOfDays; i++)
        {
            result += this.birdsPerDay[i];
        }
        return result;
    }

    public int BusyDays()
    {
        int countOfBusyDays = 0;

        foreach (int birdCount in this.birdsPerDay)
        {
            if (birdCount >= 5) countOfBusyDays++;
        }

        return countOfBusyDays;
    }
}
