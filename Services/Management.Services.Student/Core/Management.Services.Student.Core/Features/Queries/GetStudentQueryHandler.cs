using Management.Services.Student.Core.Interfaces.Services;
using Management.Services.Student.Core.Models.Responses;
using Management.Services.Student.Core.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Services.Student.Core.Features.Queries
{
    public class GetStudentQueryHandler : IRequestHandler<GetStudentQuery, IEnumerable<StudentResponse>>
    {
        private IStudentService _sudentService;
        public GetStudentQueryHandler(IStudentService sudentService) => this._sudentService = sudentService ?? throw new ArgumentNullException(nameof(StudentService));

        public async Task<IEnumerable<StudentResponse>>Handle(GetStudentQuery request, CancellationToken cancellationToken)   => await this._sudentService.Get();

    }


}
