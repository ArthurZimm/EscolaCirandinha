using AutoMapper;
using EscolaCirandinha.Application.DTOs.Response;
using EscolaCirandinha.Domain.Contracts.Repositories;
using MediatR;

namespace EscolaCirandinha.Application.Queries.Aluno.ObterAluno
{
    public class ObterAlunosTurmaQueryHandler : IRequestHandler<ObterAlunosTurmaQuery, IEnumerable<AlunoResponse>>
    {
        private readonly IAlunoRepository _alunoRepository;
        private readonly IMapper _mapper;
        public ObterAlunosTurmaQueryHandler(IAlunoRepository alunoRepository, IMapper mapper)
        {
            _alunoRepository = alunoRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<AlunoResponse>> Handle(ObterAlunosTurmaQuery request, CancellationToken cancellationToken)
        {
            var alunos = await _alunoRepository.ObtemAlunosTurma(request.Id);
            return _mapper.Map<IEnumerable<AlunoResponse>>(alunos);
        }
    }
}