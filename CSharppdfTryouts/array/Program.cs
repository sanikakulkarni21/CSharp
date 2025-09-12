// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Arrays
//1.Declare
//int [] marks;
//2.Allocate
int [] books= new int [9];
//3.Initialize
int [] result=new int [] {1, 2, 3, 4, 5, 6, 7, 9};
int [] school={1,2,3,4,5,6,7,8,9};
//4.Access and assign
int[] marks = {1,2,3,4,5,6,7,8,9};
int[] Marks2 = new int[marks.Length];   // create a new array of same size

for (int i = 0; i < marks.Length; i++)
{
    Marks2[i] = marks[i];  // copy values one by one
}

//5.Enumerate
foreach (int i in marks)
{
    Console.WriteLine(i);
}