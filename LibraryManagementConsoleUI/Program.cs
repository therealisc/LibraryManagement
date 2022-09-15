using LibraryManagementConsoleUI;
using Microsoft.Extensions.DependencyInjection;

IServiceProvider _serviceProvider;

IServiceCollection services = new ServiceCollection();

services.AddSingleton<BookData>();
services.AddTransient<BookRegistration>();
services.AddTransient<BookLookup>();
services.AddTransient<BookLending>();
services.AddTransient<PenaltyCalculator>();

_serviceProvider = services.BuildServiceProvider();

OptionSetter optionSetter = new OptionSetter(_serviceProvider);

