/*
* Descrição: Realização da classe Limpadores
* Nome: Pedro Rei
* Contacto: pedro28rei@gmail.com
* Data: 08/11/2023
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
    ///  Classe Limpadores que vai conter uma lista que é responsãvel por armazenar os limpadores
    /// </summary>
    public class Limpadores
    {
        #region ATRIBUTOS

        private static List<Limpador> listaLimpadores;

        #endregion


        #region METODOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor por omissão que cria lista de limpadores
        /// </summary>
        static Limpadores()
        {
            listaLimpadores = new List<Limpador>();
        }


        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public Limpadores()
        {
        }

        #endregion


        #region PROPRIEDADES

        /// <summary>
        /// Propriedade que permite obter a lista, apenas com get para ter acesso restrito e não ser definido por outrém
        /// </summary>
        public List<Limpador> ObterLista
        {
            get { return listaLimpadores; }
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


        #region OUTROSMETODOS

        /// <summary>
        /// Método que adiciona um limpador da lista estática, retorna true caso seja bem sucedida e false caso contrário.
        /// </summary>
        /// <param name="limpador"></param>
        /// <returns></returns>
        public static bool AdicionarLimpador(Limpador limpador)
        {
            foreach (Limpador c in listaLimpadores)
            {
                if (c.Equals(limpador)) { return false; }
            }

            listaLimpadores.Add(limpador);

            return true;
        }

        /// <summary>
        /// Método que remove um limpador da lista estática, retorna true caso seja bem sucedida e false caso contrário.
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static bool RemoverLimpador(Limpador limpador)
        {
            foreach (Limpador c in listaLimpadores)
            {
                if (c.Equals(limpador)) { listaLimpadores.Remove(limpador); return true; }
            }

            return false;
        }

        /// <summary>
        /// Método que ordena a lista pelo número de limpadores que forma crescente
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static bool OrdenarLimpadores()
        {
            listaLimpadores.Sort();
            return true;
        }

        /// <summary>
        /// Método que lê um ficheiro em binário, com a informação dos Limpadores
        /// </summary>
        /// <returns></returns>
        public static bool LerFicheiroLimpadores()
        {

            FileStream fs = File.Open("Limpadores.bin", FileMode.Open, FileAccess.ReadWrite);

            BinaryFormatter bf = new BinaryFormatter();

            listaLimpadores = (List<Limpador>)bf.Deserialize(fs);


            fs.Close();

            return true;

        }

        /// <summary>
        /// Método que guarda num ficheiro em binário, a informação dos Clientes
        /// </summary>
        /// <returns></returns>
        public static bool GuardarFicheiroLimpadores()
        {

            FileStream fs = File.Open("Limpadores.bin", FileMode.Create, FileAccess.ReadWrite);

            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, listaLimpadores);

            fs.Close();

            return true;
        }

        #endregion

        #endregion
    }
}
