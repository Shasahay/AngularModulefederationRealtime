using Autofac;
using Autofac.Core;
using AutoMapper;
using Management.Services.Student.Core.Interfaces.Infrastructures;
using Management.Services.Student.Core.Interfaces.Services;
using Management.Services.Student.Core.Services;
using Management.Services.Student.Infrastructure.Persistence;
using Management.Services.Student.Infrastructure.Providers;

namespace Management.Services.Student.API
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterInstance(new AutoMapperConfiguration().Configure()).As<IMapper>();
            builder.RegisterType<PostgressConnectionFactory>().As<IConnectionFactory>();
            //builder.Register(r => new StudentProvider(r.Resolve<PostgressConnectionFactory>())).As<IStudentProvider>().InstancePerLifetimeScope();
            //builder.Register(r => new StudentProvider(r.Resolve<PostgressConnectionFactory>())).As<IStudentProvider>().InstancePerLifetimeScope();
            builder.RegisterType<StudentProvider>().As<IStudentProvider>().InstancePerLifetimeScope();
            builder.RegisterType<StudentService>().As<IStudentService>().InstancePerLifetimeScope();
            base.Load(builder);

        }
    }
}
