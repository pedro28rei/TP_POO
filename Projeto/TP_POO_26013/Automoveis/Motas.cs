/*
* Descrição: Elaboração da classe Motas
* Nome: Pedro Rei
* Contacto: pedro28rei@gmail.com
* Data: 15/11/2023
* LESI - POO
* 
* 
*/

namespace Automoveis
{
    /// <summary>
    /// Classe Motas, que contém varios objetos do tipo Mota
    /// </summary>
    public class Motas
    {

        #region ATRIBUTOS


        public const int MAXMOTAS = 2000;
        private Mota[] listaMotas;

        #endregion


        #region METODOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor por omissão que cria lista de motas, sem parâmetros definidos
        /// </summary>
        public Motas()
        {
            listaMotas = new Mota[MAXMOTAS];
        }


        /// <summary>
        /// Construtor por omissão que cria lista de motas, com parâmetros definidos
        /// </summary>
        /// <param name="MAXCLIENTES"></param>
        /// <param name="listaClientes"></param>
        public Motas(int MAXMOTAS, Mota[] listaMotas)
        {
            this.listaMotas = listaMotas;
        }


        #endregion

        #region PROPRIEDADES

        /// <summary>
        /// Propriedade de leitura que fornece uma copia do array mota
        /// </summary>
        public Mota[] ListaMotas
        {

            get { return (Mota[])listaMotas.Clone(); }
        }

        #endregion


        #region OVERRIDES

        /// <summary>
        /// Override ToString da classe Motas
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
