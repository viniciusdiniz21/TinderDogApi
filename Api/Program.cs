using Dados.EntityFramework;
using Interno.Api.Configuracoes;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(@"Data source = 201.62.57.93,1434; 
                                    Database = BD047106; 
                                    User ID = RA047106; 
                                    Password = 047106;
                                    TrustServerCertificate=True")
);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));



builder.Services.ResolveDependencies();

builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = "Cookies";

})
    .AddCookie("Cookies", c => c.ExpireTimeSpan = TimeSpan.FromMinutes(60));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors("corsapp");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
