using efcore.Models;
using efcore.Repository;

namespace efcore.Services
{
    public class StudentService : IStudentService
    {
        private IStudentRepository _istudentRepository;
        public StudentService(IStudentRepository istudentRepository)
        {
            _istudentRepository = istudentRepository;
        }

        public List<StudentModel> GetAll(){
            return _istudentRepository.GetAll();
        }
        public StudentModel Get(int id){
            return _istudentRepository.Get(id);
        }
        public void Create(StudentModel student){
            _istudentRepository.Create(student);
        }
        public void Update(int id, StudentModel student){
            _istudentRepository.Update(id, student);
        }
        public void Delete(int id){
            _istudentRepository.Delete(id);
        }
    }
}