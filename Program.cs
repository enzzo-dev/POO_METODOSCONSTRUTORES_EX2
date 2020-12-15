using System;
using POO_METODOSCONSTRUTORES_EX2.classes;

namespace POO_METODOSCONSTRUTORES_EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            Produtos produto1 = new Produtos();
            produto1.Codigo = 1;
            produto1.Nome = "Coca-cola";
            produto1.Descricao = "Este é a nova Coca-cola";
            produto1.Estoque = 20;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Código  = {produto1.Codigo} , Nome = {produto1.Nome} , Descrição = {produto1.Descricao} , Estoque = {produto1.Estoque}");
            Console.ResetColor();
        }
    }
}
