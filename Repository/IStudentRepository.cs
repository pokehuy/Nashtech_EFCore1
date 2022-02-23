using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using efcore.Models;

namespace efcore.Repository
{
    public interface IStudentRepository
    {
        List<StudentModel> GetAll();
        StudentModel Get(int id);
        void Create(StudentModel student);
        void Update(int id, StudentModel student);
        void Delete(int id);
    }
}