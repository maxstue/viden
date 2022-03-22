using Kj.Api.Extensions.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddApiLayer(builder.Environment, builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
}

app.UseHttpsRedirection();
app.MapGraphQL();
app.UseAuthorization();

app.MapControllers();

app.Run();