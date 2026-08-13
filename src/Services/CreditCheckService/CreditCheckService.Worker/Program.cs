using CreditCheckService.DI;
using CreditCheckService.Worker;
//using EventBus.RabbitMQ;
using MassTransit;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssembly(typeof(KycSubmittedConsumer).Assembly));

builder.Services.AddInfrastructure(builder.Configuration);

//builder.Services.AddMassTransit(x =>
//{
//    x.AddConsumer<KycSubmittedConsumer>();

//    x.UsingRabbitMq((context, cfg) =>
//    {
//        cfg.Host("localhost");

//        cfg.ReceiveEndpoint("kyc-submitted-queue", e =>
//        {
//            e.ConfigureConsumer<KycSubmittedConsumer>(context);
//        });
//    });
//});

//builder.Services.AddScoped<EventBus.Abstractions.IEventBus,
//    EventBus.RabbitMQ.RabbitMqEventBus>();

//builder.Services.AddHostedService<Worker>();

var host = builder.Build();
host.Run();
