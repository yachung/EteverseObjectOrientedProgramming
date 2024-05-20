class Program
{
    static void Main(string[] args)
    {
        Time time1 = new Time(10);            // 10시 0분 0초.
        Time time2 = new Time(10, 20);        // 10시 20분 0초.
        Time time3 = new Time(10, 20, 30);    // 10시 20분 30초.

        time2.ShowTime();
        time2.ShowTimeInSeconds();
    }
}