using Microsoft.EntityFrameworkCore;
using src.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder
    .Services
    .AddDbContext<DatabaseContext>(options => options.UseInMemoryDatabase("dbContracts"));
    // em caso de uso de outra base de dados basta alterar o metodo de options 
    // e inserir a connection string como parametro
    // options.UseSqlServer("connectionString")

builder.Services.AddScoped<DatabaseContext, DatabaseContext>(); 
    // Sempre que voce chamar o elemento1 ele entrega uma instancia do elemento2 
    // AddScoped<elemento1, elemnto2>

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
