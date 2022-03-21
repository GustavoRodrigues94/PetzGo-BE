using System;
using System.Collections.Generic;
using PetzGo.Cadastros.Dominio.Enums;
using PetzGo.Core.DominioBase;

namespace PetzGo.Cadastros.Dominio.Entidades
{
    public class Empresa : Entidade, IRaizAgregacao
    {
        protected Empresa()
        {
            _empresaServicos = new List<EmpresaServico>();
        }

        public Empresa(Guid tipoNegocioId, string nomeFantasia, string cnpj, string whatsApp)
        {
            TipoNegocioId = tipoNegocioId;
            NomeFantasia = nomeFantasia;
            CNPJ = cnpj;
            WhatsApp = whatsApp;
            _empresaServicos = new List<EmpresaServico>();
            _empresaHorarios = new List<EmpresaHorario>();
            _empresaClientes = new List<Cliente>();
        }

        public Guid TipoNegocioId { get; private set; }
        public TipoNegocio TipoNegocio { get; private set; }

        public string NomeFantasia { get; private set; }
        public string CNPJ { get; private set; }
        public string WhatsApp { get; private set; }

        public Guid? EnderecoId { get; private set; }
        public Endereco Endereco { get; private set; }

        private readonly List<EmpresaServico> _empresaServicos;
        public IEnumerable<EmpresaServico> EmpresaServicos => _empresaServicos;

        private readonly List<EmpresaHorario> _empresaHorarios;
        public IEnumerable<EmpresaHorario> EmpresaHorarios => _empresaHorarios;

        private readonly List<Cliente> _empresaClientes;
        public IEnumerable<Cliente> EmpresaClientes => _empresaClientes;

        public void AdicionarEndereco(string cep, string logradouro, string numero, string bairro, string complemento, string cidade, string estado)
        {
            Endereco = new Endereco(cep, logradouro, numero, bairro, complemento, cidade, estado);
        }

        public void AdicionarEmpresaServico(Guid empresaId, Guid servicoPetCaracteristicaId, TipoPetEnum tipoPet, decimal valor, int tempoMinutos) =>
            _empresaServicos.Add(new EmpresaServico(empresaId, servicoPetCaracteristicaId, tipoPet, valor, tempoMinutos));

        public void AdicionarEmpresaHorario(Guid empresaId, Guid diaSemanaId, string horaInicio, string horaFim) =>
            _empresaHorarios.Add(new EmpresaHorario(diaSemanaId, empresaId, horaInicio, horaFim));
    }
}
