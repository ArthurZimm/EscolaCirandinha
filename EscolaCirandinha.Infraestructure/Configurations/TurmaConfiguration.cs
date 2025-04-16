using EscolaCirandinha.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EscolaCirandinha.Infraestructure.Configurations;

public class TurmaConfiguration  : IEntityTypeConfiguration<Turma>
{
    public void Configure(EntityTypeBuilder<Turma> builder)
    {
        throw new NotImplementedException();
    }
}