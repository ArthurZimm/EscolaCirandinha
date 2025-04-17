using EscolaCirandinha.Domain.Contracts.Repositories;
using EscolaCirandinha.Domain.Entities;
using EscolaCirandinha.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;

namespace EscolaCirandinha.Infraestructure.Repositories
{
    public class TurmaRepository : ITurmaRepository
    {
        private readonly ApplicationDbContext _context;

        public TurmaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Turma?> ObtemTurmaNome(string nome)
        {
            return await _context.Turmas.AsNoTracking().FirstOrDefaultAsync(t => t.Nome == nome);
        }

        public async Task<IEnumerable<Turma>?> ObtemTurmas()
        {
            return await _context.Turmas.AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<Turma>?> ObtemTurmasProfessor(Guid professorId)
        {
            return await _context.Turmas.AsNoTracking().Where(t=>t.ProfessorId == professorId).ToListAsync();
        }
        public async Task<Turma?> ObtemTurmaId(Guid id)
        {
            return await _context.Turmas.AsNoTracking().FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task Adiciona(Turma turma)
        {
            var turmaExistente = await ObtemTurmaNome(turma.Nome);
            if (turmaExistente != null)
            {
                throw new Exception("Já existe uma turma com esse nome.");
            }
            await _context.Turmas.AddAsync(turma);
            await _context.SaveChangesAsync();
        }

        public async Task Atualiza(Turma turma)
        {
            var turmaExistente = await ObtemTurmaId(turma.Id);
            if (turmaExistente == null)
            {
                throw new Exception("Turma não encontrada.");
            }
            _context.Turmas.Update(turma);
            await _context.SaveChangesAsync();
        }


        public async Task Remover(Turma turma)
        {
            var turmaExistente = await ObtemTurmaId(turma.Id);
            if (turmaExistente == null)
            {
                throw new Exception("Turma não encontrada.");
            }
            _context.Turmas.Remove(turmaExistente);
            await _context.SaveChangesAsync();
        }
    }
}