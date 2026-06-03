using System;

// int count=0;
// count++;
// Console.WriteLine(count);

// DateTime date=DateTime.Now;
// Console.WriteLine(date);

// Console.WriteLine("Hello, World!");



// using Maths;


// class Program
// {
//     static void Main(string[] args)
//     {
//         MathEngine mathEngine1 = new MathEngine();
//         MathEngine mathEngine2 = new MathEngine();
//         MathEngine mathEngine3 = new MathEngine();
//         MathEngine mathEngine4 = new MathEngine();
//         MathEngine mathEngine5 = new MathEngine();
        
//         double a = 10;
//         double b = 5;


//         Console.WriteLine($"MathEngine count: {MathEngine.count}");
        
//         Console.WriteLine($"Addition: {mathEngine1.Add(a, b)}");
//         Console.WriteLine($"Subtraction: {mathEngine2.Subtract(a, b)}");
//         Console.WriteLine($"Multiplication: {mathEngine3.Multiply(a, b)}");
//         Console.WriteLine($"Division: {mathEngine4.Divide(a, b)}");
//     }
// }


// int[] marks =new int[]{90,80,70};
//  foreach (int mark in marks)
//  {
//     Console.WriteLine(mark);
//  }

//  static void ViewNames(params string[] names)
//  {
//     foreach(var name in names)
//     Console.WriteLine(name);
//  } 

//  ViewNames("sanika");
//  Console.WriteLine();



enum WeekDays
{
    Mon,
    Tue,
    Wed
}

class Program
{
    static void Main()
    {
        WeekDays day = WeekDays.Mon;
        Console.WriteLine(day);
    }
}


