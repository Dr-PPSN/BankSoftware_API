
namespace BankSoftware_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapGet("/konto", (HttpContext httpContext) =>
            {
                var konto = new Konto
                {
                    KontoNummer = "DE123456789",
                    KontoInhaber = "Max Mustermann",
                    Kontostand = 1000,
                    Dispo = 500,
                    Zinssatz = 0.5,
                    IstAktiv = true,
                    KontoTyp = KontoTypen.Girokonto
                };
                return konto;
            })
            .WithName("GetKonto")
            .WithOpenApi();

            app.Run();
        }
    }
}