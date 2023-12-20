/*
* Descrição: Elaboração da classe Pessoa
* Nome: Pedro Rei
* Contacto: pedro28rei@gmail.com
* Data: 05/11/2023
* LESI - POO
* 
* 
*/


using System;


namespace Pessoas
{
    /// <summary>
    /// Classe Pessoa, que vai ter como objetos pessoas, que tem um nome, idade, data nascimento, sexo e morada
    /// </summary>
    public class Pessoa
    {

        #region ATRIBUTOS

        private string nome;
        private int idade;
        private DateTime dataNascimento;
        private string sexo;
        private string morada;

        #endregion


        #region METODOS


        #region CONSTRUTORES

        /// <summary>
        /// Construtor por omissão que cria uma Pessoa,sem parâmetros definidos 
        /// </summary>
        public Pessoa()
        {
            nome = string.Empty;
            idade = 0;
            dataNascimento = DateTime.Now;
            sexo = string.Empty;
            morada = string.Empty;



        }


        /// <summary>
        /// Construtor por omissão que cria uma Pessoa, com parâmetros definidos(nome, idade, data nascimento, sexo ,morada)
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="idade"></param>
        /// <param name="dataNascimento"></param>
        public Pessoa(string nome, int idade, DateTime dataNascimento, string sexo, string morada)
        {
            this.nome = nome;
            this.idade = idade;
            this.dataNascimento = dataNascimento;
            this.sexo = sexo;
            this.morada = morada;

        }

        #endregion


        #region PRORIEDADES

        /// <summary>
        /// Propriedade do nome de uma Pessoa
        /// </summary>
        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }

        /// <summary>
        /// Propriedade da idade de uma Pessoa
        /// </summary>
        public int Idade
        {
            set { idade = value; }
            get { return idade; }
        }

        /// <summary>
        /// Propriedade da dataNascimento de uma Pessoa
        /// </summary>
        public DateTime DataNascimento
        {
            set { dataNascimento = value; }
            get { return dataNascimento; }
        }

        /// <summary>
        ///  Propriedade do sexo de uma Pessoa
        /// </summary>
        public string Sexo
        {
            set { sexo = value; }
            get { return sexo; }
        }

        /// <summary>
        ///  Propiedade da morada de uma pessoa
        /// </summary>
        public string Morada
        {
            set { morada = value; }
            get { return morada; }
        }

        #endregion


        #region OPERADORES

        /// <summary>
        /// Verificar se um objeto da classe Pessoa é igual ao outro objeto
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Pessoa p1, Pessoa p2)
        {
            if ((p1.Nome == p2.Nome) && (p1.Idade == p2.Idade) && (p1.DataNascimento == p2.DataNascimento) && (p1.Sexo == p2.Sexo) && (p1.Morada == p2.Morada))
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
        public static bool operator !=(Pessoa p1, Pessoa p2)
        {
            if (p1 == p2) { return false; }
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
            return "|Nome: " + nome + "|Idade: " + idade + "|Data Nascimento: " + dataNascimento + "|Sexo: " + sexo + "|Morada: " + morada;
        }

        /// <summary>
        /// Verificar se os dois objetos são do mesmo tipo
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Pessoa)
            {
                Pessoa p = (Pessoa)obj;
                if (this == p)
                {
                    return true;
                }
            }
            return false;
        }
      
        /// <summary>
        /// Obtém um código hash para a pessoa.
        /// </summary>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion


        #endregion


    }
}
