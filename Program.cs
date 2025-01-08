using System;

// 1
//struct Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//}

// 2
//struct Point
//{
//    public double X { get; set; }
//    public double Y { get; set; }

//    public static double CalculateDistance(Point p1, Point p2)
//    {
//        return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
//    }
//}

// 3
//struct Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//}

// 4
//struct Rectangle
//{
//    private double width;
//    private double height;

//    public double Width
//    {
//        set
//        {
//            if (value >= 0)
//                width = value;
//            else
//                Console.WriteLine("Width cannot be negative.");
//        }
//        get { return width; }
//    }

//    public double Height
//    {
//        set
//        {
//            if (value >= 0)
//                height = value;
//            else
//                Console.WriteLine("Height cannot be negative.");
//        }
//        get { return height; }
//    }

//    public double Area
//    {
//        get { return width * height; }
//    }

//    public void Display()
//    {
//        Console.WriteLine($"Rectangle : Width = {width}, Height = {height}");
//        Console.WriteLine($"Area: {Area}");
//    }
//}
class Program
    {
        static void Main(string[] args)
        {
        #region 1-Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
        //Person[] persons = new Person[3];
        //persons[0] = new Person { Name = "Ahmed", Age = 20 };
        //persons[1] = new Person { Name = "Khaled", Age = 25 };
        //persons[2] = new Person { Name = "Malak", Age = 20 };

        //Console.WriteLine("Persons:");
        //foreach (var person in persons)
        //{
        //    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        //}
        #endregion

        #region 2-Create a struct called "Point" to represent a 2D point with properties "X" and   "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
        //Console.WriteLine("Enter coordinates for Point 1 (X Y):");
        //string[] input1 = Console.ReadLine().Split();
        //Point p1 = new Point { X = double.Parse(input1[0]), Y = double.Parse(input1[1]) };

        //Console.WriteLine("Enter coordinates for Point 2 (X Y):");
        //string[] input2 = Console.ReadLine().Split();
        //Point p2 = new Point { X = double.Parse(input2[0]), Y = double.Parse(input2[1]) };

        //double distance = Point.CalculateDistance(p1, p2);
        //Console.WriteLine($"Distance between the two points: {distance:F2}");
        #endregion

        #region 3-Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
        //Person[] persons = new Person[3];
        //for (int i = 0; i < 3; i++)
        //{
        //    Console.WriteLine($"Enter details of Person {i + 1}:");
        //    Console.Write("Name: ");
        //    string name = Console.ReadLine();
        //    Console.Write("Age: ");
        //    int age = int.Parse(Console.ReadLine());

        //    persons[i] = new Person { Name = name, Age = age };
        //}
        //var oldest = persons.OrderByDescending(p => p.Age).First();

        //Console.WriteLine($"The oldest person is {oldest.Name} with age {oldest.Age}.");
        #endregion

        #region 4-.Create a struct named Rectangle that represents a rectangle with the following fields: width(type: double) height(type: double)
        //Rectangle r = new Rectangle();

        //Console.Write("Enter Width: ");
        //r.Width = double.Parse(Console.ReadLine());

        //Console.Write("Enter Height: ");
        //r.Height = double.Parse(Console.ReadLine());

        //r.Display();
        #endregion
    }
}

