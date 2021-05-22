using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using EM.Domain;
using EM.Domain.Exceptions;

namespace EM.Domain.Testes.Features
{
    [Binding]
    public class CadastrarOuEditarAsInformacoesDeUmAlunoSteps
    {
        private Aluno aluno;
        private int matricula;
        private string nome;
        private string sexo;
        private string data;
        private string cpf;

        [Given(@"que o aluno informou seus dados para o coordenador")]
        public void DadoQueOAlunoInformouSeusDadosParaOCoordenador()
        {
        }

        [Given(@"informou sua matricula como (.*)")]
        public void DadoInformouSuaMatriculaComo(int p0)
        {
            matricula = p0;
        }

        [Given(@"informou seu nome como '(.*)'")]
        public void DadoInformouSeuNomeComo(string p0)
        {
            nome = p0;
        }

        [Given(@"informou seu cpf como '(.*)'")]
        public void DadoInformouSeuCpfComo(string p0)
        {
            cpf = p0;
        }

        [Given(@"informou sua data de nascimento como '(.*)'")]
        public void DadoInformouSuaDataDeNascimentoComo(string p0)
        {
            data = p0;
        }

        [Given(@"seu sexo como '(.*)'")]
        public void DadoSeuSexoComo(string p0)
        {
            sexo = p0;
        }

        [When(@"o coordenador verificar a validade dos dados")]
        public void QuandoOCoordenadorVerificarAValidadeDosDados()
        {
        }

        [Then(@"e apresentado a mensagem de erro a respeito da Matricula")]
        public void EntaoEApresentadoAMensagemDeErroARespeitoDaMatricula()
        {
            Assert.Catch<MatriculaInvalidaException>(() => aluno = new Aluno(matricula, nome, cpf, data, sexo));
        }
        [Then(@"e apresentado a mensagem de erro a respeito do Nome")]
        public void EntaoEApresentadoAMensagemDeErroARespeitoDoNome()
        {
            Assert.Catch<NomeInvalidoExceptions>(() => aluno = new Aluno(matricula, nome, cpf, data, sexo));
        }

        [Then(@"nao é apresentado a mensagem de erro")]
        public void EntaoNaoEApresentadoAMensagemDeErro()
        {            
            Assert.DoesNotThrow(() => aluno = new Aluno(matricula, nome, cpf, data, sexo));
        }

        [Then(@"e apresentado a mensagem de erro a respeito do Cpf")]
        public void EntaoEApresentadoAMensagemDeErroARespeitoDoCpf()
        {                       
            Assert.Catch<CpfInvalidoException>(() => aluno = new Aluno(matricula, nome, cpf, data, sexo));
        }
        [Then(@"nao é apresentado a mensagem de erro a respeito da Data de Nascimento")]
        public void EntaoNaoEApresentadoAMensagemDeErroARespeitoDaDataDeNascimento()
        {
            Assert.DoesNotThrow(() => aluno = new Aluno(matricula, nome, cpf, data, sexo));
        }

        [Then(@"e apresentado a mensagem de erro a respeito da Data de Nascimento")]
        public void EntaoEApresentadoAMensagemDeErroARespeitoDaDataDeNascimento()
        {
            Assert.Catch<DataNascimentoInvalidaException>(() => aluno = new Aluno(matricula, nome, cpf, data, sexo));
        }
    }
}


