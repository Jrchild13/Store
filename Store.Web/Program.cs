using Store.Db.Entities;
using Store.Db.Repositories;
using Store.Db.Interfaces;
using RockLib.Logging.DependencyInjection;
using RockLib.Logging;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddLogger()
    .AddFileLogProvider(
        template: "{level} : {message}",
        file: "C:\\admin\\logs\\log.txt",
        level: RockLib.Logging.LogLevel.Info,
        timeout: TimeSpan.FromSeconds(1));

void ConfigureServices(IServiceCollection services)
{
    builder.Services.AddLogger()
        .AddFileLogProvider(
          template: "{level} : {message}",
          level: RockLib.Logging.LogLevel.Info,
          file: "C:\\admin\\logs\\log.txt",
          //output: ConsoleLogProvider.Output.StdOut,
          timeout: TimeSpan.FromSeconds(1)
        );
}

// Add services to the container.
builder.Services.AddControllersWithViews();



builder.Services.AddScoped<StoreDbContext>();
builder.Services.AddScoped<IClientsRepository, ClientsRepository>();
builder.Services.AddScoped<IClientRepository, ClientRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
