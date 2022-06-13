using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace LibraryManagerBussiness
{

    public static class Extensions
    {
        public static IEnumerable<ValidationResult> ValidateObject(this object source)
        {
            ValidationContext valContext = new ValidationContext(source, null, null);
            var result = new List<ValidationResult>();
            Validator.TryValidateObject(source, valContext, result, true);

            return result;
        }

        public static string ToDescErrorsString(this IEnumerable<ValidationResult> source, string messageEmptyCollection = null)
        {
            StringBuilder result = new StringBuilder();

            if (source.Count() > 0)
            {
                source.ToList()
                    .ForEach(
                        s =>
                            result.AppendFormat("{1}{2}", s.MemberNames.FirstOrDefault(), s.ErrorMessage,
                                Environment.NewLine));
            }
            else
                result.AppendLine(messageEmptyCollection ?? string.Empty);

            return result.ToString();
        }
    }

}
