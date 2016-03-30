using System.Collections.Generic;

namespace LanguageCources.Forms.Validators
{
    public interface IValidator<T>
    {
        bool IsValid(T entity);
        IEnumerable<string> BrokenRules(T entity);
    }
}