using AutoMapper;
using Management.Services.Student.Core.Interfaces.Infrastructures;
using Management.Services.Student.Core.Interfaces.Services;
using Management.Services.Student.Core.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Services.Student.Core.Services
{
    public class StudentService : BaseService, IStudentService
    {
        private readonly IStudentProvider _studentProvider;

        public StudentService(IMapper mapper, IStudentProvider studentProvider) : base(mapper)  =>  _studentProvider = studentProvider ?? throw new ArgumentNullException(nameof(studentProvider));

        public async Task<IEnumerable<StudentResponse>> Get()   =>  this._mapper.Map<IEnumerable<StudentResponse>>(await this._studentProvider.Get());
        
    }
}
