﻿using System;

namespace CorreçãoQuestao2
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            double peso = 0;
            double altura = 0;
            double ResultadoIMC = 0;


            Console.WriteLine("Digite o seu Peso : ");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua Altura : ");
            altura = double.Parse(Console.ReadLine());

            IMC m = new IMC();
            ResultadoIMC = m.Calcular(peso, altura);


            Console.WriteLine("O seu IMC é : " + ResultadoIMC);

            Console.WriteLine("Você está com a classificaçào " + m.Classificar(ResultadoIMC));

            if (ResultadoIMC < 16)
            {
                Console.WriteLine("Magreza Grave");
                Console.ReadKey();
            }
            if (ResultadoIMC <= 17)
            {
                Console.WriteLine("Magreza Moderada");
            }
            if (ResultadoIMC >= 16)
            {
                Console.WriteLine("Magreza Moderada");
            }

            if (ResultadoIMC >= 17)
            {
                Console.WriteLine("Magreza Leve");
            }
            if (ResultadoIMC <= 18.5)
            {
                Console.WriteLine("Magreza Leve");
            }
            if (ResultadoIMC <= 25)
            {
                Console.WriteLine("Saudável");
            }
            if (ResultadoIMC <= 30)
            {
                Console.WriteLine("Sobrepeso");
            }
        }
    }
}