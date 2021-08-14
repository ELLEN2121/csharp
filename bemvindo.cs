using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Programa
{
    static void Main(String[] args)
    {
        Console.WriteLine("testando condicionais");

        int idade = 16;
        int quantidadePessoas = 3;
        bool acompanhado = quantidadePessoas >= 2;

        if (idade >=18 && acompanhado)
        {
            Console.WriteLine("Seja bem vindo"); 
        }
        else
        {
            Console.WriteLine("infelizmente voce nao pode entrar");
        }        
    }
}

