using AspNetCoreEfCoreTemplate.Data;
using AspNetCoreEfCoreTemplate.Services;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreEfCoreTemplate;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddMvc().AddRazorRuntimeCompilation();

        builder.Services.AddTransient<IExampleService, ExampleService>();

        builder.Services.AddDbContext<AppDbContext>(options =>
        {
            options.EnableSensitiveDataLogging();
            options.UseSqlServer(
                builder.Configuration.GetConnectionString(Constants.DefaultConnection),
                sqlOptions => sqlOptions.EnableRetryOnFailure());
        });


        var app = builder.Build();

        app.UseDeveloperExceptionPage();

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        //app.UseAuthentication();

        app.UseRouting();

        //app.UseAuthorization();

        app.UseEndpoints(c => c.MapControllers());

        app.Run();
    }
}
