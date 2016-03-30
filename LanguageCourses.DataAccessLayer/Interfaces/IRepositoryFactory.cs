namespace LanguageCourses.DataAccessLayer.Interfaces
{
    public interface IRepositoryFactory
    {
        IStudentsRepository GetStudentsRepository();
    }
}