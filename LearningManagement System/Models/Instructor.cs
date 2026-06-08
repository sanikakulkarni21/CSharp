
namespace LMS;

class Instructor : Person {
    public List<courses> AssignedCourses{get; set;}



    public  Instructor(int id, string name):base(id, name){
        AssignedCourses= new List<courses>();
    }

    public void AssignCourse(Courses courses){
        AssignedCourses.Add(courses);
    }

    public void override DisplayInfo(){
        C
    }
}