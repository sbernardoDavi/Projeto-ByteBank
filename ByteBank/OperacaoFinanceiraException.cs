﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Aula01Parte02
{
    public class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException()
        {

        }

        public OperacaoFinanceiraException(string mensagem)
            : base(mensagem)
        {

        }

        public OperacaoFinanceiraException(string mensagem, Exception excecaoInterna)
            : base(mensagem, excecaoInterna)
        {

        }
    }
}
