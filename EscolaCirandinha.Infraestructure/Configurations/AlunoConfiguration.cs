using EscolaCirandinha.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EscolaCirandinha.Infraestructure.Configurations;

public class AlunoConfiguration : IEntityTypeConfiguration<Aluno>
{
    public void Configure(EntityTypeBuilder<Aluno> builder)
    {
        throw new NotImplementedException();
    }
}