using System;

namespace Aula19Dojo2
{
    public class IngressoVip : Ingresso
    {
        public float valorAdicional = 50.0f;

        public void AdicionarValor(){
            float newValor = IngressoPreco + valorAdicional;
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine("O valor VIP é : {0}",newValor);
            Console.ResetColor();
        }
    }
}