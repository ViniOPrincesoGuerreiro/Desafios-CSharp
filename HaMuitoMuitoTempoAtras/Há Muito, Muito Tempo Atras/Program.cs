﻿/*  Raul Seixas cantava que nasceu há 10 mil anos atrás e não tinha nada nesse mundo que ele não sabia demais. Os Mamomas Assassinas cantavam que 
mais de 10 mil anos "se passaram-se" [sic] quando eles repetiram a 5a série. Tantos eventos passados e o professor MC ficou curioso para 
saber em que ano tudo isso aconteceu.

    Você deve escrever um programa que, dada uma série de número de anos transcorridos, mostre, para cada número, em que ano o evento aconteceu. 
Lembre-se de indicar se ele aconteceu A.C. (Antes de Cristo) ou D.C. (Depois de Cristo).



Entrada
    A entrada tem várias linhas. A primeira tem um inteiro positivo N (1 ≤ N ≤ 100000). A seguir existem N linhas. Cada uma dessas N linhas tem 
um único inteiro não negativo T, que indica o número de anos transcorridos até 2015 D.C. (0 ≤ T < 231).

Saída
    A saída tem N linhas. Em cada uma, deve ser indicado o ano A em que o correspondente tempo T aconteceu. Veja o exemplo de saída.*/





using System;
using Há_Muito__Muito_Tempo_Atras.Entities;
using Há_Muito__Muito_Tempo_Atras.Services;

namespace Há_Muito__Muito_Tempo_Atras
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int t = int.Parse(Console.ReadLine());

                ElapsedTime.YearOfEvent(t);
            }
        }
    }
}