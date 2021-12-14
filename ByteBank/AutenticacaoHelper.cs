using System;
using System.Collections.Generic;
using System.Text;

namespace _5_Aula01Parte02
{
    internal class AutenticacaoHelper
    {
        public bool CompararSenhas(string senhaVerdadeira, string senhaTentativa)
        {
            return senhaVerdadeira == senhaTentativa;
        }
    }
}
