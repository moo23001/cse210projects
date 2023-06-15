using System;

class Program
{
    static void Main(string[] args)
    {
        Square s1 = new Square("blue", 2);

        Rectangle r1 = new Rectangle("pink", 2, 3);

        Circle c1 = new Circle("white", 2);

        List<Shape> sList = new List<Shape>();
        sList.Add(s1);
        sList.Add(r1);
        sList.Add(c1);
        foreach (Shape s in sList){
            Console.WriteLine(s.GetColor());
            Console.WriteLine(s.GetArea());
        }

    }
    
    
}