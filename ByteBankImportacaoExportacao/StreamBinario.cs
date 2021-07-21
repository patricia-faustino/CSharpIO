using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void EscritaBinaria()
        {
            // new BinaryWriter(fs):  escreve de maneira binária o nosso stream, fazendo ter menos preocupação com o espaço ocupado pelo texto
            using (var arquivoFileStream = new FileStream("contaCorrente.txt", FileMode.Create))
            using(var escritor = new BinaryWriter(arquivoFileStream))
            {
                //Ao ser exibido o bloco de notas tenta fazer a conversão de bytes para o tipo informado no Write

                escritor.Write(456); // número da agência
                escritor.Write(5465444); // número da conta
                escritor.Write(4000.50);
                escritor.Write("Gustavo Braga");
            }
        }

        static void LeituraBinaria()
        {
            using (var arquivoFileStream = new FileStream("contaCorrente.txt", FileMode.Open))
            using (var leitor = new BinaryReader(arquivoFileStream))
            {
                var agencia = leitor.ReadInt32();
                var numeroConta = leitor.ReadInt32();
                var saldo = leitor.ReadDouble();
                var titular = leitor.ReadString();

                Console.WriteLine($"{titular}: {agencia}/{numeroConta} {saldo}");

            }

        }
    }
}
