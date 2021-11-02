using System;

namespace PetzGo.Cadastros.Aplicacao.Comandos.EmpresaComandos.DTOsComandos
{
    public class EmpresaComando
    {
        public Guid TipoNegocioId { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public string WhatsApp { get; set; }
    }
}
