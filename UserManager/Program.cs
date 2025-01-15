using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using UserManager.DataAccess;
using UserManager.DataAccess.Repositories;
using UserManager.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserManager.Forms;

namespace UserManager;

static class Program
{
    [STAThread]

    static void Main()
    {
        var services = ConfigureServices();
        var serviceProvider = services.BuildServiceProvider();
        
        ApplicationConfiguration.Initialize();
        var loginForm = serviceProvider.GetRequiredService<LoginForm>();
        Application.Run(loginForm);
    }

    private static IServiceCollection ConfigureServices()
    {
        // Настройка конфигурации
        var configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory) // Указываем путь к корню проекта
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        // Настройка DI и контекста базы данных
        var services = new ServiceCollection();
        services.AddDbContext<DatabaseContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        // Репозитории
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IRoleRepository, RoleRepository>();
        services.AddScoped<IUserProfileRepository, UserProfileRepository>();
        services.AddScoped<ISubscriptionRepository, SubscriptionRepository>();
        services.AddScoped<IRecordRepository, RecordRepository>();
        services.AddScoped<IPermissionRepository, PermissionRepository>();
        services.AddScoped<IHostingPlanRepository, HostingPlanRepository>();
        services.AddScoped<IActivityLogRepository, ActivityLogRepository>();

        // Сервисы
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IUserProfileService, UserProfileService>();
        services.AddScoped<ISubscriptionService, SubscriptionService>();
        services.AddScoped<IRecordService, RecordService>();
        services.AddScoped<IPermissionService, PermissionService>();
        services.AddScoped<IHostingPlanService, HostingPlanService>();
        services.AddScoped<IActivityLogService, ActivityLogService>();
        services.AddScoped<IRoleService, RoleService>();
        services.AddScoped<ISessionService, SessionService>();
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        services.AddScoped<IPasswordHasher, PasswordHasher>();

        services.AddScoped<LoginForm>();
        services.AddScoped<RegisterForm>();
        services.AddScoped<ChangePasswordForm>();
        services.AddScoped<UserDialogForm>();
        // Запуск приложения
        
        return services;
    }

}