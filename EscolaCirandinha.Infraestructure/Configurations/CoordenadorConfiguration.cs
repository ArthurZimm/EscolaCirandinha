using EscolaCirandinha.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EscolaCirandinha.Infraestructure.Configurations;

public class CoordenadorConfiguration  : IEntityTypeConfiguration<Coordenador>
{
    public void Configure(EntityTypeBuilder<Coordenador> builder)
    {
        builder.HasKey(c => c.Id);

        builder.OwnsOne(a => a.DadosCoordenador, dados =>
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

        builder.Property(c => c.Senha)
            .IsRequired()
            .HasMaxLength(100);
    }
}