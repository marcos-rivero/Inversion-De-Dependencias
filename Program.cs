// See https://aka.ms/new-console-template for more information
using InversionDependencia;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");
var serviceProvider = new ServiceCollection()
    .AddScoped<IAlmacenamiento, AlmacenamientoSQL>()
    .AddScoped<ILogging, Logging>()
    .AddScoped<IArchivo, Archivo>()
    .AddScoped<DBRepositorio>()
    .AddScoped<Articulo>()
    .AddScoped<Cache>().BuildServiceProvider();

var articulo = serviceProvider.GetService<Articulo>();
articulo.ConsultarArticulo("test");
