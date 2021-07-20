using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO; //IO = Input and Output

namespace ByteBankImportacaoExportacao
{
    class Program
    {
        static void Main(string[] args)
        {
            var endereco = "contas.txt";


            using (var fluxoDoArquivo = new FileStream(endereco, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDoArquivo))
            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();

                    var contaCorrente = ConverterContaCorrente(linha);

                    var mensagem = $"Conta número {contaCorrente.Numero}, ag. {contaCorrente.Agencia}. Saldo {contaCorrente.Saldo}, Cliente {contaCorrente.Titular.Nome}";

                    Console.WriteLine(mensagem);
                }
            }


            Console.ReadLine();
        }

        private static ContaCorrente ConverterContaCorrente(string linha)
        {
            var campos = linha.Split(' ');

            var agencia = campos[0];
            var numero = campos[1];
            var saldo = campos[2].Replace('.', ',');
            var nomeTitular = campos[3];

            var titular = new Cliente();
            titular.Nome = nomeTitular;

            var agenciaInt = int.Parse(agencia);
            var numeroInt = int.Parse(numero);
            var saldoDouble = double.Parse(saldo);

            var resultado = new ContaCorrente(agenciaInt, numeroInt);
            resultado.Depositar(saldoDouble);
            resultado.Titular = titular;

            return resultado;
        }
    }
}
