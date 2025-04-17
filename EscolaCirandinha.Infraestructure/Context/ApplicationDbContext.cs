using EscolaCirandinha.Domain.Entities;
using EscolaCirandinha.Infraestructure.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace EscolaCirandinha.Infraestructure.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
        
    }
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }
    #region Tabelas
    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<AlunoAtividade> AlunoAtividades { get; set; }
    public DbSet<Atividade> Atividades { get; set; }
    public DbSet<Coordenador> Coordenadores { get; set; }
    public DbSet<Materia> Materias { get; set; }
    public DbSet<Professor> Professores { get; set; }
    public DbSet<ProfessorMateria> ProfessorMaterias { get; set; }
    public DbSet<Turma> Turmas { get; set; }
    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Configurações de modelagem de tabela
        modelBuilder.ApplyConfiguration(new AlunoAtividadeConfiguration());
        modelBuilder.ApplyConfiguration(new AlunoConfiguration());
        modelBuilder.ApplyConfiguration(new AtividadeConfiguration());
        modelBuilder.ApplyConfiguration(new CoordenadorConfiguration());
        modelBuilder.ApplyConfiguration(new MateriaConfiguration());
        modelBuilder.ApplyConfiguration(new ProfessorConfiguration());
        modelBuilder.ApplyConfiguration(new ProfessorMateriaConfiguration());
        modelBuilder.ApplyConfiguration(new TurmaConfiguration());
        #endregion
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=EscolaCirandinha;User Id=sa;Password=Arthur123!;Trusted_Connection=False;MultipleActiveResultSets=true;TrustServerCertificate=true");
    }
}