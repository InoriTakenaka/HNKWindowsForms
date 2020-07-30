using System;
using System.Data;
using System.Linq;
using System.Reflection;


namespace HNKCore {
    public abstract class Entity {
        public Entity() { }
        public Boolean LogicDelete { get; set; }
        public static bool TryConvertToEntity<T>(DataTable table, out T t, out string message) where T : new() {
            try {
                PropertyInfo[] fields = typeof(T).GetProperties();
                DataRow data = table.Rows[0];
                t = new T();
                for (int i = 0; i < table.Columns.Count; i++) {
                    object val = data[table.Columns[i]];
                    string field = table.Columns[i].ColumnName;
                    PropertyInfo property = fields.FirstOrDefault(p => p.Name == field);
                    if (property == null) continue;
                    else {

                        if (!property.PropertyType.IsGenericType) {
                            property.SetValue(t, val == DBNull.Value ?
                                null : Convert.ChangeType(val, property.PropertyType), null);
                        }
                        else {
                            Type genericTypeDefinition = property.PropertyType.GetGenericTypeDefinition();
                            if (genericTypeDefinition == typeof(Nullable<>))
                                property.SetValue(t, val == DBNull.Value ?
                                    null : Convert.ChangeType(val, property.PropertyType.GetGenericArguments()[0]), null);
                        }
                    }
                }
                message = "0";
                return true;
            }
            catch (Exception ex) {
                message = ex.Message;
                t = default(T);
                return false;
            }
        }
        public static bool TryConvertToDataTable<T>(out DataTable table, T t, out string message) {
            try {
                PropertyInfo[] fields = typeof(T).GetProperties();
                table = new DataTable();
                foreach (PropertyInfo p in fields) {
                    string colName = p.Name;
                    table.Columns.Add(new DataColumn(colName, p.PropertyType));
                }
                DataRow dataRow = table.NewRow();
                foreach (PropertyInfo p in fields) {
                    object val = p.GetValue(t, null);
                    dataRow[p.Name] = val;
                }
                message = "0";
                table.Rows.Add(dataRow);
                return true;
            }
            catch (Exception ex) {
                message = ex.Message;
                table = null;
                return false;
            }
        }
    }
}
