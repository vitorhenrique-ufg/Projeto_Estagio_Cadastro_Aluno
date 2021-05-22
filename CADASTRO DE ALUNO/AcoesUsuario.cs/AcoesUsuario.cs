using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EM.Domain;
using EM.Repository;

namespace AcoesUsuario.cs
{
    public class AcoesUsuario<T> where T : Aluno
    {
        RepositoriodoAluno repositorio = new RepositoriodoAluno();        
        public void Adicionar(T objeto) 
        {
            repositorio.Add(objeto);
        }
        public void Remover(T objeto)
        {
            repositorio.Remove(objeto);
        }
        public void Atualizar(T objeto)
        {
            repositorio.Update(objeto);
        }
        public IEnumerable<Aluno> AlunosCadastradosNoSistema()
        {
            return repositorio.GetAll().OrderBy(a => a.Matricula);
        }
        public IEnumerable<Aluno> PesquisarMatriculaOuParteDoNome(string pesquisa)
        {
            int matricula;
            Aluno alunoEncontrado;
            IEnumerable<Aluno> alunosEncontradosPeloNome;

            if(int.TryParse(pesquisa, out matricula))
            {
                alunoEncontrado =  repositorio.GetByMatricula(matricula);
                List<Aluno> alunoEncontradoPelaMatricula = new List<Aluno>();
                if (!(alunoEncontrado == null))
                    alunoEncontradoPelaMatricula.Add(alunoEncontrado);                   

                return alunoEncontradoPelaMatricula;
            }
            else
            {
                alunosEncontradosPeloNome = repositorio.GetByContendoNoNome(pesquisa).OrderBy(a => a.Matricula);
                return alunosEncontradosPeloNome;
            }            
        }        
    }
}
