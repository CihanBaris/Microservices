using Ocelot.DependencyInjection;
using Ocelot.Middleware;

internal class Program
{
    private static void Main(string[] args)
    {
        IConfiguration configuration = new ConfigurationBuilder()
                            .AddJsonFile("ocelot.json")
                            .Build();
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllers();

        builder.Services.AddOcelot(configuration);
        var app = builder.Build();

        // Configure the HTTP request pipeline.
        app.UseOcelot();

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}