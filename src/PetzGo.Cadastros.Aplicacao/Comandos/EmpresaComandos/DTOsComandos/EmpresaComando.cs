using System;
using PetzGo.Core.Mensagens.Comandos;

namespace PetzGo.Cadastros.Aplicacao.Comandos.EmpresaComandos.DTOsComandos
{
    public class EmpresaComando : IComando
    {
        public Guid TipoNegocioId { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public string WhatsApp { get; set; }
    }
}
