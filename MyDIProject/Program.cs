using MyDIProject;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();
builder.Services.AddSingleton<IMessageWriter, ConsoleMessageWriter>();

var host = builder.Build();
host.Run();
