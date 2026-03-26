using StudentRegister.Models;

namespace StudentRegister.NewFolder
{
    public interface IStudentService
    {
        void AddStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(int id);
        Student GetStudentById(int id);
        List<Student> GetAllStudent();
    }
}
