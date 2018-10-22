using System;
namespace CorreçãoQuestao2
{
    class IMC
    {
        private double peso;
        private double altura;

        public IMC()
        {
            this.peso = 0.0;
            this.altura = 0.0;

        }

        public IMC(double peso, double altura)
        {
            this.peso = peso;
            this.altura = altura;
        }

        public double Calcular(double peso, double altura)
        {
            return peso / (altura * altura);
        }


        public string Classificar(double m)
        {
            if (m < 16)
            {
                return "Magreza Grave";

            }
            else if (m > 16 && m < 17)
            {
                return "Magreza Moderada";
            }
            else if (m > 17 && m < 18.5)
            {
                return "Magreza Leve";
            }
            else if (m > 18.5 && m < 25)
            {
                return "Saudável";
            }
            else if (m > 25 && m < 30)
            {
                return "Sobrepeso";
            }
            else if (m > 30 && m < 35)
            {
                return "Obesidade Grau I";
            }
            else if (m > 35 && m < 40)
            {
                return "Obesidade Grau II (SEVERA)";
            }
            else if (m > 40)
            {
                return "Obesidade Grau morbida";
            }

            return "";
        }
    }
    }

