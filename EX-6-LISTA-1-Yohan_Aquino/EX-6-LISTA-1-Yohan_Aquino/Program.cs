using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_6_LISTA_1_Yohan_Aquino
{
    class Program
    {
        static void Main(string[] args)
        {
            /*7. Entrar via teclado com o valor da cotação do dólar e uma certa quantidade de dólares.
Calcular e exibir o valor correspondente em Reais (R$). */
            Conversor con =new Conversor();

            Console.WriteLine("Digite a cotação do dólar: ");
            con.setCotacao(double.Parse(Console.ReadLine()));

            Console.WriteLine("Digite a sua quantia em dólar: ");
            con.setDolar(double.Parse(Console.ReadLine()));

            con.calcularReal();
            Console.WriteLine("O seu dinheiro em reais é {0}",con.getReal());
            Console.ReadKey();
        }
    }
}
