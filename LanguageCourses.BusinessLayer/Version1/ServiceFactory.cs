using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LanguageCourses.BusinessLayer.Interfaces;
using LanguageCourses.DataAccessLayer.Interfaces;

namespace LanguageCourses.BusinessLayer.Version1
{
    public class ServiceFactory : IServiceFactory
    {
        private IRepositoryFactory _repositoryFactory;

        public ServiceFactory(IRepositoryFactory repositoryFactory)
        {
            if (repositoryFactory == null)
            {
                throw new ArgumentNullException("repositoryFactory");
            }

            _repositoryFactory = repositoryFactory;
        }

        public IStudentService GetStudentService()
        {
            return new StudentsService(_repositoryFactory);
        }

        public ITeacherService GetTeacherService()
        {
            throw new NotImplementedException();
        }

        public IGroupService GetGroupService()
        {
            throw new NotImplementedException();
        }
    }
}
