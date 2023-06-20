using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Services.Student.Infrastructure.Persistence.Queries
{
    public static class GetStudentsSqlQueries
    {
        public static readonly string _rawSqlQueryGetStudents = @"Select * from Student.Students";
    }
}
