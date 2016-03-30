using System;
using System.Collections.Generic;
using System.Linq;
using LanguageCourses.BusinessLayer.DomainObjects;
using LanguageCourses.BusinessLayer.Interfaces;
using LanguageCourses.DataAccessLayer.Interfaces;
using StudentDao = LanguageCourses.DataAccessLayer.DataAccessObjects.Student;
namespace LanguageCourses.BusinessLayer.Version1
{
    public class StudentsService : IStudentService
    {
        private readonly IRepositoryFactory _repositoryFactory;

        public StudentsService(IRepositoryFactory repositoryFactory)
        {
            if (repositoryFactory == null)
            {
                throw new ArgumentNullException("repositoryFactory");
            }

            _repositoryFactory = repositoryFactory;
        }

        public Student FindById(long id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Id should be positive. Received value: " + id);
            }

            using (IStudentsRepository studentsRepository = _repositoryFactory.GetStudentsRepository())
            {
                StudentDao studentDao = studentsRepository.FindStudentById(id);
                return new Student
                {
                    Id = studentDao.Id,
                    FirstName = studentDao.FirstName,
                    LastName = studentDao.LastName,
                    PhoneNumber = studentDao.PhoneNumber
                };  
            }
        }

        public IEnumerable<Student> GetStudents(long offset, int count)
        {
            if (offset < 0)
            {
                throw new ArgumentException("Offset should be non-negative. Received value: " + offset);
            }

            if (count < 0)
            {
                throw new ArgumentException("Count should be non-negative. Received value: " + count);
            }

            using (IStudentsRepository studentsRepository = _repositoryFactory.GetStudentsRepository())
            {
                IEnumerable<StudentDao> students = studentsRepository.GetStudents(offset, count);
                return students.Select(s => new Student
                {
                    Id = s.Id,
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    PhoneNumber = s.PhoneNumber
                });
            }

            
        }

        public IEnumerable<Student> FindByName(string firstName, string lastName, long offset, int count)
        {
            if (offset < 0)
            {
                throw new ArgumentException("Offset should be non-negative. Received value: " + offset);
            }

            if (count < 0)
            {
                throw new ArgumentException("Count should be non-negative. Received value: " + count);
            }

            using (IStudentsRepository studentsRepository = _repositoryFactory.GetStudentsRepository())
            {
                IEnumerable<StudentDao> studentDaos = studentsRepository.FindStudentsByName(firstName, lastName, offset,
                count);
                return studentDaos.Select(s => new Student
                {
                    Id = s.Id,
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    PhoneNumber = s.PhoneNumber
                });
            }
            
        }

        public long CreateNewStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("student", "Student to create should not be null.");
            }

            if (String.IsNullOrWhiteSpace(student.FirstName))
            {
                throw new ArgumentException("First name should not be empty.");
            }

            if (String.IsNullOrWhiteSpace(student.LastName))
            {
                throw new ArgumentException("Last name should not be empty");
            }

            using (IStudentsRepository studentsRepository = _repositoryFactory.GetStudentsRepository())
            {
                return studentsRepository.CreateStudent(new StudentDao
                {
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    PhoneNumber = student.PhoneNumber
                });
            }
        }

        public bool UpdateStudentData(Student updatedData)
        {
            if (updatedData == null)
            {
                throw new ArgumentNullException("updatedData", "Student to update should not be null.");
            }

            if (updatedData.Id == null)
            {
                throw new ArgumentException("Id of the student to update should be set.");
            }
            using (IStudentsRepository studentsRepository = _repositoryFactory.GetStudentsRepository())
            {
                return studentsRepository.UpdateStudent(new StudentDao
                {
                    Id = updatedData.Id,
                    FirstName = updatedData.FirstName,
                    LastName = updatedData.LastName,
                    PhoneNumber = updatedData.PhoneNumber
                });
            }
        }

        public bool RemoveStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("student", "Student to remove should not be null.");
            }

            if (student.Id == null)
            {
                throw new ArgumentException("Id of the student to remove should be set.");
            }

            using (IStudentsRepository studentsRepository = _repositoryFactory.GetStudentsRepository())
            {
                return studentsRepository.RemoveStudentById(student.Id.Value);
            }
        }
    }
}
