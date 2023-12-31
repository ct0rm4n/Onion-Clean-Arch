using Rabbit.Repositories.Interfaces;
using Rabbit.Repositories;
using Rabbit.Services.Interfaces;
using Rabbit.Services;
using API.Rabbit.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IRabbitMensagemService, RabbitMensagemService>();
builder.Services.AddTransient<IRabbitMensagemRepository, RabbitMensagemRepository>();

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
