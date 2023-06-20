using Dapper;
using Management.Services.Student.Core.Interfaces.Infrastructures;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Services.Student.Infrastructure.Providers
{
    public class BaseProvider<TEntity> where TEntity : class
    {
        protected readonly IDbConnection _connection;
       // private readonly IConfiguration _configuration;
        private readonly IConnectionFactory _connectionFactory;
        public BaseProvider(IConnectionFactory connectionFactory)
        {
           // this._configuration = configuration;
            this._connectionFactory = connectionFactory;
            this._connection = connectionFactory.CreateConnection();
        }

        protected async Task<TEntity> ExecuteQueryForEntity(string query)    => await this._connection.QueryFirstOrDefaultAsync<TEntity>(query);
        
        protected async Task<TEntity> ExecuteQueryForEntity(string query, string param)  =>   await this._connection.QueryFirstOrDefaultAsync<TEntity>(query, param);

        protected async Task<IEnumerable<TEntity>> ExecuteQueryForEntities(string sql) => await this._connection.QueryAsync<TEntity>(sql);
        protected async Task<IEnumerable<TEntity>> ExecuteQueryForEntities(string sql, string param) => await this._connection.QueryAsync<TEntity>(sql, param);

        protected async Task<TType> ExecuteQueryForOtherEntity<TType>(string query) where TType : class => await this._connection.QueryFirstOrDefaultAsync<TType>(query);
        protected async Task<TType> ExecuteQueryForOtherEntity<TType>(string query, string param) where TType : class => await this._connection.QueryFirstOrDefaultAsync<TType>(query, param);

        protected async Task<IEnumerable<TType>> ExecuteQueryForOtherEntities<TType>(string sql) => await this._connection.QueryAsync<TType>(sql);
        protected async Task<IEnumerable<TType>> ExecuteQueryForOtherEntities<TType>(string sql, string param) => await this._connection.QueryAsync<TType>(sql, param);
    }
}
