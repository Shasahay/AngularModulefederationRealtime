using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Services.Student.Core.Interfaces.Infrastructures
{
    public interface IConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}
