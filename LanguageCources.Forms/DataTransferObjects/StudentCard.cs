using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LanguageCources.Forms.Validators;

namespace LanguageCources.Forms.DataTransferObjects
{
    public class StudentCard : IValidatable<StudentCard>, ICloneable
    {
        public Guid ViewId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public Guid GroupId { get; set; }

        public StudentCard()
        {
            ViewId = Guid.NewGuid();
            GroupId = Guid.NewGuid();
        }

        public bool Validate(IValidator<StudentCard> validator, out IEnumerable<string> brokenRules)
        {
            brokenRules = validator.BrokenRules(this);
            return validator.IsValid(this);
        }

        public object Clone()
        {
            return new StudentCard
            {
                ViewId = this.ViewId,
                FirstName = this.FirstName,
                LastName = this.LastName,
                PhoneNumber = this.PhoneNumber,
                GroupId = this.GroupId
            };
        }
    }
}
