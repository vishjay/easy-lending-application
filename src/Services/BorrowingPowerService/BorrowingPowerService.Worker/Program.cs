using BorrowingPowerService.DI;
using BorrowingPowerService.Worker;

var builder = Host.CreateApplicationBuilder(args);
//builder.Services.AddHostedService<Worker>();

builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssembly(typeof(CreditCheckCompletedConsumer).Assembly));

builder.Services.AddInfrastructure(builder.Configuration);

//builder.Services.AddMassTransit(x =>
//{
//    x.AddConsumer<CreditCheckCompletedConsumer>();

//    x.UsingRabbitMq((context, cfg) =>
//    {
//        cfg.Host("localhost");

//        cfg.ReceiveEndpoint("credit-check-completed-queue", e =>
//        {
//            e.ConfigureConsumer<CreditCheckCompletedConsumer>(context);
//        });
//    });
//});

//builder.Services.AddScoped<EventBus.Abstractions.IEventBus,
//    EventBus.RabbitMQ.RabbitMqEventBus>();

var host = builder.Build();
host.Run();
