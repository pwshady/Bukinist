using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace Bukinist
{
    class Program
    {
        [STAThread]
        static void Main(string[] Args) 
        { 
        
            var app = new App();
            app.InitializeComponent();
            app.Run();
        
        }

        public static IHostBuilder CreateHostBuilder(string[] Args) => Host.CreateDefaultBuilder(Args).ConfigureServices(App.ConfigureServices);
    }
}
