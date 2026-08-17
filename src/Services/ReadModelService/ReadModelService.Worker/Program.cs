using MassTransit;
using ReadModelService.DI;
using ReadModelService.Worker;
using ReadModelService.Worker.Consumers;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddInfrastructure(builder.Configuration);

// RabbitMQ + MassTransit
//builder.Services.AddMassTransit(x =>
//{
//    // Register consumers
//    x.AddConsumer<KycSubmittedConsumer>();
//    x.AddConsumer<CreditCheckCompletedConsumer>();
//    x.AddConsumer<BorrowingPowerCalculatedConsumer>();

//    x.UsingRabbitMq((context, cfg) =>
//    {
//        cfg.Host(
//            builder.Configuration["RabbitMQ:Host"]
//                ?? "localhost",
//            h =>
//            {
//                h.Username(
//                    builder.Configuration["RabbitMQ:Username"]
//                    ?? "guest");

//                h.Password(
//                    builder.Configuration["RabbitMQ:Password"]
//                    ?? "guest");
//            });

//        // KYC submitted
//        cfg.ReceiveEndpoint(
//            "readmodel-kyc-submitted",
//            e =>
//            {
//                e.ConfigureConsumer<KycSubmittedConsumer>(
//                    context);
//            });

//        // Credit check completed
//        cfg.ReceiveEndpoint(
//            "readmodel-credit-check-completed",
//            e =>
//            {
//                e.ConfigureConsumer<CreditCheckCompletedConsumer>(
//                    context);
//            });

//        // Borrowing power calculated
//        cfg.ReceiveEndpoint(
//            "readmodel-borrowing-power-calculated",
//            e =>
//            {
//                e.ConfigureConsumer<BorrowingPowerCalculatedConsumer>(
//                    context);
//            });
//    });
//});
//builder.Services.AddHostedService<Worker>();

var host = builder.Build();
host.Run();
