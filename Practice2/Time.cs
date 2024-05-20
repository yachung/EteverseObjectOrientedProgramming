using System;
class Time
{
    private int hour;
    private int minute;
    private int second;

    public Time(int hour)
    {
        this.hour = hour;
    }

    public Time(int hour, int minute)
    {
        this.hour= hour;
        this.minute= minute;
    }

    public Time(int hour, int minute, int second)
    {
        this.hour = hour;
        this.minute = minute;
        this.second = second;
    }

    public void ShowTime()
    {
        Console.WriteLine($"[{hour}시 {minute}분 {second}초]");
    }

    public void ShowTimeInSeconds()
    {
        Console.WriteLine($"{hour * 3600 + minute * 60 + second}초");
    }
}
