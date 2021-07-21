using ByteBankImportacaoExportacao.Modelos;
using System;
using System.IO;
using System.Text;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void CriandoArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "456, 78945, 4785.50, Gustavo Santos";

                var encoding = Encoding.UTF8;

                var bytes = encoding.GetBytes(contaComoString);

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);
            }

        }

        static void CriarArquivoComWriter()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.CreateNew))
            using(var escritor = new StreamWriter(fluxoDeArquivo, Encoding.UTF8))
            {
                //usa encoding padrão caso não seja explicitado

                escritor.Write("456, 78945, 78456.50, Pedro");
            }
                 
            
        }

        static void TesteEscrita()
        {
            var caminhoNovoArquivo = "teste.txt";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using(var escritor =  new StreamWriter(fluxoDeArquivo, Encoding.UTF8))
            {

                escritor.Write("Linha 0");

                for(int i = 0; i < 1000000000; i++)
                {
                    escritor.WriteLine($"Linha {i}");
                    escritor.Flush(); // Despeja o buffer para o Stream! : guarda o que está sendo escrito em tempo real
                    Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter para adicionar mais uma");
                    Console.ReadLine();
                }
            }

        }
    }
}
