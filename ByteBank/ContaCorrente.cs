using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Aula01Parte02
{
    /// <summary>
    /// Define uma conta corrente do banco ByteBank
    /// </summary>
    public class ContaCorrente
    {
        private static int TaxaOperacao;

        public static int TotalDeContasCriadas { get; private set; }

        public Cliente Titular { get; set; }

        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        public int NumeroConta { get; }
        public int NumeroAgencia { get; }

        private double _saldo = 100;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        /// <summary>
        /// Cria uma instância com os argumentos utilizadas abaixo. 
        /// </summary>
        /// <param name="agencia"> Valor da propriedade <see cref="NumeroAgencia"/>. Deve ser maior que 0 </param>
        /// <param name="numero">Valor da propriedade <see cref="NumeroConta"/>. Deve ser maior que 0 </param>
        public ContaCorrente(int agencia, int numero)
        {
            if (numero <= 0)
            {
                throw new ArgumentException("O argumento agencia deve ser maior que 0.", nameof(agencia));
            }

            if (numero <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que 0.", nameof(numero));
            }

            NumeroAgencia = agencia;
            NumeroConta = numero;

            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }

        /// <summary>
        /// Realiza saque e atualiza o valor de <see cref="Saldo"/>
        /// </summary>
        /// <exception cref="ArgumentException"> Utilizada quando um valor negativo é atribuído ao <paramref name="valor"/></exception>
        ///<exception cref="SaldoInsuficienteException"> Utilizada quando o v\lor de <paramref name="valor"/> é maior que o valor da propriedade <see cref="Saldo"/></exception>
        /// <param name="valor">Representa o valor do saque, deve ser maior que zero e menor que o <see cref="Saldo"/> </param>

        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para o saque.", nameof(valor));
            }

            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para a transferência.", nameof(valor));
            }

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada.", ex);
            }

            contaDestino.Depositar(valor);
        }
    }

}
