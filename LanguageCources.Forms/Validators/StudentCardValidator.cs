using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using LanguageCources.Forms.DataTransferObjects;

namespace LanguageCources.Forms.Validators
{
    public class StudentCardValidator : IValidator<StudentCard>
    {
        private const int DigitsInInternationalPhoneNumber = 12;

        public bool IsValid(StudentCard entity)
        {
            return !BrokenRules(entity).Any();
        }

        public IEnumerable<string> BrokenRules(StudentCard entity)
        {
            List<string> brokenRules = new List<string>();

            if (string.IsNullOrWhiteSpace(entity.FirstName))
            {
                brokenRules.Add("First name should not be empty.");
            }

            if (string.IsNullOrWhiteSpace(entity.LastName))
            {
                brokenRules.Add("Last name should not be null or empty");
            }
            string phoneNumber = entity.PhoneNumber
                .Replace(" ", string.Empty);

            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                return brokenRules;
            }

            if (phoneNumber[0] != '+' && !Char.IsDigit(phoneNumber[0]))
            {
                brokenRules.Add("Phone number can start only with + or a digit");
            }

            if (!Char.IsDigit(phoneNumber[phoneNumber.Length - 1]))
            {
                brokenRules.Add("Phone number can only end with a digit.");
            }

            phoneNumber = phoneNumber.Remove(0, 1);

            if (phoneNumber.Any(c => !(Char.IsDigit(c) || (c == '-'))))
            {
                brokenRules.Add("Wrong characters in the phone number. Should be only digits and - (can start with +)");
            }
            phoneNumber = phoneNumber.Where(Char.IsDigit).Aggregate("", (s, c) => s + c);

            if (phoneNumber.Length != DigitsInInternationalPhoneNumber)
            {
                brokenRules.Add("Nuber of digits is incorrect. Should be " + DigitsInInternationalPhoneNumber);
            }

            return brokenRules;
        }
    }
}
