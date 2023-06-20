using Management.Services.Student.Core.Interfaces.Infrastructures;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Services.Student.Infrastructure.Persistence
{
    public class PostgressConnectionFactory : IConnectionFactory
    {
        public readonly IConfiguration _configuration;

        public PostgressConnectionFactory(IConfiguration configuration) => _configuration = configuration;

        public IDbConnection CreateConnection()
        {
            //return new NpgsqlConnection(_configuration.GetConnectionString("ManagementConnection"));
            var connString = "Host=localhost;Port=5432;Database=Management;Username=**&&**;Password=****";
            return new NpgsqlConnection(connString);
        }
    }
}
