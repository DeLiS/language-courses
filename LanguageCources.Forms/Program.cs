using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LanguageCources.Forms.Presenter;
using LanguageCourses.BusinessLayer.Version1;
using LanguageCourses.DataAccessLayer.MsSqlServer;
using LanguageCourses.Forms.Forms;

namespace LanguageCourses.Forms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = System.IO.Path.GetDirectoryName(executable);
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            

            var connectionString = ConfigurationManager.AppSettings["connectionString"];
            
            var msSqlRepositoryFactory = new MsSqlRepositoryFactory(connectionString);
            var serviceFactory = new ServiceFactory(msSqlRepositoryFactory);
            StudentsPresenter p = new StudentsPresenter(serviceFactory);

            StudentsForm f = new StudentsForm();
            p.Bind(f);
            Application.Run(f);
        }
    }
}
