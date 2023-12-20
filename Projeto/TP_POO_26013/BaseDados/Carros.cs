/*
* Descrição: Realização da classe Carros
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
    /// Classe Carros que vai conter uma lista que é responsãvel por armazenar os carros
    /// </summary>
    public class Carros
    {
        #region ATRIBUTOS

        private static List<Carro> listaCarros;


        #endregion


        #region METODOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor que inicializa a lista de carros
        /// </summary>
        static Carros()
        {
            listaCarros = new List<Carro>();
        }


        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public Carros()
        {
        }


        #endregion


        #region PROPRIEDADES

        /// <summary>
        /// Propriedade que permite obter a lista, apenas com get para ter acesso restrito e não ser definido por outrém
        /// </summary>
        public List<Carro> ObterLista
        {
            get { return listaCarros; }
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


        #region OUTROSMETODOS

        /// <summary>
        /// Método que adiciona um carro da lista estática, retorna true caso seja bem sucedida e false caso contrário.
        /// </summary>
        /// <param name="carro"></param>
        /// <returns></returns>
        public static bool AdicionarCarro(Carro carro)
        {
            foreach (Carro c in listaCarros)
            {
                if (c.Equals(carro)) { return false; }
            }

            listaCarros.Add(carro);

            return true;
        }

        /// <summary>
        /// Método que remove um carro da lista estática, retorna true caso seja bem sucedida e false caso contrário.
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static bool RemoverCarrro(Carro carro)
        {
            foreach (Carro c in listaCarros)
            {
                if (c.Equals(carro)) { listaCarros.Remove(carro); return true; }
            }

            return false;
        }

        /// <summary>
        /// Método que ordena a lista pelo número de carro de forma crescente
        /// </summary>
        /// <returns></returns>
        public static bool OrdenarCarro()
        {
            listaCarros.Sort();
            return true;
        }

        /// <summary>
        /// Método que lê um ficheiro em binário, com a informação dos Carros
        /// </summary>
        /// <returns></returns>
        public static List<Carro> LerFicheiroCarros()
        {

            List<Carro> aux = new List<Carro>();

            FileStream fs = File.Open("Carros.bin", FileMode.Open, FileAccess.ReadWrite);

            BinaryFormatter bf = new BinaryFormatter();

            aux = (List<Carro>)bf.Deserialize(fs);


            fs.Close();

            return aux;

        }

        /// <summary>
        /// Método que guarda num ficheiro em binário, a informação dos Carros
        /// </summary>
        /// <returns></returns>
        public static bool GuardarFicheiroCarros()
        {

            FileStream fs = File.Open("Carros.bin", FileMode.Create, FileAccess.ReadWrite);

            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, listaCarros);

            fs.Close();

            return true;
        }

        #endregion

        #endregion

    }
}