using Microsoft.EntityFrameworkCore;

namespace EF_Assignment_1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using BookstoreDbContext context = new();

            await context.Database.MigrateAsync();

            Console.WriteLine("Database Created Successfully!");

        }
    }
}
