using System;
using System.Diagnostics;
using Uppgift_arv;
using Uppgift_Arv;


Console.WriteLine("Skriv ner nummer på vilken du vill ta reda på area och omkrets");
Console.WriteLine("1. Rektangl");
Console.WriteLine("2. Triangl");
Console.WriteLine("3. Circle");
Console.WriteLine("4. Shpere");
Console.WriteLine("5. Cylinder");
int val = int.Parse(Console.ReadLine());
IShape shape = null;

switch(val)
{
    case 1:
    {
        Console.WriteLine("Skriv höjd och bredd på var enda linje");
        shape = new Rectangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        break;
    }
    case 2:
    {
        Console.WriteLine("Skriv höjd och bredd på var enda linje");
        shape = new Triangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        break;
    }
    case 3:
    {
        Console.WriteLine("Skriv radien");
        shape = new Circle(int.Parse(Console.ReadLine()));
        break;
    }
    case 4:
    {
        
    }
    default:
    {
        Console.WriteLine("Välj mellan 1 eller 2");
        break;
    }
}
Console.WriteLine("Area är: " +shape.Area()+ ".");
Console.WriteLine("Omkrets är: " +shape.Circumferance()+ ".");