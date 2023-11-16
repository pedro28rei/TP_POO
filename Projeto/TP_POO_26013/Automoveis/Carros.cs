/*
* Descrição: Realização da classe Carros
* Nome: Pedro Rei
* Contacto: pedro28rei@gmail.com
* Data: 08/11/2023
* LESI - POO
* 
* 
*/

namespace Automoveis
{
    /// <summary>
    /// Classe Carros
    /// </summary>
    public class Carros
    {
        #region ATRIBUTOS

        public const int MAXCARROS = 2000;
        private Carro[] listaCarros;


        #endregion


        #region METODOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor por omissão que cria lista de carros, sem parâmetros definidos
        /// </summary>
        public Carros()
        {
            listaCarros = new Carro[MAXCARROS];
        }


        /// <summary>
        /// Construtor por omissão que cria lista de carros, com parâmetros definidos
        /// </summary>
        /// <param name="MAXCLIENTES"></param>
        /// <param name="listaClientes"></param>
        public Carros(int MAXCARROS, Carro[] listaCarros)
        {
            this.listaCarros = listaCarros;
        }


        #endregion

        #region PROPRIEDADES

        /// <summary>
        /// Propriedade de leitura que fornece uma copia do array carro
        /// </summary>
        public Carro[] ListaClientes
        {

            get { return (Carro[])listaCarros.Clone(); }
        }


        #endregion


        #region OVERRIDES

        /// <summary>
        /// Override ToString da classe Carros
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
