/*
* Descrição: Realização da classe Administradores
* Nome: Pedro Rei
* Contacto: pedro28rei@gmail.com
* Data: 09/11/2023
* LESI - POO
* 
* 
*/

using ObjetosNegocio;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BaseDados
{
    /// <summary>
    ///  Classe Administradores que vai conter uma lista que é responsãvel por armazenar os administradores
    /// </summary>
    public class Administradores
    {
        #region ATRIBUTOS

        private static List<Administrador> listaAdministradores;


        #endregion


        #region METODOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor que inicializa a lista de administradores
        /// </summary>
        static Administradores()
        {
            listaAdministradores = new List<Administrador>();
        }


        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public Administradores()
        {
        }


        #endregion


        #region PROPRIEDADES

        /// <summary>
        /// Propriedade que permite obter a lista, apenas com get para ter acesso restrito e não ser definido por outrém
        /// </summary>
        public List<Administrador> ObterLista
        {
            get { return listaAdministradores; }
        }

        #endregion


        #region OUTROSMETODOS

        /// <summary>
        /// Método que adiciona um administrador da lista estática, retorna true caso seja bem sucedida e false caso contrário.
        /// </summary>
        /// <param name="administrador"></param>
        /// <returns></returns>
        public static bool AdicionarAdministrador(Administrador administrador)
        {
            foreach (Administrador c in listaAdministradores)
            {
                if (c.Equals(administrador)) { return false; }
            }

            listaAdministradores.Add(administrador);

            return true;
        }

        /// <summary>
        /// Método que remove um administrador da lista estática, retorna true caso seja bem sucedida e false caso contrário.
        /// </summary>
        /// <param name="administradores"></param>
        /// <returns></returns>
        public static bool RemoverAdminisrador(Administrador administradores)
        {
            foreach (Administrador c in listaAdministradores)
            {
                if (c.Equals(administradores)) { listaAdministradores.Remove(administradores); return true; }
            }

            return false;
        }

        /// <summary>
        /// Método que ordena a lista pelo número de administradores por forma crescente
        /// </summary>
        /// <returns></returns>
        public static bool OrdenarCliente()
        {
            listaAdministradores.Sort();
            return true;
        }

        /// <summary>
        /// Método que lê um ficheiro em binário, com a informação dos Administradores
        /// </summary>
        /// <returns></returns>
        public static bool LerFicheiroAdministradores()
        {


            FileStream fs = File.Open("Administradores.bin", FileMode.Open, FileAccess.ReadWrite);

            BinaryFormatter bf = new BinaryFormatter();

            listaAdministradores = (List<Administrador>)bf.Deserialize(fs);


            fs.Close();

            return true;

        }

        /// <summary>
        /// Método que guarda num ficheiro em binário, a informação dos Administradores
        /// </summary>
        /// <returns></returns>
        public static bool GuardarFicheiroAdministradores()
        {

            FileStream fs = File.Open("Administradores.bin", FileMode.Create, FileAccess.ReadWrite);

            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, listaAdministradores);

            fs.Close();

            return true;
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
