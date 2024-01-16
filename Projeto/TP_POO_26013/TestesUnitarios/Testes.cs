/*
* Descrição: Criação do Projeto
* Nome: Pedro Rei
* Contacto: pedro28rei@gmail.com
* Data: 12/12/2023
* LESI - POO
* 
*/

using System;
using BaseDados;
using ObjetosNegocio;

namespace TestesUnitarios
{
    [TestClass]
    /// <summary>
    /// A classe Main onde se encontra os testes unitários
    /// </summary>
    public class Testes
    {
        #region TestesUnitarios

        [TestMethod]
        /// <summary>
        /// Método que permite testar o método inserir Cliente, true em caso de sucesso e false caso o oposto
        /// </summary>
        public void AdicionarClienteTeste()
        {
            DateTime dt = new DateTime();

            Cliente cl1 = new Cliente("Pedro", 22, dt, "Masculino", "Ferreiros", 1, 222222, 22232333, 989898332, "pedro28rei@gmail.com", 500);

            bool resultado;

            if (cl1.CodigoCliente <= 0 || cl1.Nome == null || cl1.Idade < 18 || cl1.Nif <= 0)
            {
                resultado = false;
            }
            else
            {
                resultado = true;
            }
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        /// <summary>
        /// Método que permite testar o adicionarVendedorTeste, retorna true em caso de sucesso e false caso o oposto
        /// </summary>
        public void AdicionarVendedorTeste()
        {
            DateTime dt = new DateTime();

            Vendedor vendedor = new Vendedor("Marco", 40, dt, "Masculino", "Ferreiros", 5, "22/22/2002", 222222, 22232333, 989898332, 1, "marcoantonio@gmail.com");

            bool resultado;

            if (vendedor.IdVendedor <= 0 || vendedor.CodigoTrabalhador <= 0 || vendedor.Salario < 820 || vendedor.Idade < 18 ||
        vendedor.Nome == string.Empty || vendedor.AnosServico < 0 || vendedor.NivelCargo < 0) resultado = false;
            else
            {
                resultado = true;
            }
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        /// <summary>
        /// Método que permite testar AdicionarCarroTeste, retorna true em caso de sucesso e false caso o oposto
        /// </summary>
        public void AdicionarCarroTeste()
        {
            
            Carro carro = new Carro();

            bool resultado;

            if (carro.CodigoAutomovel <= 0 || carro.CodigoCarro <= 0 || carro.Cavalos < 20 || carro.Matricula == string.Empty ||
        carro.Preco <= 100 || carro.DataFabrico == string.Empty) resultado = false;
            else
            {
                resultado = true;
            }
            Assert.IsTrue(resultado);
        }

        #endregion
    }
}
