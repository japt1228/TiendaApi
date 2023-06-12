using Microsoft.EntityFrameworkCore;
using TiendaApi.DataAccess;
//using TiendaApi.Services;

var builder = WebApplication.CreateBuilder(args);

const string CONNECTIONNAME = "TiendaDB";

var connectionString = builder.Configuration.GetConnectionString(CONNECTIONNAME);


builder.Services.AddDbContext<TiendaDBContext>(options => options.UseSqlServer(connectionString));
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
