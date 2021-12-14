using System;
using System.Collections.Generic;
using System.Text;

namespace _5_Aula01Parte02
{
    class ClasseTeste
    {
        public ClasseTeste()
        {
            ModificadoresTeste teste = new ModificadoresTeste();
            teste.MetodoPublico();

            teste.MetodoInterno();
        }
    }

    public class ModificadoresTeste
    {
        public void MetodoPublico()
        {
            //Visível fora da classe "ModificadoresTeste".
        }
        private void MetodoPrivado()
        {
            //Visível apenas na classe "ModificadoresTeste".
        }

        protected void MeotodoProtegido()
        {
            //Visível apenas na classe "ModificadoresTeste" e derivados.
        }

        internal void MetodoInterno()
        {
            // Visivel apenas para a pasta em que se encontra. 
        }
    }
}