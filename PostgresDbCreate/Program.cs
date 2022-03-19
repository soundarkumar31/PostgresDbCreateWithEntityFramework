using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PostgresDbCreate.Migrations;
using System;

namespace PostgresDbCreate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var services = new ServiceCollection();

                services.AddDbContext<MyAppDbContext>();

                var serviceProvider = services.BuildServiceProvider();
                var myAppDbContext = serviceProvider.GetService<MyAppDbContext>();
                myAppDbContext.Database.Migrate();

                Console.WriteLine("Hello World!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
