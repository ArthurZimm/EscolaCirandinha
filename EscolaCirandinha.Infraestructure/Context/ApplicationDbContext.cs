using EscolaCirandinha.Domain.Entities;
using EscolaCirandinha.Infraestructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace EscolaCirandinha.Infraestructure.Context;

public class ApplicationDbContext : DbContext
{
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

    protected override void OnConfiguring(DbContextOptionsBuilder opt)
    {
        base.OnConfiguring(opt);
        opt.UseSqlServer();
    }
}