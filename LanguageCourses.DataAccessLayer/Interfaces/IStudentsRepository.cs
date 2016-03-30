using System;
using System.Collections.Generic;
using LanguageCourses.DataAccessLayer.DataAccessObjects;

namespace LanguageCourses.DataAccessLayer.Interfaces
{
    public interface IStudentsRepository : IDisposable
    {
        Student FindStudentById(long id);
        bool RemoveStudentById(long id);
        long CreateStudent(Student person);
        bool UpdateStudent(Student updatedStudent);
        IEnumerable<Student> FindStudentsByName(string firstName, string lastName, long offset, int count);
        IEnumerable<Student> GetStudents(long offset, int count);
    }
}
