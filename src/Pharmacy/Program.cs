using Core.Entities;
using Core.Queries;
using DAL;
using DAL.Queries.GetAllClients;
using DAL.Queries.GetAllMedicaments;
using DAL.Queries.GetAllPharmacies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<PharmacyContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionStrings")));

builder.Services.AddScoped<IQueryHandler<GetAllClientsQuery, IList<Client>>, GetAllClientsQueryHandler>();
builder.Services.AddScoped<IQueryHandler<GetAllMedicamentsQuery, IList<Medicament>>, GetAllMedicamentsQueryHandler>();
builder.Services.AddScoped<IQueryHandler<GetAllPharmaciesQuery, IList<Core.Entities.Pharmacy>>, GetAllPharmaciesQueryHandler>();


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
