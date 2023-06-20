using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Management.Services.Student.Domain.Entities;
using Entities = Management.Services.Student.Domain.Entities;
namespace Management.Services.Student.Core.Interfaces.Infrastructures
{
    public interface IStudentProvider : IBaseProvider<Entities.Student>
    {
        public IEnumerable<Entities.Student> GetStudent(string firstName);
        public IEnumerable<Entities.Student> GetInActiveStudent(string firstName);
    }
}
