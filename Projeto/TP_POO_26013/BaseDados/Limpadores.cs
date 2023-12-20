/*
* Descrição: Realização da classe Limpadores
* Nome: Pedro Rei
* Contacto: pedro28rei@gmail.com
* Data: 08/11/2023
* LESI - POO
* 
* 
*/


namespace BaseDados
{
    /// <summary>
    /// Classe Limpadores que vai conter vários limpadores
    /// </summary>
    public class Limpadores
    {
        #region ATRIBUTOS

        public const int MAXLIMPADORES = 250;
        private Limpador[] listaLimpadores;


        #endregion


        #region METODOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor por omissão que cria lista de clientes, sem parâmetros definidos
        /// </summary>
        public Limpadores()
        {
            listaLimpadores = new Limpador[MAXLIMPADORES];
        }


        /// <summary>
        /// Construtor por omissão que cria lista de limpadores, com parâmetros definidos
        /// </summary>
        /// <param name="MAXCLIENTES"></param>
        /// <param name="listaClientes"></param>
        public Limpadores(int MAXCLIMPADORES, Limpador[] listaLimpadores)
        {
            this.listaLimpadores = listaLimpadores;
        }

        #endregion


        #region PROPRIEDADES

        /// <summary>
        /// Propriedade de leitura que fornece uma copia do array limpadores
        /// </summary>
        public Limpadores[] ListaLimpadores
        {

            get { return (Limpadores[])listaLimpadores.Clone(); }
        }


        #endregion


        #region OVERRIDES

        /// <summary>
        /// Override ToString da classe Limpadores
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
