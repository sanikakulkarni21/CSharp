using System;



namespace testerapp
{

  

    class Program
    {

        private string programName;
        public void SetProgramName(string name)
        {
            this.programName = name;
        }

        public string GetProgramName()
        {
            return this.programName;
        }

        //property
        public string Name
        {
            get { return this.programName; }
            set { programName = value; }//value keyword is inbuilt provided by c#
        }



        public Program()
        {
            this.programName = "FirstProgram";
        }
        public Program(string name)
        {
            this.programName = name;
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Hello world" + args[i]);
            }
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to Dotnet Programming");
            int count = 45;

            count = count++;
            count = count + 1;



            if (count <= 300)
            {
                while (count < 299)
                {
                    Console.WriteLine("count={0}", count);
                    count++;
                }
            }
            Console.WriteLine("please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("good morning" + name);
            Console.WriteLine("Good Morning {0}", name);
            int result = Addition(10, 20);
            int result2 = multiplication(10, 20);

            Program theProgram = new Program();
            theProgram.SetProgramName("My First Program");
            Console.WriteLine("Program Title=" + theProgram.GetProgramName());
            theProgram.Display();

            Product theProduct1 = new Product(1, "Laptop", "Dell Laptop", 10, 50000);
            Product theProduct2=new Product(2, "Mobile", "Samsung Mobile", 20, 20000);

            Console.WriteLine(theProduct1);
             Console.WriteLine(theProduct2);
            Console.ReadLine();

        }

        static int Addition(int num1, int num2)
        {
            return num1 + num2;
        }

        static int multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

        public void Display()
        {
            Console.WriteLine("processing logic for display");
            Console.WriteLine("Program instanse Dashboard");
        }


    }
    

}
