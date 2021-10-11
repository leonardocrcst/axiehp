using System;

namespace AxieHP
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 2) {
                int hbase = Int32.Parse(args[0]);
                int nivel = Int32.Parse(args[1]);
                Double maxhp = (hbase * 6 + 150) * Math.Pow(1.05, (nivel - 1));
                Console.Write("Saúde máxima do Axie: ");
                Console.WriteLine(maxhp.ToString());
            } else {
                Console.WriteLine("Número de argumentos inválido. Para calcular a saúde máxima de um Axie, informe o valor base e o nível do Axie. Exemplo: \"AxieHP 53 1\"");
            }
        }
    }
}
