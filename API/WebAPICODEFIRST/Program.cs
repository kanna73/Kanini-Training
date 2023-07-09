using Microsoft.EntityFrameworkCore;
using WebAPICODEFIRST.Model.Data;
using WebAPICODEFIRST.Services.AdminService;
using WebAPICODEFIRST.Services.UserService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddDbContext<BikeDataContext>(
    optionsAction: options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString(
        name: "SQLConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
