/*
* Descrição: Realização da classe Administradores
* Nome: Pedro Rei
* Contacto: pedro28rei@gmail.com
* Data: 09/11/2023
* LESI - POO
* 
* 
*/

namespace Pessoas
{
    /// <summary>
    /// Classe Administradores quye contém vários administradores
    /// </summary>
    internal class Administradores
    {
        #region ATRIBUTOS

        public const int MAXADMINISTRADORES = 999;
        private Administrador[] listaAdministradores;


        #endregion


        #region METODOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor por omissão que cria lista de administradores, sem parâmetros definidos
        /// </summary>
        public Administradores()
        {
            listaAdministradores = new Administrador[MAXADMINISTRADORES];
        }


        /// <summary>
        /// Construtor por omissão que cria lista de administradores, com parâmetros definidos
        /// </summary>
        /// <param name="MAXCLIENTES"></param>
        /// <param name="listaClientes"></param>
        public Administradores(int MAXADMINISTRADORES, Administrador[] listaAdministradores)
        {
            this.listaAdministradores = listaAdministradores;
        }


        #endregion

        #region PROPRIEDADES

        /// <summary>
        /// Propriedade de leitura que fornece uma copia do array administrador
        /// </summary>
        public Administrador[] ListaAdministradores
        {

            get { return (Administrador[])listaAdministradores.Clone(); }
        }


        #endregion


        #region OVERRIDES

        /// <summary>
        /// Override ToString da classe Administradores
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
