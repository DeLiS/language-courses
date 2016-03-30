using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LanguageCourses.BusinessLayer.DomainObjects;

namespace LanguageCourses.BusinessLayer.Interfaces
{
    public interface IGroupService
    {
        Group FindGroupById(long id);
        List<Group> FindGroupsByTeacher(Teacher teacher, long offset, int count);
        Group FindGroupByStudent(Student student);
        List<Group> FindGroupsByLevel(string level, long offset, int count);
        bool AssignTeacherToGroup(Teacher teacher, Group group);
        bool AddStudentToTheGroup(Student student, Group group);
        bool RemoveTeacherFromGroup(Group group);
        bool RemoveStudentFromGroup(Student student, Group group);
        List<Student> GetStudentsOfGroup(Group group, long offset, int count);

    }
}
