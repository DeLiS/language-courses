using LanguageCourses.BusinessLayer.DomainObjects;

namespace LanguageCourses.BusinessLayer.Interfaces
{
    public interface ITeacherService
    {
        Teacher FindById(long id);
        Teacher FindByStudent(Student student);
        long CreateTeacher(Teacher teacher);
        bool UpdateTeacher(Teacher teacher);
        bool DeleteTeacher(Teacher teacher);
    }
}