using System;
using System.Data.Common;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuPrincipal();
        }

        static void MenuPrincipal()
        {
            Console.Clear();
           Console.WriteLine("Seja Bem-Vindo! Oque deseja?");
           Console.WriteLine("1 - Contagem normal");
           Console.WriteLine("2 - Contagem regressiva");

           int e = int.Parse(Console.ReadLine());

           if (e == 1)
            Menu();

           if (e == 2)
            Menu2();
        }

        static void Menu2()
        {
            Console.Clear();
            Console.WriteLine("S - Segundos ex: 2s = 2Segundos");
            Console.WriteLine("M - Minutos - ex: 2m = 2Minutos");
            Console.WriteLine("Insira o o número para começar");
            Console.WriteLine("0 - sair");
            string tipo = Console.ReadLine().ToLower();
            char l = char.Parse(tipo.Substring(tipo.Length - 1, 1));
            int time2 = int.Parse(tipo.Substring(0, tipo.Length -1));
            int m = 1;

            if (l == 'm')
            m = 60;

            if (time2 == 0)
            System.Environment.Exit(0);

            time2 = time2 * m;

            PreStart2(time2);
        }

        static void PreStart2(int time2)
        
        {
            Console.Clear();
            Console.WriteLine("Preparar...");
            Thread.Sleep(2000);
            Console.WriteLine("Apontar...");
            Thread.Sleep(2000);
            Console.WriteLine("Contar!!!!!");
            Thread.Sleep(1000);
            
            Start2(time2);

        }

        static void Start2(int time2)
        {
            Console.Clear();

            for (int cont = time2; cont != 0; cont--)
            {
                Console.WriteLine(cont);
                Thread.Sleep(1000);
                Console.Clear();
            } 
            
            Console.WriteLine("Fim da partida");
            Thread.Sleep(1000);

            MenuPrincipal();


        }

        static void Start(int time)
        {
            int currenTime = 0;
            while (currenTime != time)
            {
                Console.Clear();
                currenTime++;
                Console.WriteLine(currenTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Stopwatch finalizado!");
            Thread.Sleep(2500);
            MenuPrincipal();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo - Ex: 10s = 10 segundos");
            Console.WriteLine("M = Minuto - Ex:1m = 1 minuto ");
            Console.WriteLine("Quanto tempo deseja contar?");
            Console.WriteLine("0 = sair");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length -1));
            int multiplier = 1;

            if (type == 'm')
            multiplier = 60;

            if (time == 0)
            System.Environment.Exit(0);

            PreStart(time * multiplier);
    
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Preparar...");
            Thread.Sleep(1000);
            Console.WriteLine("Apontar...");
            Thread.Sleep(1000);
            Console.WriteLine("Jaaa!!!!");
            Thread.Sleep(2000);

            Start(time);

        }

    }
}