using API.Helpers;
using API.Services;
using Data;
using Data.Helpers;
using Data.Models;
using Data.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

ConfigureServices();

var app = builder.Build();

ConfigureMiddlewares();

await using var scope = app.Services.CreateAsyncScope();
var seeder = scope.ServiceProvider.GetService<Seeder>();
await seeder.SeedRolesAsync();
await seeder.CreateAdminAsync();

app.Run();

return;

void ConfigureServices()
{
    builder.Services.AddControllers();

    builder.Services.AddDbContext<PmsDbContext>(options =>
        options.UseNpgsql(builder.Configuration.GetConnectionString("Default")));

    builder.Services.AddIdentityCore<User>(options =>
        {
            options.SignIn.RequireConfirmedEmail = true;
            options.User.RequireUniqueEmail = true;
        })
        .AddRoles<IdentityRole>()
        .AddEntityFrameworkStores<PmsDbContext>();

    builder.Services.AddIdentityApiEndpoints<User>();
    builder.Services.AddAuthentication();

    builder.Services.AddCors(options =>
        options.AddPolicy("policy", policyBuilder =>
            policyBuilder.AllowCredentials().AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200")));

    builder.Services.ConfigureApplicationCookie(options =>
    {
        options.Cookie.Name = "PMSAuthToken";
        options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
        options.Cookie.HttpOnly = true;
        options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
        options.Cookie.SameSite = SameSiteMode.None;
        options.SlidingExpiration = true;
    });

    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    builder.Services.Configure<EmailOptions>(builder.Configuration.GetSection("Email"));

    builder.Services.AddTransient<Seeder>();
    builder.Services.AddTransient<IEmailSender, EmailService>();
    builder.Services.AddTransient<AccountEmailHelper>();
    builder.Services.AddScoped<IRepository<Product>, Repository<Product>>();
    builder.Services.AddScoped<IProductsService, ProductsService>();
    builder.Services.AddScoped<IUsersService, UsersService>();
}

void ConfigureMiddlewares()
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();
    app.UseCors("policy");
    app.UseAuthentication();
    app.UseAuthorization();
    app.MapControllers();
}