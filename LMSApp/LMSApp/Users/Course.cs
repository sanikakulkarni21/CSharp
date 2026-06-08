namespace LMSApp.Users;

public class Course
{
    public int CourseId { get; set; }

    public string CourseName { get; set; }

    public string Duration { get; set; }

    public Instructor? AssignedInstructor { get; set; }

    public Course(int id, string name)
    {
        CourseId = id;
        CourseName = name;
        Duration = string.Empty;
    }

    public Course(int id, string name, string duration)
    {
        CourseId = id;
        CourseName = name;
        Duration = duration;
    }
}