using ByteBankImportacaoExportacao.Modelos;
using System;


using System.IO; //IO = Input and Output

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void Main(string[] args)
        {

            CriarArquivoComWriter();
            Console.WriteLine("Aplicacao Finalizada.....");

            Console.ReadLine();
        }


    }
}
