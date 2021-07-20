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
                var buffer = new byte[1024]; // 1kb

                var numeroDeBytesLidos = -1;

                while(numeroDeBytesLidos != 0)
                {
                    numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                    EscreverBuffer(buffer, numeroDeBytesLidos);
                }

                //Internamente o IDisposable chama o fluxoDoArquivo.Close(); e libera o arquivo para ser utilziado e
                //verifica se o arquivo fluxoDoArquivo é nulo

            }
            Console.ReadLine();
        }
        static void EscreverBuffer(byte[] buffer, int bufferLidos)
        {
            var utf8 = UTF8Encoding.Default;

            var texto = utf8.GetString(buffer, 0, bufferLidos);
            Console.WriteLine(texto);


            //foreach (var meuByte in buffer)
            //{
            //    Console.Write(meuByte);
            //    Console.Write(" ");
            //}
        }
    }
} 
 