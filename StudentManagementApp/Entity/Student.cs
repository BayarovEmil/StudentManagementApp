using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApp.Entity
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public double Gpa { get; set; }

        public Student() { }
        public Student(int id, string firstName, string lastName, string email, double gpa)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Gpa = gpa;
        }
    }
}
