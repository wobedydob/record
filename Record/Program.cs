using TinCan;
using Record.Classes;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



var config = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json").Build();
var api = new RecordConfig(config);



app.MapGet("/", () => "Welcome to... 📀 Record!");
app.Run();