using EscolaCirandinha.Domain.Contracts.Repositories;
using EscolaCirandinha.Domain.Entities;
using EscolaCirandinha.Infraestructure.Context;

namespace EscolaCirandinha.Infraestructure.Repositories
{
    public class ProfessorMateriaRepository : IProfessorMateriaRepository
    {
        private readonly ApplicationDbContext _context;

        public ProfessorMateriaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Adiciona(ProfessorMateria professorMateria)
        {
            await _context.ProfessorMaterias.AddAsync(professorMateria);
            await _context.SaveChangesAsync();
        }

        public async Task Atualiza(ProfessorMateria professorMateria)
        {
            _context.ProfessorMaterias.Update(professorMateria);
            await _context.SaveChangesAsync();
        }

        public async Task Remover(ProfessorMateria professorMateria)
        {
            _context.ProfessorMaterias.Remove(professorMateria);
            await _context.SaveChangesAsync();
        }
    }
}