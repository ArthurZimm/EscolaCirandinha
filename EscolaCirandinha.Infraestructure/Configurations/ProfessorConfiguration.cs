using EscolaCirandinha.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EscolaCirandinha.Infraestructure.Configurations;

public class ProfessorConfiguration  : IEntityTypeConfiguration<Professor>
{
    public void Configure(EntityTypeBuilder<Professor> builder)
    {
        throw new NotImplementedException();
    }
}