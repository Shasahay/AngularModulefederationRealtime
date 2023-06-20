using Management.Services.Student.Core.Models.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Services.Student.Core.Features.Queries
{
    public class GetStudentQuery : IRequest<IEnumerable<StudentResponse>>
    {
        int idd = 20;
       
    }
}
