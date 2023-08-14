using Business.Layer.Contrete;
using Business.Layer.Interface;
using DataAcess.Layer;
using DataAcess.Layer.Contrete;
using DataAcess.Layer.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SirketDB>();
builder.Services.AddScoped<IDepartmanRepository ,DepartmanRepository>();
builder.Services.AddScoped<IDepartmanBusiness ,DepartmanBusiness > ();


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
