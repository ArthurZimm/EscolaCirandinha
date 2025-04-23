using AutoMapper;
using EscolaCirandinha.Application.DTOs.Response;
using EscolaCirandinha.Domain.Contracts.Repositories;
using MediatR;

namespace EscolaCirandinha.Application.Queries.Aluno.ObterAluno
{
    public class ObterAlunoIdQueryHandler : IRequestHandler<ObterAlunoIdQuery, AlunoResponse>
    {
        private readonly IAlunoRepository _alunoRepository;
        private readonly IMapper _mapper;

        public ObterAlunoIdQueryHandler(IAlunoRepository alunoRepository, IMapper mapper)
        {
            _alunoRepository = alunoRepository;
            _mapper = mapper;
        }

        public async Task<AlunoResponse> Handle(ObterAlunoIdQuery request, CancellationToken cancellationToken)
        {
            var aluno = await _alunoRepository.ObtemAlunoId(request.Id);
            return new AlunoResponse(aluno!.Id, _mapper.Map<DadosPessoaisResponse>(aluno.DadosAluno),_mapper.Map<EnderecoResponse>(aluno.Endereco), 
                _mapper.Map<TurmaResponse>(aluno.Turma));
        }
    }
}