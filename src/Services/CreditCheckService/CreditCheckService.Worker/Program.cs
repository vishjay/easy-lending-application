using CreditCheckService.Application.Commands;
using CreditCheckService.DI;
using CreditCheckService.Worker;
//using EventBus.RabbitMQ;
using MassTransit;
using Microsoft.EntityFrameworkCore;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssembly(typeof(PerformCreditCheckCommand).Assembly));

builder.Services.AddInfrastructure(builder.Configuration);

//builder.Services.AddMassTransit(x =>
//{
//    x.AddConsumer<KycSubmittedConsumer>();

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

//        // KYC submitted
//        cfg.ReceiveEndpoint(
//            "creditcheck-kyc-submitted",
//            e =>
//            {
//                e.ConfigureConsumer<KycSubmittedConsumer>(
//                    context);
//            });
//    });
//});

//builder.Services.AddHostedService<Worker>();

var host = builder.Build();
host.Run();
