using System;
namespace MyApp{

    public class Employee{
        public int Id {get; set;}
         public string Name {get; set;}
         

         //to access the property of date
         public Date DateOfJoin{get; set;}
         public Date DateOfLeave{ get; set;}

         public Employee(int id , string name , Date Doj , Date Dol )
         {
            Id = id;
            Name=name;
            DateOfJoin=Doj;
            DateOfLeave=Dol;

         }

         public override string ToString()
         {
            return $"Employee Id: {Id} \n" + $"Name: {Name} \n" + $"Doj: {DateOfJoin} \n" + $"Dol:{DateOfLeave}\n";
         }


    }
}
