using System.Collections.Generic;

namespace LanguageCources.Forms.Validators
{
    public interface IValidatable<T>
    {
        bool Validate(IValidator<T> validator, out IEnumerable<string> brokenRules);
    }
}