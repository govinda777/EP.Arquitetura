using System;
using System.Collections.Generic;
using Aluno.Application.Adapters;
using Aluno.Application.Bus;
using Aluno.Application.Interfaces;
using Aluno.Application.ViewModels;
using Aluno.CommandStack.Commands;
using Aluno.Data.Read.Interfaces;
using Aluno.Data.Read.Models;
using Aluno.Domain.Core.Interfaces;

namespace Aluno.Application
{
    public class AlunoAppService : IAlunoAppService
    {
        private readonly IAlunoService _alunoService;
        private readonly IAlunoReadRepository _alunoReadRepository;

        public AlunoAppService(IAlunoService alunoService, IAlunoReadRepository alunoReadRepository)
        {
            _alunoService = alunoService;
            _alunoReadRepository = alunoReadRepository;
        }

        public AlunoViewModel Adicionar(AlunoViewModel alunoViewModel)
        {
            var aluno = AlunoAdapter.ToDomainModel(alunoViewModel);

            var result = _alunoService.Adicionar(aluno);

            if (result.ValidationResult.IsValid)
            {
                var command = new AdicionarAlunoCommand(
                    alunoViewModel.AlunoId,
                    alunoViewModel.Nome,
                    alunoViewModel.CPF,
                    alunoViewModel.Email);

                BusConfig.Bus.Send(command);
            }

            alunoViewModel.ValidationResult = result.ValidationResult;
            return alunoViewModel;
        }

        public AlunoEndereco ObterPorId(Guid id)
        {
            return _alunoReadRepository.ObterPorId(id);
        }

        public IEnumerable<AlunoEndereco> ObterTodos()
        {
            return _alunoReadRepository.ObterTodos();
        }
    }
}