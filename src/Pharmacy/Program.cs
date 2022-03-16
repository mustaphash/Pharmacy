using Core.Commands;
using Core.Entities;
using Core.Queries;
using DAL;
using DAL.Commands.AnullateOrderCommand;
using DAL.Commands.ClientCommand;
using DAL.Commands.ClientCommand.UpdateCommand;
using DAL.Commands.CreateClient;
using DAL.Commands.InsertMedicationCommand;
using DAL.Commands.OrderCommand;
using DAL.Commands.PharmacyCommand;
using DAL.Commands.PharmacyCommand.DeletePharmacy;
using DAL.Commands.PharmacyCommand.UpdatePharmacy;
using DAL.Queries.GetAllClients;
using DAL.Queries.GetAllPharmacies;
using DAL.Queries.GetOrders;
using DAL.Queries.GetPharmacyById;
using DAL.Queries.Report;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<PharmacyContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionStrings")));

builder.Services.AddScoped<IQueryHandler<GetAllClientsQuery, IList<Client>>, GetAllClientsQueryHandler>();
builder.Services.AddScoped<IQueryHandler<GetAllPharmaciesQuery, IList<Core.Entities.Pharmacy>>, GetAllPharmaciesQueryHandler>();
builder.Services.AddScoped<IQueryHandler<GetOrdersQuery, IList<Order>>, GetOrdersQueryHandler>();
builder.Services.AddScoped<IQueryHandler<GetPharmacyByIdQuery, Core.Entities.Pharmacy>, GetPharmacyByIdQueryHandler>();
builder.Services.AddScoped<IQueryHandler<GetReportQuery, Core.Entities.Report>, GetReportQueryHandler>();

builder.Services.AddScoped<ICommandHandler<CreateClientCommand>, CreateClientCommandHandler>();
builder.Services.AddScoped<ICommandHandler<InsertMedicationCommand>, InsertMedicationCommandHandler>();
builder.Services.AddScoped<ICommandHandler<UpdateClientCommand>, UpdateClientCommandHandler>();
builder.Services.AddScoped<ICommandHandler<DeleteClientCommand>, DeleteClientCommandHandler>();
builder.Services.AddScoped<ICommandHandler<CreatePharmacyCommand>, CreatePharmacyCommandHandler>();
builder.Services.AddScoped<ICommandHandler<UpdatePharmacyCommand>, UpdatePharmacyCommandHandler>();
builder.Services.AddScoped<ICommandHandler<DeletePharmacyCommand>, DeletePharmacyCommandHandler>();
builder.Services.AddScoped<ICommandHandler<OrderCommand>, OrderCommandHandler>();
builder.Services.AddScoped<ICommandHandler<AnullateOrderCommand>, AnullateOrderCommandHandler>();

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
