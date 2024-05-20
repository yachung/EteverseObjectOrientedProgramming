using System;
class Rectangle
{
    private float row;
    private float col;

    public Rectangle(float row, float col)
    {
        this.row = row;
        this.col = col;
    }

    // 면적
    public float GetArea()
    {
        return row * col;
    }

    // 둘레
    public float GetSize()
    {
        return (row + col) * 2;
    }
}
