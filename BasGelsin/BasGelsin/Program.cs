using AutoMapper;
using BasGelsin.Business.Concrete;
using BasGelsin.DataAccsess.Abstract;
using BasGelsin.DataAccsess.Concrete;
using BasGelsin.DataAccsess.EntityFramework;
using BasGelsin.Mapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(MapperProfile));
builder.Services.AddDbContext<Context>();

builder.Services.AddScoped<CategoryManager>();
builder.Services.AddScoped<ICategoryDal, EfCategoryRepo>();


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
