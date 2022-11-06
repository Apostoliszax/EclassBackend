
using EclassBackend.DAL;
using Microsoft.EntityFrameworkCore;
using static EclassBackend.DAL.EclassContext;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors(options =>
{
    options.AddPolicy("AnotherPolicy",
        policy =>
        {
            policy.WithOrigins("http://localhost:3000")
                                .AllowAnyHeader()
                                .AllowAnyMethod();
        });
});


builder.Services.AddControllers();
builder.Services.AddDbContext<EclassContext>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString("EclassDB")));
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

app.UseCors();

app.UseAuthorization();

app.MapControllers();
    

app.Run();
