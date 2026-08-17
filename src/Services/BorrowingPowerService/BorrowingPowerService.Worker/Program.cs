using BorrowingPowerService.Application.Commands;
using BorrowingPowerService.DI;
using BorrowingPowerService.Worker;
using MassTransit;

var builder = Host.CreateApplicationBuilder(args);


builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssembly(typeof(CalculateBorrowingCommand).Assembly));

builder.Services.AddInfrastructure(builder.Configuration);

//builder.Services.AddMassTransit(x =>
//{
//    x.AddConsumer<CreditCheckCompletedConsumer>();

//    x.UsingRabbitMq((context, cfg) =>
//    {
//        cfg.Host(
//        builder.Configuration["RabbitMQ:Host"]
//            ?? "localhost",
//        h =>
//        {
//            h.Username(
//                builder.Configuration["RabbitMQ:Username"]
//                ?? "guest");

//            h.Password(
//                builder.Configuration["RabbitMQ:Password"]
//                ?? "guest");
//        });

//        // credit check completed
//        cfg.ReceiveEndpoint(
//            "borrowingpower-credit-check-completed",
//            e =>
//            {
//                e.ConfigureConsumer<CreditCheckCompletedConsumer>(
//                    context);
//            });
//    });
//});

//builder.Services.AddHostedService<Worker>();

var host = builder.Build();
host.Run();
