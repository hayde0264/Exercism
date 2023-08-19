
static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed >= 1 && speed <=4)
        { 
            return 100;
        }
        else if (speed >=5 && speed <= 8)
        { 
            return (double)0.90;
        }
        else if (speed == 9)
        { 
            return (double)0.80;
        }
        else 
        { 
            return (double)0.77;
        }
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return speed * 221 * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (double)(speed /  5.1);
    }
}
