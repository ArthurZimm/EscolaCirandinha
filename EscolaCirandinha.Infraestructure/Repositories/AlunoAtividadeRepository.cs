using EscolaCirandinha.Domain.Contracts.Repositories;
using EscolaCirandinha.Domain.Entities;
using EscolaCirandinha.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;

namespace EscolaCirandinha.Infraestructure.Repositories
{
    public class AlunoAtividadeRepository : IAlunoAtividadeRepository
    {
        private readonly ApplicationDbContext _context;

        public AlunoAtividadeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<AlunoAtividade?> ObtemAlunosAtividadesAlunoId(Guid alunoId)
        {
            return await _context.AlunoAtividades.AsNoTracking().FirstOrDefaultAsync(x => x.AlunoId == alunoId);
        }

        public async Task<IEnumerable<AlunoAtividade>?> ObtemAlunosAtividadesAtividadeId(Guid atividadeId)
        {
            return await _context.AlunoAtividades.AsNoTracking().Where(x => x.AtividadeId == atividadeId).ToListAsync();
        }

        public async Task<IEnumerable<AlunoAtividade>?> ObtemAlunosAtividadesTurmaId(Guid turmaId)
        {
            return await _context.AlunoAtividades.AsNoTracking().Where(x => x.Atividade.TurmaId == turmaId).ToListAsync();
        }
        public async Task Adiciona(AlunoAtividade alunoAtividade)
        {
            var alunoAtividadeExistente = await ObtemAlunosAtividadesAlunoId(alunoAtividade.AlunoId);
            if (alunoAtividadeExistente != null)
            {
                throw new Exception("Já existe um aluno cadastrado com essa atividade.");
            }
            await _context.AlunoAtividades.AddAsync(alunoAtividade);
            await _context.SaveChangesAsync();
        }

        public async Task Atualiza(AlunoAtividade alunoAtividade)
        {
            var alunoAtividadeExistente = await ObtemAlunosAtividadesAlunoId(alunoAtividade.AlunoId);
            if (alunoAtividadeExistente == null)
            {
                throw new Exception("Aluno não encontrado.");
            }
            _context.Entry(alunoAtividade).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Remover(AlunoAtividade alunoAtividade)
        {
            var alunoAtividadeExistente = await ObtemAlunosAtividadesAlunoId(alunoAtividade.AlunoId);
            if (alunoAtividadeExistente == null)
            {
                throw new Exception("Aluno não encontrado.");
            }
            _context.AlunoAtividades.Remove(alunoAtividade);
            await _context.SaveChangesAsync();
        }
    }
}