using System;

namespace Aula19Dojo2
{
    //Bia linda
    class Program
    {
        static void Main(string[] args)
        {
            IngressoVip bilhete = new IngressoVip();
            bilhete.IngressoPreco = 15.99f;
            bilhete.ImprimirValor();
            bilhete.AdicionarValor();

            System.Console.WriteLine("A diferença de valores é : " + bilhete.valorAdicional);
        }
    }
}
