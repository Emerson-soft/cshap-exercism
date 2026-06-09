class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method

    // TODO: define the 'RemainingMinutesInOven()' method

    // TODO: define the 'PreparationTimeInMinutes()' method

    // TODO: define the 'ElapsedTimeInMinutes()' method

    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    public int RemainingMinutesInOven(int value)
    {
        int expected = this.ExpectedMinutesInOven();
        return Math.Abs(value - expected);
    }

    public int PreparationTimeInMinutes(int value)
    {
        return value * 2;
    }

    public int ElapsedTimeInMinutes(int value1, int value2)
    {
        int result = this.PreparationTimeInMinutes(value1);
        return value2 + result;
    }

}
