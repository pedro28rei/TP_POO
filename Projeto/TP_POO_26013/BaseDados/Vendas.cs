/*
* Descrição: Desenvolvimento classe Vendas
* Nome: Pedro Rei
* Contacto: pedro28rei@gmail.com
* Data: 29/12/2023
* LESI - POO
* 
*/

using ObjetosNegocio;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BaseDados
{
    /// <summary>
    /// Classe de Vendas, onde vão ser contidos os dados das vendas e os seus métodos
    /// </summary>
    internal class Vendas
    {
        #region ATRIBUTOS 

        private static List<Venda> listaVendas;
        #endregion

        #region METODOS                                                                        

        #region CONSTRUTORES

        /// <summary>
        /// Construtor que inicializa a lista de vendas
        /// </summary>
        static Vendas()
        {
            listaVendas = new List<Venda>();
        }


        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public Vendas()
        {
        }

        #endregion

        #region PROPRIEDADES

        /// <summary>
        /// Propriedade que permite obter a lista, apenas com get para ter acesso restrito e não ser definido por outrém
        /// </summary>
        public List<Venda> ObterLista
        {
            get { return listaVendas; }
        }


        #endregion

        #region OVERRIDES

        /// <summary>
        /// Override ToString da classe Vendas
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString();
        }

        #endregion

        #region OUTROSMETODOS

        /// <summary>
        /// Método que adiciona um a mota na lista estática, retorna true caso seja bem sucedida e false caso contrário.
        /// </summary>
        /// <param name="venda"></param>
        /// <returns></returns>
        public static bool AdicionarMota(Vendas venda)
        {
            foreach (Venda c in listaVendas)
            {
                if (c.Equals(venda)) { return false; }
            }

            //listaVendas.Add(venda);

            return true;
        }

        /// <summary>
        /// Método que remove uma venda da lista estática, retorna true caso seja bem sucedida e false caso contrário.
        /// </summary>
        /// <param name="venda"></param>
        /// <returns></returns>
        public static bool RemoverVenda(Venda venda)
        {
            foreach (Venda c in listaVendas)
            {
                if (c.Equals(venda)) { listaVendas.Remove(venda); return true; }
            }

            return false;
        }

        /// <summary>
        /// Método que ordena a lista pelo número de vendas que forma crescente
        /// </summary>
        /// <returns></returns>
        public static bool OrdenarVendas()
        {
            listaVendas.Sort();
            return true;
        }

        /// <summary>
        /// Método que lê um ficheiro em binário, com a informação das Vendas
        /// </summary>
        /// <returns></returns>
        public static bool LerFicheiroVendas()
        {


            FileStream fs = File.Open("Vendas.bin", FileMode.Open, FileAccess.ReadWrite);

            BinaryFormatter bf = new BinaryFormatter();

            listaVendas = (List<Venda>)bf.Deserialize(fs);


            fs.Close();

            return true;

        }

        /// <summary>
        /// Método que guarda num ficheiro em binário, a informação das Vendas
        /// </summary>
        /// <returns></returns>
        public static bool GuardarFicheiroVendas()
        {

            FileStream fs = File.Open("Vendas.bin", FileMode.Create, FileAccess.ReadWrite);

            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, listaVendas);

            fs.Close();

            return true;
        }

        #endregion

        #endregion

    }
}
