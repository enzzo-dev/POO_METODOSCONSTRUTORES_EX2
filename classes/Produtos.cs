using System;

namespace POO_METODOSCONSTRUTORES_EX2.classes
{
    public class Produtos
    {
       public Produtos(){
           Console.WriteLine("Método construtor foi executado");
       }

       public Produtos(int codigo){
           Codigo = codigo;
           Console.WriteLine($"Código inserido foi {Codigo}");
       }

       public Produtos(int codigo, string nome,string descricao, int estoque){
           Codigo = codigo ;
           Nome = nome;
           Descricao = descricao;
           Estoque = estoque;  
       }

       public int Codigo{
           get;set;
       }
       public string Nome{
           get;set;
       }
       public string Descricao{
           get;set;
       }
       public int Estoque{
           get;set;
       }

    }
}