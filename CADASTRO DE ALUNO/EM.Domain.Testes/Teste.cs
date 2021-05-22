using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Domain.Testes
{
    class Teste
    {
            private decimal Matricula { get; set; }
            private int TamanhoMaximodeDigitosDaMatricula { get; set; }
            private decimal numeroCpf { get; set; }
            private DateTime dataNascimento { get; set; }
            private string Mensagem { get; set; }            
            public decimal NumeroDeMatricula
            {
                get => Matricula;
                set => Matricula = value;
            }
            public int TamanhoDeDigitosDaMatricula
            {
                set => TamanhoMaximodeDigitosDaMatricula = value;
            }
            public void VerificarMatricula()
            {
                int tamanhoMinimo = 1;
                string matricula = Matricula.ToString();

                if (matricula.Length < tamanhoMinimo || matricula.Length > TamanhoMaximodeDigitosDaMatricula)
                    Mensagem = "Matricula Informada Invalida";
                else
                    Mensagem = "Matricula Valida";
            }
            public decimal CadastrarNumeroCpf
            {
                set => numeroCpf = value;
            }
            public void VerificarValidadeCpf()
            {
                string verifica = numeroCpf.ToString();
                int primeiroDigitoComparador;
                int segundoDigitoComparador;
                int resto = 0;
                int soma = 0;
                int flag1 = 10;
                int verificador = 0;

                primeiroDigitoComparador = Convert.ToInt32(verifica[9].ToString());
                segundoDigitoComparador = Convert.ToInt32(verifica[10].ToString());

                for (int i = 0; i < verifica.Length - 2; i++)
                {
                    var aux = verifica[i].ToString();
                    soma += Convert.ToInt32(verifica[i].ToString()) * flag1;
                    flag1--;
                }
                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                if (resto == primeiroDigitoComparador)
                {
                    verificador++;
                }
                resto = 0;
                soma = 0;
                flag1 = 11;
                for (int i = 0; i < verifica.Length - 2; i++)
                {
                    soma += Convert.ToInt32(verifica[i].ToString()) * flag1;
                    flag1--;
                }
                soma += flag1 * primeiroDigitoComparador;
                resto = soma % 11;

                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                if (resto == segundoDigitoComparador)
                    verificador++;

                if (verificador == 2)
                    Mensagem = "CPF VALIDO";
                else
                    Mensagem = "CPF E INVALIDO";
            }
            public void AdicionarData(int dia, int mes, int ano)
            {
                try
                {
                    dataNascimento = new DateTime(ano, mes, dia);
                }
                catch
                {
                    Mensagem = "DATA DE NASCIMENTO INVALIDA";
                }
            }
            public void VerificarValidadeDaData()
            {
                DateTime dataBase = new DateTime(2000, 1, 1);

                if (DateTime.Compare(dataBase, dataNascimento) > 0)
                {
                    Mensagem = "DATA DE NASCIMENTO INVALIDA";
                }
                else
                {
                    Mensagem = "DATA VALIDA";
                }
            }
            public string MensagemDeValidacao
            {
                get => Mensagem;
            }
        }
    }
