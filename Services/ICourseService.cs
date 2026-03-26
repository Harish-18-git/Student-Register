using StudentRegister.Models;

namespace StudentRegister.NewFolder
{
    public interface ICourseService
    {
        List<Course> GetAllCourses();
        Course GetCourseByFName(string name);
    }
}
