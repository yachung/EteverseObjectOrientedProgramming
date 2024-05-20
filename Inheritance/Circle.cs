using System;

class Point
{
    protected float x;
    protected float y;
}

class Circle : Point
{
    private float radius;

    public Circle(float x, float y, float radius)
    {
        this.x = x;
        this.y = y;
        this.radius = radius;
    }

    public void ShowData()
    {
        Console.WriteLine($"중심 좌표: [{x}, {y}]");
        Console.WriteLine($"반지름: {radius}");
        Console.WriteLine($"원의 넓이: {MathF.PI * radius * radius}");
    }
}
