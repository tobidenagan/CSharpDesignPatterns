using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CSharpDesignPatterns.DesignPatterns
{
    public static class Configure
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IUserNotifier>((serviceProvider) =>
            {
                var configuration = serviceProvider.GetService<IConfiguration>();
                bool useTestUserNotifier = configuration?.GetSection("UseTestUserNotifier").Value
                    .ToLower() == "true";
                if (useTestUserNotifier)
                    return new TestUserNotifier();
                return new EmailUserNotifier();
            });
        }
    }
}
