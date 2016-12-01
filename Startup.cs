using System;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace HelloMvcApi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IFoo>((_)=>makeFoo());
        }

        public void Configure(IApplicationBuilder app, IFoo foo)
        {
        }

        public IFoo makeFoo()
        {
            throw new NotImplementedException();
        }
    }
    public interface IFoo {}
}
