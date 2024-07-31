using DigitalMealCardSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using DigitalMealCardSystem.Models.Shared;
using Application.Features.Meal;
using Application.Features.Payment;
using Application.Features.Student;
using Application.Features.Transaction;



//using Infrastructure.Dependancyinjection;
        var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddTransient<AccessControllerLog>();
builder.Services.AddTransient<UserActivityLog>();
builder.Services.AddTransient<ExceptionLog>();
builder.Services.AddTransient<AuditLog>(); 
builder.Services.AddTransient<ChangeLog>();
builder.Services.AddTransient<SecurityIncidentLog>();



builder.Services.AddDbContext<MealCardContext>(options =>
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection String is Not Found"));
        });


//ConfigureServices

 void ConfigureServices(IServiceCollection services)
{
    // Register your services here
    services.AddScoped<IStudentService, StudentService>();
    services.AddScoped<IMealService, MealService>();
    services.AddScoped<ITransactionService, TransactionService>();
    services.AddScoped<IPaymentService, PaymentService>();
    // ... other services
}


// JWT Configuration
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = builder.Configuration["Jwt:Issuer"],
                    ValidAudience = builder.Configuration["Jwt:Audience"],
                    IssuerSigningKey = new
                    SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
                };
            });


        





        // Authorization policies
        builder.Services.AddAuthorization(options =>
        {
            options.AddPolicy("RequireAdminRole", policy =>
                policy.RequireRole("Admin"));
            // Add more policies as needed
        });





        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.InfrastructureServices(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }


        app.UseHttpsRedirection();
        app.UseRouting();

        app.UseAuthentication();

        app.UseAuthorization();





        app.UseEndpoints(endpoints =>
   {
            endpoints.MapControllers();
        });

        app.MapControllers();

        app.Run();
    
