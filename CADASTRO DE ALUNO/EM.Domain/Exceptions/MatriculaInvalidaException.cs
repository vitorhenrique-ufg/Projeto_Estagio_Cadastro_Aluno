using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Domain.Exceptions
{
    public class MatriculaInvalidaException : Exception
    {
        public MatriculaInvalidaException(string mensagem, Exception inner) : base(mensagem, inner) { }
    }
}
