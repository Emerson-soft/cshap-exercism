static class AssemblyLine
{
    const int PRODUCTION_PER_HOUR = 221;
    const int HOUR_TO_MINUTOS = 60 ;
    public static double SuccessRate(int speed)
    {
        if (speed == 5)
        {
            return 0.90;
        } else if (speed == 4)
        {
            return 1.0;
        } else if (speed == 9)
        {
            return 0.80;
        } else if (speed == 10)
        {
            return 0.77;
        }

        return 0;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return PRODUCTION_PER_HOUR * speed * SuccessRate(speed);        
    }

    public static int  WorkingItemsPerMinute(int speed)
    {
        return (int)ProductionRatePerHour(speed) / HOUR_TO_MINUTOS;
    }
}
