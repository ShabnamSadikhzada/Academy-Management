using AcademyManagement.BusinessLogic;
using AcademyManagement.Models;

namespace AcademyManagement;

public class Program
{
    static void Main(string[] args)
    {
        StudentServices studentServices = new StudentServices();
        Student st1 = new()
        {
            FirstName = "shabnam",
            LastName = "sadikhzada",
            Username = "shab",
            Password = "shab123"
        };

        Student st2 = new()
        {
            FirstName = "test",
            LastName = "test",
            Username = "test",
            Password = "test123"
        };

        //studentServices.CreateStudent(st1);
        //studentServices.CreateStudent(st2);

        //studentServices.UpdateStudent(2, "test1");
        studentServices.DeleteStudent(2);
    }
}
