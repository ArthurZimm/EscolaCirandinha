using EscolaCirandinha.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EscolaCirandinha.Infraestructure.Configurations;

public class AlunoConfiguration : IEntityTypeConfiguration<Aluno>
{
    public void Configure(EntityTypeBuilder<Aluno> builder)
    {
        builder.HasKey(a => a.Id);

        // DadosAluno
        builder.OwnsOne(a => a.DadosAluno, dados =>
        {
            dados.Property(d => d.Nome)
                .IsRequired()
                .HasMaxLength(100);

            dados.Property(d => d.Cpf)
                .IsRequired()
                .HasMaxLength(11);

            dados.Property(d => d.DataNascimento)
                .IsRequired();
        });

        // Endereco
        builder.OwnsOne(a => a.Endereco, endereco =>
        {
            endereco.Property(e => e.Rua)
                .IsRequired()
                .HasMaxLength(200);

            endereco.Property(e => e.Numero)
                .IsRequired();

            endereco.Property(e => e.Bairro)
                .IsRequired()
                .HasMaxLength(100);

            endereco.Property(e => e.Cidade)
                .IsRequired()
                .HasMaxLength(100);

            endereco.Property(e => e.Estado)
                .IsRequired()
                .HasMaxLength(50);

            endereco.Property(e => e.Cep)
                .IsRequired()
                .HasMaxLength(8);
        });

        // Responsavel
        builder.OwnsOne(a => a.Responsavel, responsavel =>
        {
            responsavel.OwnsOne(r => r.Mae, mae =>
            {
                mae.Property(m => m.Nome)
                    .IsRequired()
                    .HasMaxLength(100);

                mae.Property(m => m.Cpf)
                    .IsRequired()
                    .HasMaxLength(11);

                mae.Property(m => m.DataNascimento)
                    .IsRequired();
            });

            responsavel.OwnsOne(r => r.Pai, pai =>
            {
                pai.Property(p => p.Nome)
                    .HasMaxLength(100);

                pai.Property(p => p.Cpf)
                    .HasMaxLength(11);

                pai.Property(p => p.DataNascimento);
            });
        });

        builder.Property(a => a.Senha)
            .IsRequired()
            .HasMaxLength(50);

        builder.HasOne(a => a.Turma)
             .WithMany(t => t.Alunos)
             .HasForeignKey(a => a.TurmaId)
             .IsRequired();


        builder.HasMany(a => a.AlunoAtividades)
            .WithOne()
            .HasForeignKey(a=>a.AlunoId);
    }

}