using EscolaCirandinha.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EscolaCirandinha.Infraestructure.Configurations;

public class AtividadeConfiguration : IEntityTypeConfiguration<Atividade>
{
    public void Configure(EntityTypeBuilder<Atividade> builder)
    {
        throw new NotImplementedException();
    }
}