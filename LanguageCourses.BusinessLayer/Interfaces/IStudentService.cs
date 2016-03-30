using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LanguageCourses.BusinessLayer.DomainObjects;

namespace LanguageCourses.BusinessLayer.Interfaces
{
    public interface IStudentService
    {
        Student FindById(long id);
        IEnumerable<Student> GetStudents(long offset, int count);
        IEnumerable<Student> FindByName(string firstName, string lastName, long offset, int count);
        long CreateNewStudent(Student student);
        bool UpdateStudentData(Student updatedData);
        bool RemoveStudent(Student student);
    }
}
