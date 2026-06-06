using System;

// class Program
// {

//     public static void change( int a,  int b)
//     {
//         a = 100;
//         b = 200;
//     }
//     static void Main(string[] args)
//     {
//         int x=10;
//         int y=20;
//         change( x,  y);
//         Console.WriteLine($"x:{x}, y:{y}");

//     }
// }

//swaping 

// class Program {

//     public static void Swap (ref int a, ref int b)
//     {
//         int  temp=a;
//         a=b;
//         b=temp;
//     }
//     public static void Main (string [] args){
    
//         int x=10;
//         int y=20;
//         Swap(ref x, ref y);
//         Console.WriteLine($"X={x}, y={y}");

//     }
// }


//out keyword

class Program {

    public static void GetValues(out int a, out int b)
    {
        a = 100;
        b = 200;
    }
    public static void Main (string [] args){
    
        int x;
        int y;
        GetValues(out x, out y);
        Console.WriteLine($"X={x}, y={y}");

    }
}


