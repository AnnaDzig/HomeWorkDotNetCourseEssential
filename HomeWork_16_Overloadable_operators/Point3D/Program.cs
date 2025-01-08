// створіть проект за шаблоном Console Application.
// Створіть структуру, яка описує точку у тривимірній системі
// координат. Організуйте можливість складання двох точок через
// використання навантаження оператора +.


struct Point3D
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public Point3D(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public static Point3D operator +(Point3D p1, Point3D p2)
    {
        return new Point3D(p1.X + p2.X, p1.Y + p2.Y, p1.Z + p2.Z);
    }

    public override string ToString()
    {
        return $"Point({X}, {Y}, {Z})";
    }
}

class Program
{
    static void Main()
    {
        Point3D point1 = new Point3D(1, 2, 3);
        Point3D point2 = new Point3D(4, 5, 6);

        Point3D result = point1 + point2;

        Console.WriteLine($"Point 1: {point1}");
        Console.WriteLine($"Point 2: {point2}");
        Console.WriteLine($"Result of addition: {result}");
    }
}