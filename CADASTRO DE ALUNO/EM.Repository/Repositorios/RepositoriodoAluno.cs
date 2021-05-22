using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using EM.Domain;
using FirebirdSql.Data.FirebirdClient;
using System.Globalization;
using System.Linq;
using EM.Repository.Exceptions;

namespace EM.Repository
{
    public class RepositoriodoAluno : RepositorioAbstrato<Aluno>
    {
        private string stringConexao = @"User=SYSDBA;password=masterkey;Database=C:\Users\DEV-ESTAGIO-03\Desktop\CADASTRODEALUNOS.FDB;DataSource=localhost;Port=3053;Dialect=3;Charset=NONE;Role=;Connection lifetime = 15; Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size = 8192; ServerType=0";
        private FbConnection Conexaobanco()
        {
            FbConnection conexao = new FbConnection(stringConexao);
            conexao.Open();
            return conexao;
        }
        public override void Add(Aluno objeto)
        {
            FbConnection conexao = Conexaobanco();
            try
            {
                string dataNascimento = objeto.Nascimento.ToString("d", CultureInfo.CreateSpecificCulture("pt-BR"));
                string comando = String.Format(@"INSERT INTO ALUNOS(MATRICULA, NOME, CPF, DATANASCIMENTO, SEXO) VALUES (@Matricula, @Nome, @Cpf, @DataNascimento, @Sexo)");
                FbCommand cmd = new FbCommand(comando, conexao);
                cmd.Parameters.Add("Matricula", objeto.Matricula);
                cmd.Parameters.Add("Nome", objeto.Nome);
                cmd.Parameters.Add("Cpf", objeto.CPF);
                cmd.Parameters.Add("DataNascimento", dataNascimento);
                cmd.Parameters.Add("Sexo", (int)objeto.Sexo);
                cmd.ExecuteNonQuery();
            }            
            catch(FbException fbex)
            {
                //var teste = fbex.Message.Contains("Problematic key value is (\"MATRICULA\"");
                if (fbex.Message.Contains("Problematic key value is (\"MATRICULA\""))
                    throw new MatriculaJaCadastradaException("MATRICULA JA CADASTRADA NO SISTEMA", null);

                if (fbex.Message.Contains("Problematic key value is (\"CPF\""))
                    throw new CPFJaCadastradoException("CPF JA CADASTRADO NO SISTEMA", null);
                else
                    throw new Exception(fbex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        public override void Remove(Aluno objeto)
        {
            FbConnection conexao = Conexaobanco();
            try
            {
                string comando = String.Format(@"DELETE FROM ALUNOS WHERE MATRICULA = @Matricula");
                FbCommand cmd = new FbCommand(comando,conexao);
                cmd.Parameters.Add("Matricula", objeto.Matricula);
                cmd.ExecuteNonQuery();
            }
            catch(FbException fbex)
            {
                throw new Exception(fbex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        public override void Update(Aluno objeto)
        {
            FbConnection conexao = Conexaobanco();
            if (Get(a => a.CPF == objeto.CPF && a.Matricula != objeto.Matricula).Any())
                throw new CPFJaCadastradoException("CPF JA CADASTRADO", null);            
            try
            {
                string dataNascimento = objeto.Nascimento.ToString("d", CultureInfo.CreateSpecificCulture("pt-BR"));
                string comando = String.Format(@"UPDATE ALUNOS SET NOME = @Nome, CPF = @Cpf, DATANASCIMENTO = @Datanascimento, SEXO = @Sexo WHERE MATRICULA = @Matricula");
                FbCommand cmd = new FbCommand(comando,conexao);
                cmd.Parameters.Add("Nome", objeto.Nome);
                cmd.Parameters.Add("Cpf", objeto.CPF);
                cmd.Parameters.Add("Datanascimento", dataNascimento);
                cmd.Parameters.Add("Sexo", (int)objeto.Sexo);
                cmd.Parameters.Add("Matricula", objeto.Matricula);
                cmd.ExecuteNonQuery();
            }
            catch(FbException fbex)
            {
                throw new Exception(fbex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        public Aluno GetByMatricula(int matricula)
        {
            FbConnection conexao = Conexaobanco();
            Aluno aluno = null;
            try
            {
                string comando = String.Format(@"SELECT * FROM ALUNOS WHERE MATRICULA = @Matricula");
                FbCommand cmd = new FbCommand(comando, conexao);
                cmd.Parameters.Add("Matricula", matricula);
                FbDataReader dtr = cmd.ExecuteReader();

                while (dtr.Read())
                {
                    aluno = new Aluno(Convert.ToInt32(dtr["MATRICULA"]), dtr["NOME"].ToString(), dtr["CPF"].ToString(), dtr["DATANASCIMENTO"].ToString(),dtr["SEXO"].ToString());                 
                }                
            }
            catch (FbException fbex)
            {
                throw new Exception(fbex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return aluno;
        }
        public IEnumerable<Aluno> GetByContendoNoNome(string parteDoNome)
        {
            FbConnection conexao = Conexaobanco();
            var colecaoAlunos = new List<Aluno>();
            try
            {
                string comando = String.Format(@"SELECT * FROM ALUNOS WHERE NOME LIKE '%{0}%'", parteDoNome);
                FbCommand cmd = new FbCommand(comando, conexao);
                FbDataReader dtr = cmd.ExecuteReader();

                colecaoAlunos = FabricaDeAlunos(dtr);
             }         
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Close();
            }            
            return colecaoAlunos;
        }
        public override IEnumerable<Aluno> Get(Expression<Func<Aluno, bool>> predicate)
        {
            return GetAll().Where(predicate.Compile());
        }
        public override IEnumerable<Aluno> GetAll()
        {
            FbConnection conexao = Conexaobanco();
            var listadeAlunos = new List<Aluno>();
            try
            {
                string comando = "SELECT * FROM ALUNOS";
                FbCommand cmd = new FbCommand(comando,conexao);
                FbDataReader dtr = cmd.ExecuteReader();

                listadeAlunos = FabricaDeAlunos(dtr);               
            }
            catch(FbException fbex)
            {
                throw new Exception(fbex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return listadeAlunos;                       
        }        
        public List<Aluno> FabricaDeAlunos(FbDataReader dtr)
        {            
            var listaDeAlunos = new List<Aluno>();
            while (dtr.Read())
            {
                var aluno = new Aluno(Convert.ToInt32(dtr["MATRICULA"]), dtr["NOME"].ToString(), dtr["CPF"].ToString(),dtr["DATANASCIMENTO"].ToString() , dtr["SEXO"].ToString());
                
                listaDeAlunos.Add(aluno);
            }
            return listaDeAlunos;
        }
    }
}
