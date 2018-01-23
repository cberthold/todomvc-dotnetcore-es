using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using TodoMVC.Domain.Infrastructure.EventStore;

namespace TodoMVC.Modules
{
    public class DomainModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<InMemoryEventStore>()
                .AsImplementedInterfaces()
                .SingleInstance();
        }
    }
}
