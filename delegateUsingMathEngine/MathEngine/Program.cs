
using Calculation;


// ### 3. Functional Requirements
// The application should:
// 1. Display a menu:
   
//    1. Addition
//    2. Subtraction
//    3. Multiplication
//    4. Division
//    5. Exit
   

// 2. Accept user input for:
//    * Choice of operation
//    * Two numeric values

// 3. Bind the selected method dynamically using delegate

// 4. Execute the operation and display result
// ---

// ## Expected Output Example


// ===== Math Engine =====

// Enter first number: 10
// Enter second number: 5

// Choose Operation:
// 1. Addition
// 2. Subtraction
// 3. Multiplication
// 4. Division

// Enter choice: 1

// Result: 15

class Program
{
    static void Main(string[] args)
    {

        





       MathEngine mathengine = new MathEngine();
      
       bool exit = false;
       while(!exit){
       Console.WriteLine("=======Calculation=====");
       Console.WriteLine("Enter First Number:");
       double num1= Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter Second Number");
        double num2=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Choose Operation");
        Console.WriteLine("1.Addition");
        Console.WriteLine("2.Subtraction");
        Console.WriteLine("3.Multiplication");
        Console.WriteLine("4.Division");
        Console.WriteLine("5.Exit");

     
        Console.WriteLine("Enter Choice:");
         MathOperation operation = null;

       int choice= Convert.ToInt32(Console.ReadLine());
       switch(choice){
           case 1:
            operation = mathengine.Add;
            break;

            case 2:
            operation = mathengine.Subtract;
            break;
             
            case 3:
            operation = mathengine.Multiply;
            break;

            case 4:
            operation = mathengine.Divide;
            break;

            case 5:
            Environment.Exit(0);
            break;
        }

        if (operation != null)
        {
            double result = operation(num1, num2);
            Console.WriteLine($"Result: {result}");
        }
    }
}
}


