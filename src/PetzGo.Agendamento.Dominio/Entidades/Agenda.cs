using System;
using PetzGo.Agendamento.Dominio.Enums;
using PetzGo.Core.DominioBase;

namespace PetzGo.Agendamento.Dominio.Entidades
{
    public class Agenda : Entidade, IRaizAgregacao
    {
        protected Agenda() { }

        public static class AgendaFactory
        {
            public static Agenda NovoAgendamentoIniciado(Guid empresaId, DateTime dataHoraInicio, int tempoEmMinutos)
            {
                var agenda = new Agenda();
                agenda.IniciarAgendamento(empresaId, dataHoraInicio, tempoEmMinutos);
                return agenda;
            }

            public static Agenda FinalizarAgendamentoIniciado(Agenda agendamentoIniciado, 
                string nomeCliente,
                string nomePet, string tipoPet, string petCaracteristica,
                string nomeServico, decimal valorServico, int tempoEmMinutoServico)
            {
                agendamentoIniciado.AdicionarCliente(nomeCliente);
                agendamentoIniciado.AdicionarPet(nomePet, petCaracteristica, tipoPet);
                agendamentoIniciado.AdicionarServico(nomeServico, valorServico, tempoEmMinutoServico);
                agendamentoIniciado.FinalizarAgendamento();

                return agendamentoIniciado;
            }
        }

        public Guid EmpresaId { get; private set; }

        public decimal ValorTotal { get; private set; }
        public AgendamentoStatusEnum AgendamentoStatus { get; private set; }

        public Guid? AgendaClienteId { get; private set; }
        public AgendaCliente AgendaCliente { get; private set; }

        public Guid? AgendaPetId { get; private set; }
        public AgendaPet AgendaPet { get; private set; }

        public Guid? AgendaServicoId { get; private set; }
        public AgendaServico AgendaServico { get; private set; }

        public DateTime DataHoraInicio { get; private set; }
        public DateTime DataHoraTermino { get; private set; }

        private void AdicionarServico(string nome, decimal valor, int tempoEmMinutos)
        {
            var agendaServico = new AgendaServico(Id, nome, valor, tempoEmMinutos);
            AgendaServico = agendaServico;
            AgendaServicoId = agendaServico.Id;

            CalcularValorTotal();
        }

        private void AdicionarPet(string nome, string petCaracteristica, string tipoPet)
        {
            var agendaPet = new AgendaPet(Id, nome, petCaracteristica, tipoPet);
            AgendaPet = agendaPet;
            AgendaPetId = agendaPet.Id;
        }

        private void AdicionarCliente(string nome)
        {
            var agendaCliente = new AgendaCliente(Id, nome);
            AgendaCliente = agendaCliente;
            AgendaClienteId = agendaCliente.Id;
        }

        private void CalcularValorTotal() => ValorTotal = AgendaServico.Valor;

        private void IniciarAgendamento(Guid empresaId, in DateTime dataHoraInicio, int tempoEmMinutos)
        {
            EmpresaId = empresaId;
            DataHoraInicio = dataHoraInicio;
            DataHoraTermino = CalcularDataHoraTermino(DataHoraInicio, tempoEmMinutos);
            AgendamentoStatus = AgendamentoStatusEnum.Iniciado;
        }

        private static DateTime CalcularDataHoraTermino(DateTime dataHoraInicio, int tempoEmMinutos) =>
            dataHoraInicio.AddMinutes(tempoEmMinutos);

        private void FinalizarAgendamento()
        {
            AgendamentoStatus = AgendamentoStatusEnum.GravacaoCompleta;
        }

    }
}
