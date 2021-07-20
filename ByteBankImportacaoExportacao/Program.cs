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
            {
                using(var leitor = new StreamReader(fluxoDoArquivo))
                {
                    while (!leitor.EndOfStream)
                    {
                        var linha = leitor.ReadLine();
                        Console.WriteLine(linha);
                    }
                }

            }
            Console.ReadLine();
        }

    }
} 
 