using linux_service_test;

IHost host = Host.CreateDefaultBuilder(args)
	.UseSystemd()
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
    })
    .Build();

await host.RunAsync();
