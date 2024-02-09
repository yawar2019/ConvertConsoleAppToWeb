// See https://aka.ms/new-console-template for more information
using ConvertConsoleAppToWeb;

Console.WriteLine("Hello, World!");

CreateHostBuilder(args).Build().Run();

static IHostBuilder CreateHostBuilder(string[] args) =>
           Host.CreateDefaultBuilder(args)
               .ConfigureWebHostDefaults(webBuilder =>
               {
                   webBuilder.UseStartup<Startup>();
               });