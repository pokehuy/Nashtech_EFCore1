using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using efcore.Models;

namespace efcore.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private StudentDbContext _studentDbContext;

        public StudentRepository(StudentDbContext studentDbContext)
        {
            _studentDbContext = studentDbContext;
        }

        public List<StudentModel> GetAll(){
            return _studentDbContext.Students.ToList();
        }
        public StudentModel Get(int id){
            return _studentDbContext.Students.FirstOrDefault(s => s.StudentId == id);
        }
        public void Create(StudentModel student){
            _studentDbContext.Students.Add(student);
            _studentDbContext.SaveChanges();
        }
        public void Update(int id, StudentModel student){
            var std = _studentDbContext.Students.FirstOrDefault(s => s.StudentId == id);
            if(std != null){
                std.FirstName = student.FirstName;
                std.LastName = student.LastName;
                std.City = student.City;
                std.State = student.State;
                _studentDbContext.SaveChanges();
            }
        }
        public void Delete(int id){
            var std = _studentDbContext.Students.FirstOrDefault(s => s.StudentId == id);
            if(std != null){
                _studentDbContext.Students.Remove(std);
                _studentDbContext.SaveChanges();
            }
        }
    }
}