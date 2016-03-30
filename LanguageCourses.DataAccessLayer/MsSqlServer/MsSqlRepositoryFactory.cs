using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LanguageCourses.DataAccessLayer.Interfaces;

namespace LanguageCourses.DataAccessLayer.MsSqlServer
{
    public class MsSqlRepositoryFactory : IRepositoryFactory
    {
        private readonly string _connectionString;

        public MsSqlRepositoryFactory(string connectionString)
        {
            if (connectionString == null)
            {
                throw new ArgumentNullException("connectionString");
            }

            _connectionString = connectionString;
        }

        public IStudentsRepository GetStudentsRepository()
        {
            return new MsSqlStudentsRepository(_connectionString);
        }
    }
}
