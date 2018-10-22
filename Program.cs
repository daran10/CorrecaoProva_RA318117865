using System;

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

          
        }
    }
}