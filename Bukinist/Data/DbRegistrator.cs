using Bukinist.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bukinist.Data
{
    static class DbRegistrator
    {

        public static IServiceCollection AddDatabade(this IServiceCollection services, IConfiguration configuration) => services
            .AddDbContext<BukinistDB>(options =>
            {
                var type = configuration["Type"];

                switch (type)
                {
                    case "MSSQL":
                        options.UseSqlServer(configuration.GetConnectionString(type));
                        break;

                    case "SQLite":
                        options.UseSqlite(configuration.GetConnectionString(type));
                        break;

                    case "InMemory":
                        options.UseInMemoryDatabase("Bookinist.db");
                        break;

                    case null:
                        throw new InvalidOperationException("Не определён тип БД");

                    default:
                        throw new InvalidOperationException($"Тип подключения {type} не поддерживается");
                }
            })
            ;

    }
}
