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

            DateTime dt = new DateTime(2023, 11, 15, 10, 30, 0);

            Pessoa p1 = new Pessoa("Pedro", 20, dt , "Masculino" , "Ferreiros" );
            Pessoa p2 = new Pessoa("Pedro", 22, dt, "Masculino", "Ferreiros");

            Cliente c1 = new Cliente();
            
            //Cliente c2 = new Cliente("Pedro", 21, dt, "masculino", "Ferreiros", 20039292, 222, 22, 22, "pedro" , 23);

            //Console.WriteLine("" + c1.Nome + "" + c1.CodigoCliente);
            Console.WriteLine(c1.ToString());

            if (p1 == p2)
            {
                Console.WriteLine(p2.ToString());
            }

            //Trabalhador t1 = new Trabalhador("Pedro", 21, dt, "masculino", "Ferreiros", 20039292, "Stand Faria", 34);
            //Console.WriteLine("|Nome: {0} | Idade: {1}  | Data Nascimento: {2} | Sexo: {3} | Morada: {4} | Código: {5} |Stand: {6} |Anos servico: {7}", t1.Nome, t1.Idade, t1.DataNascimento, t1.Sexo, t1.Morada, t1.CodigoTrabalhador, t1.Stand, t1.AnosServico);


            Console.ReadKey();
        }
    }
}
