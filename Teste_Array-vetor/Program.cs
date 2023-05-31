﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Array_vetor
{
    internal class Program
    {
            public static void exemplo1() 
            {
            int[] vet2;
            Console.WriteLine("entre com um tamanho:");
            int i = int.Parse(Console.ReadLine());

            vet2 = new int[i];

            for (int t = 0; t < i; t++)
            {
                Console.WriteLine("Digite o valor p/ posição [" + (t + 1) + "]");
                vet2[t] = int.Parse(Console.ReadLine());
            }
            for (int t = 0; t < i; t++)
            {
                Console.WriteLine("posição [" + (t + 1) + "]" + vet2[t]);
            }
            Console.ReadKey();
        }
            public static void exemplo2() 
            {
            int[] vet3;
            Console.WriteLine("entre com um tamanho:");
            int r = int.Parse(Console.ReadLine());

            vet3 = new int[r];

            Random rand = new Random(); //criação de números aleatórios

            for (int y = 0; y < r; y++)
            {
                vet3[y] = rand.Next(10, 50); // números aleatórios de 10 á 50
            }
            for (int y = 0; y < r; y++)
            {
                Console.WriteLine("posição [" + (y + 1) + "]" + vet3[y]);
            }
            Console.ReadKey();
        }
            public static void exercício1()
            {
            int[] vet2;
            float soma = 0, div;
            Console.WriteLine("Entre com o tamanho: ");
            int t = int.Parse(Console.ReadLine());

            vet2 = new int[t];
            Random rand = new Random();

            for (int i = 0; i < t; i++)
            {
                vet2[i] = rand.Next(10, 50);// rand.Next() cria números aleatório
                soma += vet2[i];
            }
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("Põsição[{0}] = {1}", i, vet2[i]);
            }
            div = soma / t;
            Console.WriteLine("A média é: " + div);

        }
            public static void exercício2()
            {
            int[] vet2;
            float soma = 0, div;
            Console.WriteLine("Entre com o tamanho: ");
            int t = int.Parse(Console.ReadLine());

            vet2 = new int[t];
            Random rand = new Random();

            for (int i = 0; i < t; i++)
            {
                vet2[i] = rand.Next(10, 50);// rand.Next() cria números aleatório
                soma += vet2[i];
            }
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("Põsição[{0}] = {1}", i, vet2[i]);
            }
            div = soma / t;
            Console.WriteLine("A média é: " + div);

        }

        static void Main(string[] args)
        {
            //declaração 
            int[] vet = new int[6]; //vet [0,1,2,3,4,5]
            
            //atribuição de valores para cada índice, exemplo 1
            vet[0] = 7;
            vet[5] = 26;

            int opcao; 

            Console.WriteLine("___Menu___");
            Console.WriteLine("Exercício 1 - digite 1");
            Console.WriteLine("Exercício 2 - digite 2");
            Console.WriteLine("Exercício 3 - digite 3");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao) 
            {
                case 1:
                    //atribuição de valores para cada índice, exemplo 2 + laços de repetição (Exercício 1)
                    //Console.WriteLine("Exemplo 2");
                    exemplo1();                   
                    break;
                case 2:
                    //atribuição de valores para cada índice, exemplo 3 + laços de repetição (Exercício 2)
                    //Console.WriteLine("Exemplo 3");
                    exemplo2();
                    break; 
                case 3:
                    // Exercício 1
                    exercício1();
                    break;
                case 4:
                    // Exercício 2
                    exercício2();
                    break;
            }




       


        }
    }
}
