using Asilo.Models;
using Asilo.Models.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

public class AsiloContext : IdentityDbContext<User, IdentityRole<long>, long, IdentityUserClaim<long>, IdentityUserRole<long>, IdentityUserLogin<long>, IdentityRoleClaim<long>, IdentityUserToken<long>>
{
    public AsiloContext(DbContextOptions<AsiloContext> options) : base(options) { }

    public DbSet<ProntuarioIndividual> ProntuariosIndividuais { get; set; }
    public DbSet<ProntuarioPsicologo> ProntuariosPsicologo { get; set; }
    public DbSet<ProntuarioEnfermagem> ProntuariosEnfermagem { get; set; }
    public DbSet<ProntuarioFisioterapeuta> ProntuariosFisioterapeuta { get; set; }
    public DbSet<ProntuarioNutricionista> ProntuariosNutricionista { get; set; }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Aplica as configura��es de entidades do assembly atual
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        // Configura��o do User para garantir que o Id seja gerado automaticamente
        modelBuilder.Entity<User>()
            .Property(u => u.Id)
            .ValueGeneratedOnAdd(); // Garante que o Id ser� gerado ao adicionar um novo usu�rio

        base.OnModelCreating(modelBuilder);
    }
}
