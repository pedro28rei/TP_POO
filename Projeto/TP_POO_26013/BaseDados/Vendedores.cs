/*
* Descrição: Realização da classe Vendedores
* Nome: Pedro Rei
* Contacto: pedro28rei@gmail.com
* Data: 10/11/2023
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
    /// Classe Vendedores que vai conter uma lista que é responsãvel por armazenar os vendedores
    /// </summary>
    public class Vendedores
    {
        #region ATRIBUTOS


        private static List<Vendedor> listaVendedores;


        #endregion

        #region METODOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor que inicializa a lista de vendedores
        /// </summary>
        static Vendedores()
        {
            listaVendedores = new List<Vendedor>();
        }


        /// <summary>
        /// Construtor por omissão 
        /// </summary>
        public Vendedores()
        {
        }


        #endregion


        #region PROPRIEDADES

        /// <summary>
        /// Propriedade que permite obter a lista, apenas com get para ter acesso restrito e não ser definido por outrém
        /// </summary>
        public List<Vendedor> ObterLista
        {
            get { return listaVendedores; }
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


        #region OUTROSMETODOS

        /// <summary>
        /// Método que adiciona um vendedor na lista estática, retorna true caso seja bem sucedida e false caso contrário.
        /// </summary>
        /// <param name="vendedor"></param>
        /// <returns></returns>
        public static bool AdicionarVendedor(Vendedor vendedor)
        {
            foreach (Vendedor c in listaVendedores)
            {
                if (c.Equals(vendedor)) { return false; }
            }

            listaVendedores.Add(vendedor);

            return true;
        }

        /// <summary>
        /// Método que remove um vendedor da lista estática, retorna true caso seja bem sucedida e false caso contrário.
        /// </summary>
        /// <param name="vendedor"></param>
        /// <returns></returns>
        public static bool RemoverVendedor(Vendedor vendedor)
        {
            foreach (Vendedor c in listaVendedores)
            {
                if (c.Equals(vendedor)) { listaVendedores.Remove(vendedor); return true; }
            }

            return false;
        }

        /// <summary>
        /// Método que ordena a lista pelo número de vendedores de forma crescente
        /// </summary>
        /// <param name="vendedor"></param>
        /// <returns></returns>
        public static bool OrdenarVendedor()
        {
            listaVendedores.Sort();
            return true;
        }

        /// <summary>
        /// Método que lê um ficheiro em binário, com a informação dos Vendedores
        /// </summary>
        /// <returns></returns>
        public static List<Vendedor> LerFicheiroVendedores()
        {

            List<Vendedor> aux = new List<Vendedor>();

            FileStream fs = File.Open("Vendedores.bin", FileMode.Open, FileAccess.ReadWrite);

            BinaryFormatter bf = new BinaryFormatter();

            aux = (List<Vendedor>)bf.Deserialize(fs);


            fs.Close();

            return aux;

        }

        /// <summary>
        /// Método que guarda num ficheiro em binário, a informação dos Vendedores
        /// </summary>
        /// <returns></returns>
        public static bool GuardarFicheiroVendedores()
        {

            FileStream fs = File.Open("Vendedores.bin", FileMode.Create, FileAccess.ReadWrite);

            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, listaVendedores);

            fs.Close();

            return true;
        }

        #endregion


        #endregion
    }
}
