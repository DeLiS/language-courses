using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageCourses.BusinessLayer.DomainObjects
{
    public class Group
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
        public Teacher Teacher { get; set; }
    }
}
