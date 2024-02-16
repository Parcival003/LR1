var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var company = new Company
{
    Id = 1,
    Name = "Apple",
    Employees = 20000,
};

var random = new Random();

app.MapGet("/", context =>
{
    var randomNumber = random.Next(101);
    var randomMessage = $"Random number: {randomNumber}";
    return context.Response.WriteAsync($"Company: {company.Id}, Employees: {company.Name}, Headquarters: {company.Employees}" + "\n" + randomMessage);
});

app.Run();