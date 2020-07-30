using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace HNKCore
{
    public interface IDataSource{
        int Insert<E>(E e, string Identity) where E : Entity, new();
        int Insert<E>(List<E> EntityCollection) where E : Entity, new();
        List<E> Select<E>(string querySQL) where E : Entity, new();
        E Find<E>(string querySQL) where E : Entity, new();
        int Update<E>(string condition, E e, string key) where E : Entity, new();
        Boolean Exist(string fieldName, string fieldValue, string tableName);
        int ExcuteSqlNonQuery(string commandText);
        System.Data.DataTable ExcuteDataTable(string commandText);
    }
}
