using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;

namespace QLTV
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
                            result.AppendFormat("  {0} --> {1}{2}", s.MemberNames.FirstOrDefault(), s.ErrorMessage,
                                Environment.NewLine));
            }
            else
                result.AppendLine(messageEmptyCollection ?? string.Empty);

            return result.ToString();
        }
        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }
        public static DataTable SearchInAllColums(this DataTable table, string keyword, StringComparison comparison)
        {
            if (keyword.Equals(""))
            {
                return table;
            }
            DataRow[] filteredRows = table.Rows
                   .Cast<DataRow>()
                   .Where(r => r.ItemArray.Any(
                   c => c.ToString().IndexOf(keyword, comparison) >= 0))
                   .ToArray();

            if (filteredRows.Length == 0)
            {
                DataTable dtTemp = table.Clone();
                dtTemp.Clear();
                return dtTemp;
            }
            else
            {
                return filteredRows.CopyToDataTable();
            }
        }
    }

}
