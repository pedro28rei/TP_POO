/*
* Descrição: Criação do Projeto
* Nome: Pedro Rei
* Contacto: pedro28rei@gmail.com
* Data: 1/11/2023
* LESI - POO
* 
* 
*/

using ObjetosNegocio;
using RegrasNegocio;


namespace Main
{
    /// <summary>
    /// A classe que vai ser a main onde se encontra o programa desenvolvido
    /// </summary>
    internal class Program
    {
        static void Main()
        {   
           
            //Execução dos métodos que permitem a leitura dos ficheiros com os dados dos Automóveis do stand
            Regras.LerFicheiroCarrosBD();
            Regras.LerFicheiroMotasBD();

            //Execução dos métodos que permitem a leitura dos ficheiros com os dados das Funcionários e Clientes do stand
            Regras.LerFicheiroClientesBD();
            Regras.LerFicheiroVendedoresBD();
            Regras.LerFicheiroAdministradoresBD();
            Regras.LerFicheiroLimpadoresBD();


            //Criação de objetos das várias classes existentes
            Carro c1 = new Carro();
            Mota m1 = new Mota();
            Cliente cl1 = new Cliente();
            Vendedor v1 = new Vendedor();
            Administrador admin1 = new Administrador();
            Limpador limp1 = new Limpador();


            bool aux;

            //Execução dos métodos que permitem adicionar um objeto á respetiva lista que os armazena e aos seus dados
            aux = Regras.AdicionarCarroBD(c1);

            //Execução dos métodos que permitem remover um objeto á respetiva lista que os armazena e aos seus dados
            aux = Regras.RemoverCarroBD(c1);

            //Execução dos métodos que permitem ordenar as listas, neste caso por ordem crescente dos respetivos códigos de identificação
            Regras.OrdernarCarroBD();



            //Execução dos métodos que permitem gravar os dados dos Automóveis nos respetivos ficheiros
            Regras.GuardarFicheiroCarrosBD();
            Regras.GuardarFicheiroMotasBD();

            //Execução dos métodos que permitem gravar os dados dos Funcionários e Clientes nos respetivos ficheiros
            Regras.GuardarFicheiroVendedoresBD();
            Regras.GuardarFicheiroClientesBD();
            Regras.GuardarFicheiroAdministradoresBD();
            Regras.GuardarFicheiroLimpadoresBD(); 

        }
    }
}
