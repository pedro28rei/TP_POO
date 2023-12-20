/*
* Descrição: Elaboração da classe Mota
* Nome: Pedro Rei
* Contacto: pedro28rei@gmail.com
* Data: 14/11/2023
* LESI - POO
* 
* 
*/

namespace Automoveis
{
    /// <summary>
    /// Classe Mota
    /// </summary>
    public class Mota : Automovel
    {
        #region ATRIBUTOS

        int codigoMota;
        int potencia;
        float consumo;
        string cor;

        #endregion

        #region METODOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor por omissão que cria uma Mota,sem parâmetros definidos
        /// </summary>
        public Mota()
        {
            codigoMota = 0;
            potencia = 0;
            consumo = 0;
            cor = string.Empty;
        }

        /// <summary>
        ///  Construtor por omissão que cria uma Mota,com parâmetros definidos
        /// </summary>
        /// <param name="codigoAutomovel"></param>
        /// <param name="dataFabrico"></param>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="preco"></param>
        /// <param name="matricula"></param>
        /// <param name="codigoMota"></param>
        /// <param name="potencia"></param>
        /// <param name="consumo"></param>
        /// <param name="cor"></param>
        public Mota(int codigoAutomovel, string dataFabrico, string marca, string modelo, float preco, string matricula, int codigoMota, int potencia, float consumo, string cor)
        : base(codigoAutomovel, dataFabrico, marca, modelo, preco, matricula)
        {
            this.codigoMota = codigoMota;
            this.potencia = potencia;
            this.consumo = consumo;
            this.cor = cor;
        }

        #endregion

        #region PROPRIEDADES

        /// <summary>
        /// Propriedade do codigo da mota
        /// </summary>
        public int CodigoMota
        {
            set { codigoMota = value; }
            get { return codigoMota; }
        }

        /// <summary>
        /// Propriedade do Consumo de uma Mota
        /// </summary>
        public float Consumo
        {
            set { consumo = value; }
            get { return consumo; }
        }

        /// <summary>
        /// Propriedade da cor de uma Mota
        /// </summary>
        public string Cor
        {
            set { cor = value; }
            get { return cor; }
        }

        /// <summary>
        /// Propriedade dos Cavalos de um Carro
        /// </summary>
        public int Potencia
        {
            set { potencia = value; }
            get { return potencia; }
        }


        #endregion

        #region OPERADORES


        /// <summary>
        /// Verificar se um objeto da classe Mota é igual ao outro objeto atráves do cógido
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator ==(Mota c1, Mota c2)
        {
            if (c1.codigoMota == c2.codigoMota)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Verificar se um objeto da classe Mota é diferente do outro objeto
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        public static bool operator !=(Mota a1, Mota a2)
        {
            if (a1 == a2) { return false; }
            return true;
        }

        #endregion

        #region OVERRIDES


        /// <summary>
        /// Conversão do objeto numa string, mostrando os seus dados
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "|Codigo Automovel: " + CodigoAutomovel + "|Data Fabrico: " + DataFabrico + "|Marca: " + Marca + "|Modelo: " + Modelo + "Matricula" + Matricula + "|Preco: " + Preco + "|Codigo: " + codigoMota + "|Potencia: " + potencia + "|Consumo: " + consumo + "|Cor: " + cor;
        }

        /// <summary>
        /// Verificar se os dois objetos são do mesmo tipo
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Mota)
            {
                Mota p = (Mota)obj;
                if (this == p)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Obtém um código hash para o carro
        /// </summary>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion

        #endregion

    }
}
