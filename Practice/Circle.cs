using System;
class Circle
{
    private float radius;

    public Circle(float radius)
    {
        this.radius = radius;
    }

    public float GetArea()
    {
        return radius * radius * MathF.PI;
    }

    public float GetSize()
    {
        return radius * MathF.PI * 2;
    }
}