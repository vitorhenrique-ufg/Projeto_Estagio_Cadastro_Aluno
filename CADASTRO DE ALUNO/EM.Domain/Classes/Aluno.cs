﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using EM.Domain.Exceptions;
using FirebirdSql.Data.FirebirdClient;

namespace EM.Domain
{
    public enum EnumeradorSexo
    {
        Masculino = 0,
        Feminino = 1
    }
    public class Aluno : IEntidade
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public EnumeradorSexo Sexo { get; set; }
        public DateTime Nascimento { get; set; }
        public string CPF { get; set; }
        public Aluno(int matricula, string nome, string cpf, string dataNascimento, string sexo)
        {
            Matricula = ValidaMatricula(matricula);
            Nome = ValidaNome(nome);
            CPF = ValidaCpf(cpf);
            Nascimento = ValidaDataNascimento(dataNascimento);
            Sexo = (EnumeradorSexo)Enum.Parse(typeof(EnumeradorSexo), sexo);            
        }
        public override bool Equals(object objeto)
        {
            Aluno novoAluno = (Aluno)objeto;

            if (novoAluno.Matricula == Matricula || novoAluno.CPF == CPF)
                return true;
            else
                return false;
        }
        public override int GetHashCode()
        {
            return Matricula;
        }
        public override string ToString()
        {
            return String.Format(@"Nome Aluno: '{0}' - Matricula: {1} - Cpf: '{2}' - Data de Nascimento: {3} - Sexo: {4}", Nome, Matricula, CPF, Nascimento, Sexo);
        }
        public string ValidaCpf(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
                return null;

            string novePrimeirosDigitos;
            string doisUltimosDigitos;
            int resultado = 0;
            int resto = 0;
            int verifica = 0;
            int[] verificadorPrimeiroDigito = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] verificadorSegundoDigito = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Equals("00000000000") || cpf.Equals("11111111111") || cpf.Equals("22222222222") || cpf.Equals("33333333333")
                || cpf.Equals("44444444444") || cpf.Equals("55555555555") || cpf.Equals("66666666666") ||
                cpf.Equals("77777777777") || cpf.Equals("88888888888") || cpf.Equals("99999999999"))
                throw new CpfInvalidoException("CPF INFORMADO INVALIDO", null);

            if (cpf.Length != 11)
                throw new CpfInvalidoException("CPF INFORMADO INVALIDO MENOR QUE 11 DIGITOS", null);

            novePrimeirosDigitos = cpf.Substring(0, 9);
            doisUltimosDigitos = cpf.Substring(9);
            for (int indice = 0; indice < 9; indice++)
            {
                resultado += Convert.ToInt32(cpf[indice].ToString()) * verificadorPrimeiroDigito[indice];
            }
            resto = resultado % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            if (resto == Convert.ToInt32(doisUltimosDigitos[doisUltimosDigitos.Length - 2].ToString()))
                verifica++;
            resultado = 0;

            for (int indice = 0; indice < 10; indice++)
            {
                resultado += Convert.ToInt32(cpf[indice].ToString()) * verificadorSegundoDigito[indice];
            }
            resto = resultado % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            if (resto == Convert.ToInt32(doisUltimosDigitos[doisUltimosDigitos.Length - 1].ToString()))
                verifica++;

            if (!(verifica == 2))
                throw new CpfInvalidoException("CPF INFORMADO INVALIDO", null);

            return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
        }
        public DateTime ValidaDataNascimento(string dataNascimento)
        {
            DateTime database = new DateTime(1969, 12, 31);
            //DateTime.Today.Year - Nascimento.Year > 50;
            
            try
            {
                Nascimento = DateTime.ParseExact(dataNascimento, "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("pt-BR"));
            }
            catch
            {
                throw new DataNascimentoInvalidaException("DATA INFORNADA NAO EXISTE OU FORMATO INCORRETO", null);
            }

            if (Nascimento.Date >= DateTime.Today)
                throw new DataNascimentoInvalidaException("NAO E PERMITIDO DATA DE NASCIMENTO FUTURA OU DATA DO DIA ATUAL", null);

            if (DateTime.Compare(Nascimento,database) <= 0)
                throw new DataNascimentoInvalidaException("NAO E PERMITIDO ALUNOS ACIMA DOS 50 ANOS", null);
            return Nascimento;
        }
        public string ValidaNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome) || nome.Length > 100)
                throw new NomeInvalidoExceptions("NOME PRECISA TER NO MINIMO 1 E NO MAXIMO 100 CARACTERE", null);
            return nome;
        }
        public int ValidaMatricula(int matricula)
        {
            if (!(matricula >= 1 && matricula <= 999999999))
                throw new MatriculaInvalidaException("MATRICULA PRECISA TER 1 E NO MAXIMO 9 DIGITOS", null);
            return matricula;
        }
    }
}
