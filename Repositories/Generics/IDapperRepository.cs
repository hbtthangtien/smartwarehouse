using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Generics
{
    public interface IDapperRepository
    {
        Task<IEnumerable<T>> QueryAsync<T>(string sql, object? param = null, IDbTransaction? transaction = null);
        Task<T?> QueryFirstOrDefaultAsync<T>(string sql, object? param = null, IDbTransaction? transaction = null);
        Task<int> ExecuteAsync(string sql, object? param = null, IDbTransaction? transaction = null);
    }
}
