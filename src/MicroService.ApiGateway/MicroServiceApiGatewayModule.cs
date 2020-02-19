using MicroService.ApiGateway.HttpApi.Client;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Ocelot.Configuration.Repository;
using Ocelot.DependencyInjection;
using Ocelot.Extenssions;
using Ocelot.Provider.Polly;
using Serilog;
using Volo.Abp;
using Volo.Abp.AspNetCore;
using Volo.Abp.Autofac;
using Volo.Abp.AutoMapper;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;
using Yhd.Abp.EventBus.Cap;

namespace MicroService.ApiGateway
{
    [DependsOn(
        typeof(CapModule),
        typeof(AbpAutofacModule),
        typeof(AbpHttpClientIdentityModelModule),
        typeof(AbpAutoMapperModule),
        typeof(ApiGatewayHttpApiClientModule),
        typeof(AbpAspNetCoreModule)
        )]
    public class MicroServiceApiGatewayModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var hostingEnvironment = context.Services.GetHostingEnvironment();
            var configuration = context.Services.GetConfiguration();

            Log.Logger = new LoggerConfiguration()
               // .ReadFrom.Configuration(configuration)
               .WriteTo.Console()
               .CreateLogger();

            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddProfile<MicroServiceApiGatewayMapperProfile>();
            });

            // 不启用则使用本地配置文件的方式启动Ocelot
            // if (configuration.GetValue<bool>("EnabledDynamicOcelot"))
            {
                // context.Services.AddSingleton<IFileConfigurationRepository, ApiHttpClientFileConfigurationRepository>();
                ConfigureCAP(context, configuration);
            }

            context.Services
                .AddOcelot()
                .AddPolly();
        }

        private void ConfigureCAP(ServiceConfigurationContext context, IConfiguration configuration)
        {
            context.AddCapEventBus(capOptions =>
            {
                capOptions.UseInMemoryStorage();
                capOptions.UseRabbitMQ(cfg =>
                {
                    cfg.HostName = "localhost";configuration.GetValue<string>("CAP:RabbitMQ:Connect:Host");
                    cfg.VirtualHost = "/";//configuration.GetValue<string>("CAP:RabbitMQ:Connect:VirtualHost");
                    cfg.Port = 15672;//configuration.GetValue<int>("CAP:RabbitMQ:Connect:Port");
                    cfg.UserName = "guest";//configuration.GetValue<string>("CAP:RabbitMQ:Connect:UserName");
                    cfg.Password = "guest";configuration.GetValue<string>("CAP:RabbitMQ:Connect:Password");
                    // cfg.ExchangeName = configuration.GetValue<string>("CAP:RabbitMQ:Connect:ExchangeName");
                });

                capOptions.FailedRetryCount = 5;//UseRabbitMQ 服务器地址配置，支持配置IP地址和密码
                // capOptions.UseDashboard();//CAP2.X版本以后官方提供了Dashboard页面访问。
            });
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var app = context.GetApplicationBuilder();
            var env = context.GetEnvironment();

            app.UseAuditing();

            app.UseOcelot().Wait();
        }
    }
}
