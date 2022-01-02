using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetzGo.Cadastros.Dominio.Repositorios;
using PetzGo.Core.Utilitarios.Conversores;

namespace PetzGo.Cadastros.Aplicacao.Consultas.EmpresaConsultas
{
    public class EmpresaConsultas : IEmpresaConsultas
    {
        private readonly IEmpresaRepositorio _empresaRepositorio;

        public EmpresaConsultas(IEmpresaRepositorio empresaRepositorio) => _empresaRepositorio = empresaRepositorio;

        public async Task<IEnumerable<TipoNegocioViewModel>> ObterTodosTiposNegocios() =>
            await _empresaRepositorio.ObterTiposNegocios().Select(tipoNegocio => new TipoNegocioViewModel
            {
                Id = tipoNegocio.Id,
                NomeTipoNegocio = tipoNegocio.NomeTipoNegocio.ObterDescricaoEnum()
            }).ToListAsync();

        public async Task<IEnumerable<ServicoViewModel>> ObterTodosServicos() =>
            await _empresaRepositorio.ObterServicos().Select(servico => new ServicoViewModel
            {
                Id = servico.Id,
                Nome = servico.Nome
            }).ToListAsync();

        public async Task<EmpresaServicoViewModel> ObterServicoEmpresaPetCaracteristica(Guid empresaId, Guid servicoId, Guid petCaracteristicaId)
        {
            var empresaServico = await _empresaRepositorio.ObterServicoEmpresaPetCaracteristica(empresaId, servicoId, petCaracteristicaId);
            if (empresaServico is null)
                return null;

            return new EmpresaServicoViewModel
            {
                Id = empresaServico.EmpresaId,
                ServicoPetCaracteristicaId = empresaServico.ServicoPetCaracteristicaId,
                TipoPet = empresaServico.TipoPet,
                Valor = empresaServico.Valor,
                TempoMinutos = empresaServico.TempoEmMinutos 
            };
        }
            

        public async Task<IEnumerable<DiaSemanaViewModel>> ObterTodosDiasSemana() =>
            await _empresaRepositorio.ObterDiasSemana().Select(diaSemana => new DiaSemanaViewModel
            {
                Id = diaSemana.Id,
                DiaSemana = diaSemana.TipoDiaSemana.ObterDescricaoEnum()
            }).ToListAsync();

        public async Task<IEnumerable<ServicoPetCaracteristicaViewModel>> ObterPetCaracteristicasPorServicoId(Guid servicoId) =>
            await _empresaRepositorio.ObterPetCaracteristicasPorServicoId(servicoId).Select(petCaracteristica =>
                new ServicoPetCaracteristicaViewModel
                {
                    Id = petCaracteristica.Id,
                    PetCaracteristica = petCaracteristica.PetCaracteristica.TipoPetCaracteristica.ObterDescricaoEnum()
                }).ToListAsync();

        public async Task<IEnumerable<PetCaracteristicaViewModel>> ObterPetCaracteristicas() =>
            await _empresaRepositorio.ObterPetCaracteristicas().Select(petCaracteristica =>
                new PetCaracteristicaViewModel
                {
                    Id = petCaracteristica.Id,
                    PetCaracteristica = petCaracteristica.TipoPetCaracteristica.ObterDescricaoEnum()
                }).ToListAsync();
    }
}
