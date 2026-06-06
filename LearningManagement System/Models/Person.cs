
using system;

namespace LMS;

public abstract class Person {

    public int Id {get; set;}
    public string Name {get; set;}

    protected person(){

    } 

    protected person (int id, string name){
       id = Id;
       name= Name;
    }

    public abstract DisplayInfo();


}