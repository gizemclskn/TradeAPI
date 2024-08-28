using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TradeAPI.Persistence.Context;
using Microsoft.EntityFrameworkCore;



namespace TradeAPI.Persistence
{
    public static class Registration
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuretion ) 
        {
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(configuretion.GetConnectionString("DefultConnection")));
        }
    }
}
