/*
* Descrição: Criação da classe Carro
* Nome: Pedro Rei
* Contacto: pedro28rei@gmail.com
* Data: 15/11/2023
* LESI - POO
* 
* 
*/


using System;

namespace Automoveis
{
    /// <summary>
    /// Classe Carro
    /// </summary>
    public class Carro : Automovel
    {
        #region ATRIBUTOS

        int codigoCarro;
        int cavalos;
        float consumo;
        string cor;
        int lugares;

        #endregion


        #region METODOS


        #region CONSTRUTORES


        /// <summary>
        /// Construtor por omissão que cria um Carro,sem parâmetros definidos 
        /// </summary>
        public Carro()
        {
            codigoCarro = 0;
            cavalos = 0;
            consumo = 0;
            cor = string.Empty;
            lugares = 0;
        }

        /// <summary>
        /// Construtor por omissão que cria um Carro,com parâmetros definidos 
        /// </summary>
        /// <param name="codigoAutomovel"></param>
        /// <param name="dataFabrico"></param>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="preco"></param>
        /// <param name="matricula"></param>
        /// <param name="codigoCarro"></param>
        /// <param name="cavalos"></param>
        /// <param name="consumo"></param>
        /// <param name="cor"></param>
        /// <param name="lugares"></param>
        public Carro(int codigoAutomovel, string dataFabrico, string marca, string modelo, float preco, string matricula, int codigoCarro, int cavalos, float consumo, string cor, int lugares)
            : base(codigoAutomovel, dataFabrico, marca, modelo, preco, matricula)
        {
            this.codigoCarro = codigoCarro;
            this.cavalos = cavalos;
            this.consumo = consumo;
            this.cor = cor;
            this.lugares = lugares;
        }


        #endregion

        #region PROPRIEDADES

        /// <summary>
        /// Propriedade do Codigo de um Carro
        /// </summary>
        public int CodigoCarro
        {
        set { codigoCarro = value; }
        get { return codigoCarro; }
        }

        /// <summary>
        /// Propriedade dos Cavalos de um Carro
        /// </summary>
        public int Cavalos
        {
            set { cavalos = value; }
            get { return cavalos; }
        }

        /// <summary>
        /// Propriedade do Consumo de um Carro
        /// </summary>
        public float Consumo
        {
            set { consumo = value; }
            get { return consumo; }
        }

        /// <summary>
        /// Propriedade da cor de um Carro
        /// </summary>
        public string Cor
        {
            set { cor = value; }
            get { return cor; }
        }

        /// <summary>
        /// Propriedade dos lugares de um Carro
        /// </summary>
        public int Lugares
        {
            set { lugares = value; }
            get { return lugares; }
        }

        #endregion

        #region OPERADORES

        /// <summary>
        /// Verificar se um objeto da classe Carro é igual ao outro objeto atráves do cógido
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator ==(Carro c1, Carro c2)
        {
            if (c1.codigoCarro == c2.codigoCarro)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Verificar se um objeto da classe Pessoa é diferente do outro objeto
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        public static bool operator !=(Carro a1, Carro a2)
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
            return "|Codigo: " + codigoCarro + "|Cavalos: " + cavalos + "|Consumo: " + consumo + "|Cor: " + cor + "|Lugares: " + lugares;
        }

        /// <summary>
        /// Verificar se os dois objetos são do mesmo tipo
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Carro)
            {
                Carro p = (Carro)obj;
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
