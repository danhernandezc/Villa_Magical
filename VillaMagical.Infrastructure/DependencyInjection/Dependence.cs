using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Mail;
using VillaMagical.Infrastructure.Persistence;

namespace VillaMagical.Infrastructure.DependencyInjection
{
    public static class Dependence
    {
        public static void InjectDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            // Registrar DbContext
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("ServerConnection")));

            //services.AddScoped<IMailHelper, MailHelper>();
            //services.AddScoped<IsmtpClient, SmtpClientWrapper>();

            //services.AddScoped<IIEmailUnitOfWork, IEmailUnitOfWork>();
            //services.AddScoped<IEmailService, EmailService>();

            //services.AddScoped<IBlacklistEmailDomainUnitOfWork, BlacklistEmailDomainUnitOfWork>();
            //services.AddScoped<IBlacklistEmailDomainRepository, BlacklistEmailDomainRepository>();

            //services.AddScoped<ITokenUnitOfWork, TokenUnitOfWork>();
            //services.AddScoped<ITokenService, TokenService>();

            //services.AddScoped<ICountryCodeUnitOfWork, CountryCodeUnitOfWork>();
            //services.AddScoped<ICountryCodeRepository, CountryCodeRepository>();

            //services.AddScoped<Iexternal_PartnerUnitOfWork, External_PartnerUnitOfwork>();
            //services.AddScoped<Iexternal_PartnerRepository, external_PartnerRepository>();

            //services.AddScoped<IUsersUnitOfWork, UsersUnitOfWork>();
            //services.AddScoped<IUsersRepository, UsersRepository>();
        }
    }
}
