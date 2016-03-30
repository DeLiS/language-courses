namespace LanguageCourses.BusinessLayer.Interfaces
{
    public interface IServiceFactory
    {
        IStudentService GetStudentService();
        ITeacherService GetTeacherService();
        IGroupService GetGroupService();
    }
}