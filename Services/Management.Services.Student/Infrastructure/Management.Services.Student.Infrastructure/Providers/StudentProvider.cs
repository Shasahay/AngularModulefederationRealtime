using Management.Services.Student.Core.Interfaces.Infrastructures;
using Management.Services.Student.Infrastructure.Persistence.Queries;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities = Management.Services.Student.Domain.Entities;

namespace Management.Services.Student.Infrastructure.Providers
{
    public class StudentProvider : BaseProvider<Entities.Student>, IStudentProvider
    {
        /// <summary>
        /// private readonly IConfiguration _configuration;
        /// </summary>
        private readonly IConnectionFactory _connectionFactory;
        public StudentProvider(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
           // _configuration = configuration;
            _connectionFactory = connectionFactory;
        }

        public Task<Entities.Student> Add()
        {
            throw new NotImplementedException();
        }

        public Task<Entities.Student> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Entities.Student> Delete(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Entities.Student>> Get()  =>  await this.ExecuteQueryForEntities(GetStudentsSqlQueries._rawSqlQueryGetStudents);
        

        public Task<Entities.Student> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Entities.Student> Get(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Entities.Student> GetInActiveStudent(string firstName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Entities.Student> GetStudent(string firstName)
        {
            throw new NotImplementedException();
        }

        public Task<Entities.Student> Update(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Entities.Student> Update(string id)
        {
            throw new NotImplementedException();
        }
    }
}
