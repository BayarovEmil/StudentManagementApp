using StudentManagementApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApp.Repository.Concrete
{
    public class StudentRepository : IUserRepository<Student>
    {   
        private readonly List<Student> _students;
        public StudentRepository()
        {
            _students = new List<Student>();
        }

        public Student Add(Student user)
        {
            if (user == null) throw new ArgumentNullException();
            _students.Add(user);
            return user;
        }

        public bool Delete(int id)
        {
            var student = GetById(id);
            _students.Remove(student);
            return true;
        }

        public List<Student> GetAll()
        {
            return _students;
        }

        public Student GetById(int id)
        {
            var student = _students.FirstOrDefault(a => a.Id == id);
            if (student == null)
            {
                throw new KeyNotFoundException($"Student with ID {id} not found.");
            }
            return student;
        }

        public Student Update(int id, Student user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user), "Student cannot be null.");
            }

            var existingStudent = GetById(id);

            existingStudent.FirstName = user.FirstName;
            existingStudent.LastName = user.LastName;
            existingStudent.Email = user.Email;
            existingStudent.Gpa = user.Gpa;
            return existingStudent;
        }
    }
}
