#define C2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Contracts;
using Domain.Implementation;
using Facade.Contracts;
using Facade.Implementation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Models.Implementation;
using Repositories.Contracts;
using Repositories.Implementation;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Swagger;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Autofac.Core;
using Models.Contracts;
using Factory.Implementation;
using Factory.Contracts;
using Integrations.Implentation;
using Integrations.Contracts;
using Microsoft.AspNetCore.Http;

namespace PCShop
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<PcContext>(options => options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=PcDB;Trusted_Connection=True;ConnectRetryCount=0"));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
            });

#if C1
            return Config1(services);
#endif
#if C2
            return Config2(services);
#endif



        }

        private IServiceProvider Config1(IServiceCollection services)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ClientRepository>()
                .As<IClientRepository>();
            builder.RegisterType<OrderRepository>()
                .As<IOrderRepository>();
            builder.RegisterType<PcRepository>()
                .As<IPcRepository>();

            builder.RegisterType<TaxService>()
                .As<ITaxService>();
            builder.RegisterType<DeliveryService>()
                .As<IDeliveryService>();
            builder.RegisterType<OrderValidationService>()
                .As<IOrderValidationService>();

            builder.RegisterType<VIPClientFactory>()
                .As<IClientFactory>();
            builder.RegisterType<VIPOrderFactory>()
                .As<IOrderFactory>();
            builder.RegisterType<WindowsPcFactory>()
                .As<IPcFactory>();

            builder.RegisterType<EmailNotifier>()
                .As<INotifier>()
                .Keyed<INotifier>("email");
            builder.RegisterType<SMSNotifier>()
                .As<INotifier>()
                .Keyed<INotifier>("sms");

            builder.RegisterType<ClientFacade>()
                .WithParameter(new ResolvedParameter(
                    (pi, ctx) => pi.ParameterType == typeof(INotifier),
                    (pi, ctx) => ctx.ResolveKeyed<INotifier>("sms")))
                .As<IClientFacade>();
            builder.RegisterType<OrderFacade>()
                .WithParameter(new ResolvedParameter(
                    (pi, ctx) => pi.ParameterType == typeof(INotifier),
                    (pi, ctx) => ctx.ResolveKeyed<INotifier>("email")))
                .As<IOrderFacade>();
            builder.RegisterType<PcFacade>()
                .As<IPcFacade>();

            builder.Populate(services);
            var container = builder.Build();

            return new AutofacServiceProvider(container);
        }

        private IServiceProvider Config2(IServiceCollection services)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ClientRepository>()
                .As<IClientRepository>();
            builder.RegisterType<OrderRepository>()
                .As<IOrderRepository>();
            builder.RegisterType<PcRepository>()
                .As<IPcRepository>();

            builder.RegisterType<CheaperTaxService>()
                .As<ITaxService>();
            builder.RegisterType<FastDeliveryService>()
                .As<IDeliveryService>();
            builder.RegisterType<LoanOrderValidationService>()
                .As<IOrderValidationService>();

            builder.RegisterType<BasicClientFactory>()
                .As<IClientFactory>();
            builder.RegisterType<BasicOrderFactory>()
                .As<IOrderFactory>();
            builder.RegisterType<LinuxPcFactory>()
                .As<IPcFactory>();

            builder.RegisterType<EmailNotifier>()
                .As<INotifier>()
                .Keyed<INotifier>("email");
            builder.RegisterType<SMSNotifier>()
                .As<INotifier>()
                .Keyed<INotifier>("sms");

            builder.RegisterType<ClientFacade>()
                .WithParameter(new ResolvedParameter(
                    (pi, ctx) => pi.ParameterType == typeof(INotifier),
                    (pi, ctx) => ctx.ResolveKeyed<INotifier>("sms")))
                .As<IClientFacade>();
            builder.RegisterType<OrderFacade>()
                .WithParameter(new ResolvedParameter(
                    (pi, ctx) => pi.ParameterType == typeof(INotifier),
                    (pi, ctx) => ctx.ResolveKeyed<INotifier>("email")))
                .As<IOrderFacade>();
            builder.RegisterType<PcFacade>()
                .As<IPcFacade>();

            builder.Populate(services);
            var container = builder.Build();

            return new AutofacServiceProvider(container);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
