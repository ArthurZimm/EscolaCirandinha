using EscolaCirandinha.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EscolaCirandinha.Infraestructure.Configurations;

public class AlunoAtividadeConfiguration : IEntityTypeConfiguration<AlunoAtividade>
{
    public void Configure(EntityTypeBuilder<AlunoAtividade> builder)
    {
        throw new NotImplementedException();
    }
}