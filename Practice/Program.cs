using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle(3f, 4f);    // 가로, 세로 길이 전달.
        Console.WriteLine($"면적: {rectangle.GetArea()}");
        Console.WriteLine($"둘레: {rectangle.GetSize()}");

        Circle circle = new Circle(5f);                 // 원의 반지름 전달.
        Console.WriteLine($"면적: {circle.GetArea()}");
        Console.WriteLine($"둘레: {circle.GetSize()}");
    }
}