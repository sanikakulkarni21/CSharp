
using System;

namespace LMS;

public class Students : Person {

    public List<courses> EnrolledCources {get; set;}

    public Students(int id, string name):base(id, name){
        EnrolledCources= new List<courses>();
    }

    public void EnrolledCources(Courses courses){
        EnrolledCources.Add(courses);
    }

    public void override DisplayInfo(){
        Console.WriteLine($"student Id : {id},Student Name : {name}");
        Console.WriteLine("Enrolled Courses");
    }
}