using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Repository.Exceptions
{
    public class MatriculaJaCadastradaException : Exception
    {
        public MatriculaJaCadastradaException(string mensagem, Exception inner) : base(mensagem, inner) { }
    }
}
