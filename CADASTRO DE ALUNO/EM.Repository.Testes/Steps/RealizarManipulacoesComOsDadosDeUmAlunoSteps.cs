using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using EM.Repository;
using EM.Domain;
using EM.Repository.Exceptions;
using EM.Domain.Exceptions;

namespace EM.Repository.Testes
{
    [Binding]
    public class RealizarManipulacoesComOsDadosDeUmAlunoSteps
    {
        private Aluno aluno;
        private RepositoriodoAluno repositorio;
        private int matricula;
        private string nome;
        private string sexo;
        private string data;
        private string cpf;
        private string pesquisaNome;
        private int pesquisaMatricula;

        [Given(@"que um aluno informou seus dados para o coordenador")]
        public void DadoQueUmAlunoInformouSeusDadosParaOCoordenador()
        {
            repositorio = new RepositoriodoAluno();
        }
        [Given(@"informou seu NOME como '(.*)'")]
        public void DadoInformouSeuNOMEComo(string p0)
        {
            nome = p0;
        }
        [Given(@"informou seu CPF como '(.*)'")]
        public void DadoInformouSeuCPFComo(string p0)
        {
            cpf = p0;
        }
        [Given(@"informou sua matricula como (.*)")]
        public void DadoInformouSuaMatriculaComo(int p0)
        {
            matricula = p0;
        }
        [Given(@"informou sua data de Nascimento como '(.*)'")]
        public void DadoInformouSuaDataDeNascimentoComo(string p0)
        {
            data = p0;
        }
        [Given(@"informou seu sexo como '(.*)'")]
        public void DadoInformouSeuSexoComo(string p0)
        {
            sexo = p0;
        }
        [When(@"o coordenador processar essas informacoes")]
        public void QuandoOCoordenadorProcessarEssasInformacoes()
        {           
        }
        [Then(@"o aluno deve ser adicionado ao Repositorio")]
        public void EntaoOAlunoDeveSerAdicionadoAoRepositorio()
        {
            Assert.DoesNotThrow(() => repositorio.Add(aluno = new Aluno(matricula, nome, cpf, data, sexo)));
        }
        [Then(@"o aluno nao deve ser adicionado ao Repositorio")]
        public void EntaoOAlunoNaoDeveSerAdicionadoAoRepositorio()
        {
            Assert.Catch<MatriculaJaCadastradaException>(() => repositorio.Add(aluno = new Aluno(matricula, nome, cpf, data, sexo)));
        }
        [Given(@"que o coordenador tem em maos os dados do Aluno")]
        public void DadoQueOCoordenadorTemEmMaosOsDadosDoAluno()
        {
            repositorio = new RepositoriodoAluno();
        }
        [Given(@"o seu nome e '(.*)'")]
        public void DadoOSeuNomeE(string p0)
        {
            nome = p0;
        }
        [Given(@"a matricula e (.*)")]
        public void DadoAMatriculaE(int p0)
        {
            matricula = p0;
        }
        [Given(@"o Cpf e '(.*)'")]
        public void DadoOCpfE(string p0)
        {
            cpf = p0;
        }
        [Given(@"a data de Nascimento e '(.*)'")]
        public void DadoADataDeNascimentoE(string p0)
        {
            data = p0;
        }
        [Given(@"o sexo e '(.*)'")]
        public void DadoOSexoE(string p0)
        {
            sexo = p0;
        }
        [When(@"o coordenador confirmar a exclusao")]
        public void QuandoOCoordenadorConfirmarAExclusao()
        {
        }
        [Then(@"o aluno e removido do repositorio")]
        public void EntaoOAlunoERemovidoDoRepositorio()
        {
            Assert.DoesNotThrow(() => repositorio.Remove(aluno = new Aluno(matricula, nome, cpf, data, sexo)));
        }
        [Given(@"que o coordenador tem em maos os dados do Aluno e deseja atualiza-los")]
        public void DadoQueOCoordenadorTemEmMaosOsDadosDoAlunoEDesejaAtualiza_Los()
        {
            repositorio = new RepositoriodoAluno();
        }
        [Given(@"a matricula do aluno e (.*)")]
        public void DadoAMatriculaDoAlunoE(int p0)
        {
            matricula = p0;
        }
        [Given(@"o nome do aluno e '(.*)'")]
        public void DadoONomeDoAlunoE(string p0)
        {
            nome = p0;
        }
        [When(@"o coordenador localizar os dados do aluno para atualiza-los")]
        public void QuandoOCoordenadorLocalizarOsDadosDoAlunoParaAtualiza_Los()
        {
        }
        [Then(@"os dados sao atualizados")]
        public void EntaoOsDadosSaoAtualizados()
        {
            Assert.DoesNotThrow(() => repositorio.Update(aluno = new Aluno(matricula, nome, cpf, data, sexo)));
        }
        [Then(@"os dados nao sao atualizados")]
        public void EntaoOsDadosNaoSaoAtualizados()
        {
            Assert.Catch<CpfInvalidoException>(() => repositorio.Update(aluno = new Aluno(matricula, nome, cpf, data, sexo)));
        }
        [Given(@"que existam varios alunos no repositorio")]
        public void DadoQueExistamVariosAlunosNoRepositorio()
        {
            repositorio = new RepositoriodoAluno();
        }
        [Given(@"o coordenador deseja saber os alunos que possuem '(.*)' no nome")]
        public void DadoOCoordenadorDesejaSaberOsAlunosQuePossuemNoNome(string p0)
        {
            pesquisaNome = p0;
        }
        [Given(@"o coordenador deseja saber o aluno que possui a matricula (.*)")]
        public void DadoOCoordenadorDesejaSaberOAlunoQuePossuiAMatricula(int p0)
        {
            pesquisaMatricula = p0;
        }
        [When(@"o coordenador realizar a busca")]
        public void QuandoOCoordenadorRealizarABusca()
        {
        }
        [Then(@"ele recebe a filtragem da pesquisa pelo Nome")]
        public void EntaoEleRecebeAFiltragemDaPesquisaPeloNome()
        {
            Assert.IsTrue(repositorio.GetByContendoNoNome(pesquisaNome).Any());
        }

        [Then(@"ele recebe a filtragem da pesquisa pela Matricula")]
        public void EntaoEleRecebeAFiltragemDaPesquisaPelaMatricula()
        {
            Aluno aluno = repositorio.GetByMatricula(pesquisaMatricula);
            Assert.NotNull(aluno);
        }
        [Given(@"o coordenador deseja ver os dados de todos os alunos")]
        public void DadoOCoordenadorDesejaVerOsDadosDeTodosOsAlunos()
        {
            repositorio = new RepositoriodoAluno();
        }

        [Then(@"ele recebe os dados de todos os alunos")]
        public void EntaoEleRecebeOsDadosDeTodosOsAlunos()
        {
            Assert.IsTrue(repositorio.GetAll().Any());            
        }

    }
}