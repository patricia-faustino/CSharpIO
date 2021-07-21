using ByteBankImportacaoExportacao.Modelos;
using System;


using System.IO; //IO = Input and Output

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //utilizar esses métodos caso não estoure a memória do computador
            File.WriteAllText("escrevendoComAClasseFile.txt", "Testado File.WriteAllText");
            Console.WriteLine("Arquivo escrevendoComAClasseFile.txt criado");


            var bytes = File.ReadAllBytes("contas.txt");
            Console.WriteLine($"Arquivo contas.txt possui {bytes.Length} bytes");

            //lê todas as linhas do arquivo
            var linhas = File.ReadAllLines("contas.txt");
            Console.WriteLine(linhas.Length);

            foreach (var linha in linhas)
            {
                Console.WriteLine(linha);
            }

            LeituraBinaria();
            Console.WriteLine("Aplicacao Finalizada.....");

            Console.ReadLine();
        }


    }
}
