using System;

namespace Pilha
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = new Pilha();
            //Empilhar
            Console.WriteLine("Empilhando Itens");

            num.Empilha(1);
            num.Empilha(10);
            num.Empilha(100);
            num.Empilha(120);
            num.Empilha(174);
            num.Empilha(204);

            //Desempilhar do Topo
            Console.WriteLine("Itens Desempilhados");
            Console.WriteLine(num.Desempilha());
            Console.WriteLine(num.Desempilha());
        }
    }
}
