using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageCourses.DataAccessLayer.DataAccessObjects
{
    public class Group
    {
        public long GroupId { get; set; }
        public long TeacherId { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }

    }
}
