using StudentManagementApp.Business.Abstract;
using StudentManagementApp.Entity;
using StudentManagementApp.Repository;
using StudentManagementApp.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApp.Business.Concrete
{
    public class StudentService : IStudentService
    {
        private readonly IUserRepository<Student> _userRepository;
        public StudentService()
        {
            _userRepository = new StudentRepository();
        }

        public Student Add(Student student)
        {
            return _userRepository.Add(student);
        }

        public bool Delete(int id)
        {
            return (_userRepository.Delete(id));
        }

        public List<Student> GetAll()
        {
            return _userRepository.GetAll();
        }

        public Student GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public Student Update(int id, Student student)
        {
            return _userRepository.Update(id, student);
        }
    }
}
