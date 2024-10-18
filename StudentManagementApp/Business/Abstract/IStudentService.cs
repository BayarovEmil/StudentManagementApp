using StudentManagementApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApp.Business.Abstract
{
    public interface IStudentService
    {
        Student Add(Student student);
        Student Update(int id, Student student);
        bool Delete(int id);
        Student GetById(int id);
        List<Student> GetAll();
    }
}
