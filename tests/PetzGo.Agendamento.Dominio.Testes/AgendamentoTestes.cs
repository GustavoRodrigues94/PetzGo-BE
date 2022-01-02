using System;
using PetzGo.Agendamento.Dominio.Entidades;
using Xunit;

namespace PetzGo.Agendamento.Dominio.Testes
{
    public class AgendamentoTests
    {
        [Fact(DisplayName = "Adicionar agendamento válido")]
        [Trait("PetzGo.Agenda.Dominio", "Agenda")]
        public void AdicionarServicoAgendamento_NovoAgendamento_DeveCalcularValorTotal()
        {
            // Arrange
            var agendamento = new Agendamento();
            var servico = new AgendaServico(Guid.NewGuid(), "Banho & Tosa", new decimal(20.45));

            // Act
            agendamento.AdicionarServico(servico);

            // Assert
            Assert.Equal(new decimal(20.45), agendamento.ValorTotal);
        }
    }
}
