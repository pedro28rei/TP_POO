/*
* Descrição: Realização da classe Clientes
* Nome: Pedro Rei
* Contacto: pedro28rei@gmail.com
* Data: 08/11/2023
* LESI - POO
* 
* 
*/


namespace Pessoas
{
    /// <summary>
    /// Classe Clientes que vai conter vários clientes
    /// </summary>
    internal class Clientes
    {
        #region ATRIBUTOS

        public const int MAXCLIENTES = 999;
        private Cliente[] listaClientes;


        #endregion


        #region METODOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor por omissão que cria lista de clientes, sem parâmetros definidos
        /// </summary>
        public Clientes()
        {
            listaClientes = new Cliente[MAXCLIENTES];
        }


        /// <summary>
        /// Construtor por omissão que cria lista de clientes, com parâmetros definidos
        /// </summary>
        /// <param name="MAXCLIENTES"></param>
        /// <param name="listaClientes"></param>
        public Clientes(int MAXCLIENTES, Cliente[] listaClientes)
        {
            this.listaClientes = listaClientes;
        }


        #endregion

        #region PROPRIEDADES

        /// <summary>
        /// Propriedade de leitura que fornece uma copia do array cliente
        /// </summary>
        public Cliente[] ListaClientes
        {
           
            get { return (Cliente[])listaClientes.Clone(); }
        }


        #endregion


        #region OVERRIDES

        /// <summary>
        /// Override ToString da classe Clientes
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
