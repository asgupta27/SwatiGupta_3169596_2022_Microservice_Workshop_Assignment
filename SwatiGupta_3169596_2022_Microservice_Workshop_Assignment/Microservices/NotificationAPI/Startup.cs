using EventBus.Message.Event;
using EventBus.Messages.Common;
using MassTransit;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotificationAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddAutoMapper(typeof(Startup));
            services.AddSingleton<IHostedService, ServiceDiscoveryHostedService>();
            var rabbitmaqAddress = Configuration["EventBus:HostAddress"];
            if (!string.IsNullOrWhiteSpace(rabbitmaqAddress))
            {
                var rabbitMQHostName = Configuration["RabbitMQHostName"];
                rabbitmaqAddress = rabbitmaqAddress.Replace("localhost", rabbitMQHostName);
            }
            services.AddMassTransit(config => {

                config.AddConsumer<BookingConfirmationEventConsumer>();

                config.UsingRabbitMq((ctx, cfg) => {
                    cfg.Host(rabbitmaqAddress);
                    cfg.UseHealthCheck(ctx);

                    cfg.ReceiveEndpoint(EventBusConstants.BookingConfirmationQueue, c => {
                        c.ConfigureConsumer<BookingConfirmationEventConsumer>(ctx);
                    });
                });
            });
            services.AddMassTransitHostedService();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "NotificationAPI", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "NotificationAPI v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
