﻿using System;
using System.Globalization;

namespace curso
{
    class Progam
    {
        static void Main(string[] args)
        {

            Console.Write(" Digite a quantidade de nomes que deseja visualizar, em seguida digite os nomes  ");

            int N;
            N = int.Parse(Console.ReadLine());
            string[] vet = new string[N];

            for (int i = 0; i < N; i++)
            {
                vet[i] = Console.ReadLine();

            }

            Console.WriteLine("Nomes lidos: ");
            foreach (string elemento in vet)
            {
                Console.WriteLine(elemento);
            }
            Console.ReadLine();



        }
    }
}