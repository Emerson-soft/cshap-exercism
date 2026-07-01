static class AssemblyLine
{
    const int PRODUCTION_PER_HOUR = 221;
    const int HOUR_TO_MINUTOS = 60 ;
    public static double SuccessRate(int speed)
    {
        if (speed == 0)
        {
            return 0;
        } else if (speed >= 1 && speed <= 4)
        {
            return 1;
        } else if (speed >= 5 && speed <= 8)
        {
            return 0.9;
        } else if (speed == 9)
        {
            return 0.8;
        }

        return 0.77;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return PRODUCTION_PER_HOUR * speed * SuccessRate(speed);
    }

    public static int  WorkingItemsPerMinute(int speed)
    {
        return (int) ProductionRatePerHour(speed) / HOUR_TO_MINUTOS;
    }
}
