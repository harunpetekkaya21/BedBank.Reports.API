using System.Data;
using System.Reflection;

namespace BedBankReports.API.Helpers
{
    public static class DatatableToGenericHelper
    {
        public static List<T> DataTableToEntityList<T>(DataTable dt)
        {
            

            foreach (DataColumn column in dt.Columns)
            {
                dt.Columns[column.ColumnName].ColumnName = column.ColumnName.Replace(" ", "").Replace("-", "").ToLower();
            }

            var list = new List<T>();
            var boolTypes = new List<Type>() { typeof(bool?), typeof(bool) };
            var boolValues = new List<string>() { "true", "yes", "1", "y" };
            var stringTypes = new List<Type>() { typeof(string) };
            var dateTypes = new List<Type>() { typeof(DateTime?), typeof(DateTime) };

            foreach (DataRow row in dt.Rows)
            {
                var EntityModel = (T)Activator.CreateInstance(typeof(T));
                foreach (var property in EntityModel.GetType().GetProperties())
                {
                    try
                    {
                        if (dt.Columns.Contains(property.Name.ToLower()))
                        {
                            var propValue = row[property.Name.ToLower()].ToString();

                            object value = null;
                            var memType = property.PropertyType;

                            if (boolTypes.Contains(memType))
                                value = boolValues.Contains(propValue.ToLower());
                            else if (stringTypes.Contains(memType))
                                value = string.IsNullOrWhiteSpace(propValue) ? null : propValue.Trim();
                            else if (dateTypes.Contains(memType))
                                value = string.IsNullOrWhiteSpace(propValue) ? (DateTime?)null : DateTime.Parse(propValue);

                            EntityModel.GetType().GetProperty(property.Name).SetValue(EntityModel, value);
                        }
                    }
                    catch (Exception ex)
                    {
                        
                        throw ex;
                    }
                }
                list.Add(EntityModel);
            }
            return list;
        }
    }
}
