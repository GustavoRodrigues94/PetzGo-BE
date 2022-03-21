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
            var agendamento = Agenda.AgendaFactory.NovoAgendamentoIniciado(Guid.NewGuid(), DateTime.Now, 130);

            // Act
            //agendamento.AdicionarServico("Banho & Tosa", new decimal(20.45), 130);

            // Assert
            Assert.Equal(new decimal(20.45), agendamento.ValorTotal);
        }
    }
}
