/*
* Descrição: Criação da classe Automovel
* Nome: Pedro Rei
* Contacto: pedro28rei@gmail.com
* Data: 10/11/2023
* LESI - POO
* 
* 
*/

using System;

namespace Automoveis
{
    /// <summary>
    /// Classe Automóvel 
    /// </summary>
    public class Automovel
    {
        #region ATRIBUTOS

        int codigoAutomovel;
        string dataFabrico;
        string marca;
        string modelo;
        float preco;
        string matricula;


        #endregion


        #region METODOS

        #region CONSTRUTORES

        /// <summary>
        ///  Construtor por omissão que cria um Automóvel,sem parâmetros definidos 
        /// </summary>
        public Automovel()
        {
            codigoAutomovel = 0;
            dataFabrico = string.Empty;
            marca = string.Empty;
            modelo = string.Empty;
            preco = 0;
            matricula = string.Empty;

        }

        /// <summary>
        /// Construtor por omissão que cria uma Automóvel, com parâmetros definidos
        /// </summary>
        /// <param name="dataFabrico"></param>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="preco"></param>
        /// <param name="matricula"></param>
        public Automovel(int codigoAutomovel, string dataFabrico, string marca, string modelo, float preco, string matricula)
        {
            this.codigoAutomovel = codigoAutomovel;
            this.dataFabrico = dataFabrico;
            this.marca = marca;
            this.modelo = modelo;
            this.preco = preco;
            this.matricula = matricula;
        }
        #endregion

        #region PROPRIEDADES


        /// <summary>
        /// Propriedade do codigo  de um automovel
        /// </summary>
        public int CodigoAutomovel
        {
            set { codigoAutomovel = value; }
            get { return codigoAutomovel; }
        }

        /// <summary>
        /// Propriedade da Data de Fabrico de uma Pessoa
        /// </summary>
        public string DataFabrico
        {
            set { dataFabrico = value; }
            get { return dataFabrico; }
        }

        /// <summary>
        /// Propriedade da Marca de um automovel
        /// </summary>
        public string Marca
        {
            set { marca = value; }
            get { return marca; }
        }

        /// <summary>
        /// Propriedade da Modelo de um Automovel
        /// </summary>
        public string Modelo
        {
            set { modelo = value; }
            get { return modelo; }
        }

        /// <summary>
        ///  Propriedade do preco de um automovel
        /// </summary>
        public float Preco
        {
            set { preco = value; }
            get { return preco; }
        }

        /// <summary>
        ///  Propriedade da matricula de um automovel
        /// </summary>
        public string Matricula
        {
            set { matricula = value; }
            get { return matricula; }
        }

        #endregion

        #region OPERADORES

        /// <summary>
        ///  Verificar se um objeto da classe Automovel é igual do outro objeto
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        public static bool operator ==(Automovel a1, Automovel a2)
        {
            if (a1.codigoAutomovel == a2.codigoAutomovel)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Verificar se um objeto da classe Automovel é diferente do outro objeto
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        public static bool operator !=(Automovel a1, Automovel a2)
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
            return "|Codigo Automovel: " + codigoAutomovel + "|Data Fabrico: " + dataFabrico + "|Marca: " + marca + "|Modelo: " + modelo + "Matricula" + matricula + "|Preco: " + preco;
        }

        /// <summary>
        /// Verificar se os dois objetos são do mesmo tipo
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Automovel)
            {
                Automovel p = (Automovel)obj;
                if (this == p)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Obtém um código hash para a automovel
        /// </summary>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion

        #endregion
    }
}
