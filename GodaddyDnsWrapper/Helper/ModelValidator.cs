using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GodaddyDnsWrapper.Helper
{
    internal class ModelValidator
    {
        public static bool IsValid(object value, out List<ValidationResult> results)
        {
            ValidationContext context = new ValidationContext(value, null, null);
            results = new List<ValidationResult>();
            return Validator.TryValidateObject(value, context, results, true);
        }
    }
}
