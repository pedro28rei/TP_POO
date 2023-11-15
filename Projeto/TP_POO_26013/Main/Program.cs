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
using Automoveis;


namespace Main
{ 
    /// <summary>
    /// A classe que vai ser a main onde se encontra o programa
    /// </summary>
    internal class Program
    {
        static void Main()
        {

            DateTime dt = new DateTime(2023, 11, 15, 10, 30, 0);

            Pessoa p1 = new Pessoa("Pedro", 20, dt , "Masculino" , "Ferreiros" );
            Automovel a1 = new Automovel();


            Console.ReadKey();
        }
    }
}
