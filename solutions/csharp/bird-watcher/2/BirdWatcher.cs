class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] birdsLastWeek = {0, 2, 5, 3, 7, 8, 4};
        return birdsLastWeek;
    }

    public int Today() =>birdsPerDay[birdsPerDay.Length - 1];

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1]++;
    }

    public bool HasDayWithoutBirds()
    {
        for (int i = 0; i < birdsPerDay.Length; i++)
        {
            if (birdsPerDay[i] == 0)
            {
                return true;
            }
        }
        
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int sum = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            sum += birdsPerDay[i];
        }

        return sum;
    }

    public int BusyDays()
    {
        int busyDays = 0;

        foreach (int day in birdsPerDay)
        {
            if (day >= 5)
            {
                busyDays ++;
            }
        }
        return busyDays;
    }
}
