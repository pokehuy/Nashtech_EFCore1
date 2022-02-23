using efcore.Models;

namespace efcore.Services
{
    public interface IStudentService
    {
        List<StudentModel> GetAll();
        StudentModel Get(int id);
        void Create(StudentModel student);
        void Update(int id, StudentModel student);
        void Delete(int id);
    }
}