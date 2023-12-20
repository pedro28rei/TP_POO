/*
* Descrição: Elaboração da classe Trabalhador
* Nome: Pedro Rei
* Contacto: pedro28rei@gmail.com
* Data: 07/11/2023
* LESI - POO
* 
* 
*/

using System;

namespace ObjetosNegocio
{
    /// <summary>
    /// Classe Trabalhador, que herda a classe Pessoa
    /// </summary>
    public class Trabalhador : Pessoa
    {
        #region ATRIBUTOS

        private int codigoTrabalhador;
        private string stand;
        private int anosServico;

        #endregion


        #region METODOS


        #region CONSTRUTORES


        /// <summary>
        /// Construtor por omissão que cria um Trabalhador, sem parâmetros definidos 
        /// </summary>
        public Trabalhador()
        {
            codigoTrabalhador = 0;
            stand = string.Empty;
            anosServico = 0;
        }

        /// <summary>
        /// Construtor por omissão que cria um Trabalhador, com parâmetros definidos 
        /// </summary>
        public Trabalhador(string nomeExterno, int idadeExterno, DateTime dataNascimentoExterno, string sexoExterno, string moradaExterno, int codigoTrabalhador, string stand, int anosServico)
            : base(nomeExterno, idadeExterno, dataNascimentoExterno, sexoExterno, moradaExterno)
        {
            this.codigoTrabalhador = codigoTrabalhador;
            this.stand = stand;
            this.anosServico = anosServico;
        }


        #endregion


        #region PROPRIEDADES

        /// <summary>
        /// Propiedade do codigo de trabalhador de uma pessoa
        /// </summary>
        public int CodigoTrabalhador
        {
            set { codigoTrabalhador = value; }
            get { return codigoTrabalhador; }
        }

        /// <summary>
        /// Propiedade do stand de trabalhador de um trabalhador
        /// </summary>
        public string Stand
        {
            set { stand = value; }
            get { return stand; }
        }

        /// <summary>
        /// Propriedade dos anos de serviço de um trabalhador
        /// </summary>
        public int AnosServico
        {
            set { anosServico = value; }
            get { return anosServico; }
        }

        #endregion

        /// <summary>
        /// Verificar se um objeto da classe Trabalhador é igual ao outro objeto
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        #region OPERADORES
        public static bool operator ==(Trabalhador t1, Trabalhador t2)
        {
            if (t1.codigoTrabalhador == t2.codigoTrabalhador)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Verificar se um objeto da classe Pessoa é diferente do outro objeto
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Trabalhador t1, Trabalhador t2)
        {
            if (t1 == t2) { return false; }
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
            return "|Nome: " + Nome + "|Idade: " + Idade + "|Data Nascimento: " + DataNascimento + "|Sexo: " + Sexo + "|Morada: " + Morada + "|Codigo Trabalhador: " + codigoTrabalhador + "|Stand: " + stand + "|Anos Serviço: "+ anosServico;
        }

        /// <summary>
        /// Verificar se os dois objetos são do mesmo tipo
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Trabalhador)
            {
                Trabalhador t = (Trabalhador)obj;
                if (this == t)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Obtém um código hash para a Trabalhador.
        /// </summary>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion

        #endregion
    }
}
