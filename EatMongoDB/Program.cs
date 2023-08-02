using EatMongoDB.Configurations;
using EatMongoDB;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<DeveloperDatabaseConfiguration>(builder.Configuration.GetSection("DeveloperDatabaseConfiguration"));
builder.Services.AddScoped<CustomerService>();
builder.Services.AddControllers();


builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI(c => {
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V2");
});

app.Run();
