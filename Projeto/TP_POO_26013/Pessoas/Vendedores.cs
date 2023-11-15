/*
* Descrição: Realização da classe Vendedores
* Nome: Pedro Rei
* Contacto: pedro28rei@gmail.com
* Data: 10/11/2023
* LESI - POO
* 
* 
*/

namespace Pessoas
{
    /// <summary>
    /// Classe vendedores que contem vários  vendedores
    /// </summary>
    public class Vendedores
    {
        #region ATRIBUTOS

        public const int MAXVENDEDORES = 100;
        private Vendedor[] listaVendedores;


        #endregion

        #region METODOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor por omissão que cria lista de vendedores, sem parâmetros definidos
        /// </summary>
        public Vendedores()
        {
            listaVendedores = new Vendedor[MAXVENDEDORES];
        }


        /// <summary>
        /// Construtor por omissão que cria lista de clientes, com parâmetros definidos
        /// </summary>
        /// <param name="MAXCLIENTES"></param>
        /// <param name="listaClientes"></param>
        public Vendedores(int MAXVENDEDORES, Vendedor[] listaVendedores)
        {
            this.listaVendedores = listaVendedores;
        }


        #endregion

        #region PROPRIEDADES

        /// <summary>
        /// Propriedade de leitura que fornece uma copia do array vendedor
        /// </summary>
        public Cliente[] ListaVendedores
        {

            get { return (Cliente[])listaVendedores.Clone(); }
        }


        #endregion


        #region OVERRIDES

        /// <summary>
        /// Override ToString da classe Vendedores
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString();
        }

        #endregion

        #endregion
    }
}
