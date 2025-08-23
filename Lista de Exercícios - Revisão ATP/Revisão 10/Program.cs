using System;
class Program
{
    static void Main(string[] args)
    {
        int canal1 = 0, canal2 = 0, canal3 = 0, canalOutro = 0;
        int op = 0;

        do
        {
            var aux = 0;
            Console.Write("Informe em qual canal você está sintonizado: ");
            op = int.Parse(Console.ReadLine());
            Console.Write("Quantas pessoas estão assistindo? ");
            aux = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    canal1 += aux++;
                    break;
                case 2:
                    canal2 += aux++;
                    break;
                case 3:
                    canal3 += aux++;
                    break;
                default:
                    canalOutro += aux++;
                    break;
            }
        } while (op != 0);

        var total = canal1 + canal2 + canal3 + canalOutro;

        Console.WriteLine("\nPorcentagem de pessoas por canal");
        Console.WriteLine("-------------------------------------");
        System.Console.WriteLine($"Canal 1: {RetornaPorcentagem(total, canal1)}%");
        System.Console.WriteLine($"Canal 2: {RetornaPorcentagem(total, canal2)}%");
        System.Console.WriteLine($"Canal 3: {RetornaPorcentagem(total, canal3)}%");
        System.Console.WriteLine($"Outros Canais: {RetornaPorcentagem(total, canalOutro)}%");
    }

    static double RetornaPorcentagem(int total, int parteAnalisada) => Math.Round(total / 100 * parteAnalisada * 1.0, 2);

}