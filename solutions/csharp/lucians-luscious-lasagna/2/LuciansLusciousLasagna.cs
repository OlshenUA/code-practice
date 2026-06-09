class Lasagna
{
    public int ExpectedMinutesInOven() => 40;
    
    public int RemainingMinutesInOven(int currentMins) => ExpectedMinutesInOven() - currentMins;

    public int PreparationTimeInMinutes(int layers) => layers*=2;

    public int ElapsedTimeInMinutes(int layerNum, int minsInOven) => PreparationTimeInMinutes(layerNum) + minsInOven;
}
