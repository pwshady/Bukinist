﻿using Bukinist.Data;
using Bukinist.Services;
using Bukinist.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Bukinist
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static IHost ?__Host;

        public static IHost Host => __Host 
            ??= Program.CreateHostBuilder(Environment.GetCommandLineArgs()).Build();

        public static IServiceProvider Services => Host.Services;
        internal static void ConfigureServices(HostBuilderContext host, IServiceCollection services) => services
            .AddDatabade(host.Configuration.GetSection("Database"))
            .AddServices()
            .AddViewModels()
            ;

        protected override async void OnStartup(StartupEventArgs e)
        {
            var host = Host;

            using (var scope = Services.CreateScope())
                await scope.ServiceProvider.GetRequiredService<DbInitializer>().InitializeAsync();
            

                base.OnStartup(e);
            await host.StartAsync();
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            using var host = Host;
            base.OnExit(e);
            await host.StopAsync();
        }
    }
}
