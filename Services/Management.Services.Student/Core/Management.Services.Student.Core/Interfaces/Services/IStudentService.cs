using Management.Services.Student.Core.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Services.Student.Core.Interfaces.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<StudentResponse>> Get();
    }
}
