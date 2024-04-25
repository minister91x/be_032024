using BE_032024;
using DataAccess.NetCore.DAO;
using DataAccess.NetCore.DAOImpl;
using DataAccess.NetCore.DbContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
// Add services to the container.
builder.Services.AddDbContext<EShopDbContext>(options =>
               options.UseSqlServer(configuration.GetConnectionString("ConnStr")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IPostDAO, PostDAOImpl>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.Run(async context =>
//{
//    await context.Response.WriteAsync("Hello world!");
//});
//app.UseMiddleware<MyCustomMiddleWare>();
app.UseMy_CustomeMiddleware();

app.UseAuthorization();

app.UseHttpsRedirection();

app.UseStaticFiles();
app.MapControllers();

app.Run();
