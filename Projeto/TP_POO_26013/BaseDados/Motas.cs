/*
* Descrição: Elaboração da classe Motas
* Nome: Pedro Rei
* Contacto: pedro28rei@gmail.com
* Data: 15/11/2023
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
    /// Classe Motas, que vai conter uma lista que é responsável para armezenar as motas
    /// </summary>
    public class Motas
    {

        #region ATRIBUTOS


        private static List<Mota> listaMotas;

        #endregion


        #region METODOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor que inicializa a lista de motas
        /// </summary>
        static Motas()
        {
            listaMotas = new List<Mota>();
        }


        /// <summary>
        /// Construtor por omissão
        /// </summary>
        public Motas()
        {
        }


        #endregion


        #region PROPRIEDADES


        /// <summary>
        /// Propriedade que permite obter a lista, apenas com get para ter acesso restrito e não ser definido por outrém
        /// </summary>
        public List<Mota> ObterLista
        {
            get { return listaMotas; }
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


        #region OUTROSMETODOS

        /// <summary>
        /// Método que adiciona um a mota na lista estática, retorna true caso seja bem sucedida e false caso contrário.
        /// </summary>
        /// <param name="mota"></param>
        /// <returns></returns>
        public static bool AdicionarMota(Mota mota)
        {
            foreach (Mota c in listaMotas)
            {
                if (c.Equals(mota)) { return false; }
            }

            listaMotas.Add(mota);

            return true;
        }

        /// <summary>
        /// Método que remove uma mota da lista estática, retorna true caso seja bem sucedida e false caso contrário.
        /// </summary>
        /// <param name="mota"></param>
        /// <returns></returns>
        public static bool RemoverMota(Mota mota)
        {
            foreach (Mota c in listaMotas)
            {
                if (c.Equals(mota)) { listaMotas.Remove(mota); return true; }
            }

            return false;
        }

        /// <summary>
        /// Método que ordena a lista pelo número de cliente que forma crescente
        /// </summary>
        /// <param name="motas"></param>
        /// <returns></returns>
        public static bool OrdenarMotas()
        {
            listaMotas.Sort();
            return true;
        }

        /// <summary>
        /// Método que lê um ficheiro em binário, com a informação das Motas
        /// </summary>
        /// <returns></returns>
        public static List<Mota> LerFicheiroMotas()
        {

            List<Mota> aux = new List<Mota>();

            FileStream fs = File.Open("Motas.bin", FileMode.Open, FileAccess.ReadWrite);

            BinaryFormatter bf = new BinaryFormatter();

            aux = (List<Mota>)bf.Deserialize(fs);


            fs.Close();

            return aux;

        }

        /// <summary>
        /// Método que guarda num ficheiro em binário, a informação dos Clientes
        /// </summary>
        /// <returns></returns>
        public static bool GuardarFicheiroMotas()
        {

            FileStream fs = File.Open("Motas.bin", FileMode.Create, FileAccess.ReadWrite);

            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, listaMotas);

            fs.Close();

            return true;
        }
        #endregion

        #endregion
    }
}
