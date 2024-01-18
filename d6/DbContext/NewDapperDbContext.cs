using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d6.DbContext
{
    internal class NewDapperDbContext
    {
        private readonly string _connectionString;
        public NewDapperDbContext(string configuration)
        {
            this._connectionString = configuration;
        }

        public T? QuerySingle<T>(SqlCommandModel model)
        {
            using IDbConnection connection = new SqlConnection(_connectionString);
            var parameters = new DynamicParameters();
            foreach (var item in model.CommandParameters)
                parameters.Add(item.ParameterName, item.Value, item.DataType);
            return connection.QuerySingle<T>(model.CommandText, parameters, commandType: model.CommandType);
        }

        public async Task<T?> QuerySingleAsync<T>(SqlCommandModel model)
        {
            using IDbConnection connection = new SqlConnection(_connectionString);
            var parameters = new DynamicParameters();
            foreach (var item in model.CommandParameters)
                parameters.Add(item.ParameterName, item.Value, item.DataType);
            return await connection.QuerySingleAsync<T>(model.CommandText, parameters, commandType: model.CommandType);
        }

        public IEnumerable<T> QueryAll<T>(SqlCommandModel model)
        {
            using IDbConnection connection = new SqlConnection(_connectionString);
            return connection.Query<T>(model.CommandText); 
        }

        public async Task<IEnumerable<T>> QueryAllAsync<T>(SqlCommandModel model)
        {
            using IDbConnection connection = new SqlConnection(_connectionString);
            return await connection.QueryAsync<T>(model.CommandText); ;
        }

        public void ExecuteNonQuery<T>(SqlCommandModel model)
        {
            var parameters = new DynamicParameters();
            foreach (var item in model.CommandParameters)
                parameters.Add(item.ParameterName, item.Value, item.DataType);
            using IDbConnection connection = new SqlConnection(_connectionString);
            connection.Execute(model.CommandText, parameters);
        }
    }
}
