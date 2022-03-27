using viden.Api.Extensions.Services;
using viden.Domain.Constants;
using viden.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddInfrastructureLayer(builder.Configuration);
builder.Services.AddApiLayer(builder.Environment, builder.Configuration)
    .AddCors(options =>
    {
        // TODO move into Infrastructure
        options.AddPolicy(AuthConstants.CorsPolicies.AllowAny,
            b => b
                .AllowAnyOrigin()
                // .WithOrigins("http://localhost:8080", "http://localhost:4200")
                .AllowAnyMethod()
                .AllowAnyHeader());
    });



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