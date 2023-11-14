/*
* Descrição: Criação do Projeto
* Nome: Pedro Rei
* Contacto: pedro28rei@gmail.com
* Data: 1/11/2023
* LESI - POO
* 
* 
*/


using System;
using Pessoas;


namespace Main
{
    /// <summary>
    /// A classe que vai ser a main onde se encontra o programa
    /// </summary>
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World");

            Pessoa p1 = new Pessoa();

            Console.WriteLine("Nome: {0} | Idade: {1}", p1.Nome, p1.Idade);

            Console.ReadKey();
        }
    }
}
