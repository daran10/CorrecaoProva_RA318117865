using System;


namespace ConsoleApp2
{
    class Program
    {
        static int Maior(int a, int b)
        {
            if (a > b)
            {
                return a;

            }
            else
            {
                return b;
            }
        }
            static bool Par( int num)
            {
                int resto = num % 2;
                if (resto == 0)
                    return true;
                else
                    return false;
            }


            static void Main(string[] args)
        {

        }
    }
}
