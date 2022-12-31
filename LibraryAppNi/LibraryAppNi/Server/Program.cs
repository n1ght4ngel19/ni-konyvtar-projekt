using LibraryAppNi.Server.DataBase;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllersWithViews();
        builder.Services.AddRazorPages();
        builder.Services.AddDbContext<LibraryDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseWebAssemblyDebugging();
        }
        else
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        //app.UseBlazorFrameworkFiles();
        app.UseStaticFiles();

        app.UseRouting();


        app.MapRazorPages();
        app.MapControllers();
        app.MapFallbackToFile("index.html");

        app.Run();

        app.MapWhen(ctx => ctx.Request.Host.Port == 5001 ||
            ctx.Request.Host.Equals("memberapp.com"), first =>
        {
            first.Use((ctx, nxt) =>
            {
                ctx.Request.Path = "/MemberApp" + ctx.Request.Path;
                return nxt();
            });

            first.UseBlazorFrameworkFiles("/MemberApp");
            first.UseStaticFiles();
            first.UseStaticFiles("/MemberApp");
            first.UseRouting();

            first.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("/MemberApp/{*path:nonfile}",
                    "MemberApp/index.html");
            });
        });

        app.MapWhen(ctx => ctx.Request.Host.Port == 5002 ||
            ctx.Request.Host.Equals("librarianapp.com"), second =>
        {
            second.Use((ctx, nxt) =>
            {
                ctx.Request.Path = "/LibrarianApp" + ctx.Request.Path;
                return nxt();
            });

            second.UseBlazorFrameworkFiles("/LibrarianApp");
            second.UseStaticFiles();
            second.UseStaticFiles("/LibrarianApp");
            second.UseRouting();

            second.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("/LibrarianApp/{*path:nonfile}",
                    "LibrarianApp/index.html");
            });
        });
    }
}