using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesterApp
{
    internal class Program
    {

        private Program()
        {
            this.programName = FirstProgram;
        } 

    
        
       /* public void SetProgramName(string name)//old style
        {
            this.programName = name;
        }
        public string GetProgramName()//old style
        {
            return this.programName;
        }
        public string Name //old style
        {
            get { return programName; }
            set { name=value; }
        }*/
        public string Name1 { get; set; } //  new style auto implemented property

        public Program()
        {

        }
        public Program(string name)
        {
            this.programName = name;
         }



        static void Main(string[] args)
        {

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("hello " + args[i]);
            }

            Console.WriteLine("welcome to dotnet programming");
            int count = 45;
            count = count++;
            if (count <= 300)
            {
                while (count < 299)
                {
                    Console.WriteLine("count={0}", count);
                    count++;
                }
            }
            Console.WriteLine("enter your name");

            String name = Console.ReadLine();
            Console.WriteLine("godmorning{0}", name);



            var marks = 456;  //dynamic type

            int result = Addition(23, 45);
            int result1 = Subtraction(45, 23);
            int result2 = Multiplication(23, 45);

            Program theProgram = new Program();
            theProgram.Display();


            Console.ReadLine();

        }

         int Addition(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }
        static int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

        //Member function method
        public void Display()
        {
            Console.WriteLine("processing logic for display");
            Console.WriteLine("program instance Dashboard");
        }


    }
}
