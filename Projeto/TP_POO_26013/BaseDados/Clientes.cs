/*
* Descrição: Realização da classe Clientes
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
    /// Classe Clientes que vai conter uma lista que é responsãvel por armazenar os clientes
    /// </summary>
    public class Clientes
    {

        #region ATRIBUTOS

        private static List<Cliente> listaClientes;


        #endregion


        #region METODOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor que inicializa a lista de clientes
        /// </summary>
        static Clientes()
        {
            listaClientes = new List<Cliente>();
        }


        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public Clientes()
        {
        }

        #endregion

        #region PROPRIEDADES

        /// <summary>
        /// Propriedade que permite obter a lista, apenas com get para ter acesso restrito e não ser definido por outrém
        /// </summary>
        public List<Cliente> ObterLista
        {
            get { return listaClientes; }         
        }


        #endregion


        #region OVERRIDES
        #endregion


        #region OUTROSMETODOS

        /// <summary>
        /// Método que adiciona um cliente da lista estática, retorna true caso seja bem sucedida e false caso contrário.
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static bool AdicionarCliente(Cliente cliente)
        {
            foreach (Cliente c in listaClientes)
            {
                if (c.Equals(cliente)) { return false; }
            }

            listaClientes.Add(cliente);

            return true;
        }

        /// <summary>
        /// Método que remove um cliente da lista estática, retorna true caso seja bem sucedida e false caso contrário.
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static bool RemoverCliente(Cliente cliente)
        {
            foreach (Cliente c in listaClientes)
            {
                if (c.Equals(cliente)) { listaClientes.Remove(cliente);  return true; }
            }

            return false;
        }

        /// <summary>
        /// Método que ordena a lista pelo número de cliente que forma crescente
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static bool OrdenarCliente()
        {
            listaClientes.Sort();
            return true;
        }

        /// <summary>
        /// Método que lê um ficheiro em binário, com a informação dos Clientes
        /// </summary>
        /// <returns></returns>
        public static bool LerFicheiroClientes()
        {
        
                FileStream fs = File.Open("Clientes.bin", FileMode.Open, FileAccess.ReadWrite);

                BinaryFormatter bf = new BinaryFormatter();

                listaClientes = (List<Cliente>)bf.Deserialize(fs);

        
            fs.Close();

            return true;

        }

        /// <summary>
        /// Método que guarda num ficheiro em binário, a informação dos Clientes
        /// </summary>
        /// <returns></returns>
        public static bool GuardarFicheiroClientes()
        {

                FileStream fs = File.Open("Clientes.bin", FileMode.Create, FileAccess.ReadWrite);

                BinaryFormatter bf = new BinaryFormatter();

                bf.Serialize(fs, listaClientes);

            fs.Close();

            return true;
        }

        #endregion

        #endregion

    }
}
