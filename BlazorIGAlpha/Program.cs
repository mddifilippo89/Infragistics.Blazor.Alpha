namespace BlazorIGAlpha {
    using System;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Hosting;

    public class Program {

        public static IHostBuilder CreateHostBuilder(String[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => {
                    webBuilder.UseStartup<Startup>();
                });

        public static void Main(String[] args) {
            CreateHostBuilder(args).Build().Run();
        }
    }
}
