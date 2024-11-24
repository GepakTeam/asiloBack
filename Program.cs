using Asilo.Models.Account;  // Modelos de usu�rio
using Microsoft.AspNetCore.Identity;  // Para Identity
using Microsoft.EntityFrameworkCore;  // Para EF Core
using Microsoft.AspNetCore.Identity.UI.Services;  // Para IEmailSender
using Microsoft.AspNetCore.Builder;  // Para m�todos como MapGet, MapControllers
using Microsoft.Extensions.DependencyInjection;  // Para AddIdentity, AddControllers etc.
using Microsoft.Extensions.Hosting;  // Para IHostEnvironment

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Configura��o do DbContext com EF Core
        builder.Services.AddDbContext<AsiloContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

        // Configura��o do Identity com User e roles com chave prim�ria do tipo long
        builder.Services.AddIdentity<User, IdentityRole<long>>(options =>
        {

            options.Password.RequiredLength = 6;
            options.Password.RequireDigit = false;
            options.Password.RequireLowercase = false;
            options.Password.RequireUppercase = false;
            options.Password.RequireNonAlphanumeric = false;
            options.User.RequireUniqueEmail = true;
            options.SignIn.RequireConfirmedEmail = true;  // Requer confirma��o de e-mail
        })
        .AddEntityFrameworkStores<AsiloContext>()
        .AddDefaultTokenProviders();

        // Adicionando suporte para autentica��o e autoriza��o
        builder.Services.AddAuthentication();  // N�o especifique o esquema aqui
        builder.Services.AddAuthorization();

        // Adicionando suporte para controladores
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        // Adicionando suporte para o envio de e-mails
        builder.Services.AddTransient<IEmailSender, EmailSender>();

        var app = builder.Build();

        // Habilitar Swagger apenas no ambiente de desenvolvimento
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseAuthentication();  
        app.UseAuthorization();  

       
        app.MapGet("/", () => new { message = "OK" });

        app.MapControllers();

  
        app.UseCors(options =>
        {
            options.AllowAnyHeader()
                .AllowAnyMethod()
                .AllowAnyOrigin();
        });

        app.Run();
    }
}
