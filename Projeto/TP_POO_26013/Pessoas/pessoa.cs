/*
* Descrição: Elaboração da classe pessoa
* Nome: Pedro Rei
* Contacto: pedro28rei@gmail.com
* Data: 05/11/2023
* LESI - POO
* 
* 
*/

namespace Pessoas
{
    public class pessoa
    {
        #region ATRIBUTOS

        private string nome;
        private int idade;
        private DateOnly dataNascimento;


        #endregion


        #region METODOS


        #region CONSTRUTORES

        /// <summary>
        /// Construtor por omissão que cria uma pessoa,sem parâmetros definidos 
        /// </summary>
        public pessoa()
        {
            nome = "";
            idade = 0;
            dataNascimento = new DateOnly(0, 0, 0);
        }


        /// <summary>
        /// Construtor por omissão que cria uma pessoa, com parâmetros definidos
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="idade"></param>
        /// <param name="dataNascimento"></param>
        public pessoa(string nome, int idade, DateOnly dataNascimento)
        {
            this.nome = nome;
            this.idade = idade;
            this.dataNascimento = dataNascimento;
        }

        #endregion


        #region PRORIEDADES

        /// <summary>
        /// Propriedade da idade de uma pessoa
        /// </summary>
        public int Idade
        {
            set { idade = value; }
            get { return idade; }
        }

        /// <summary>
        /// Propriedade do nome de uma pessoa
        /// </summary>
        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }
        /// <summary>
        /// Propriedade da dataNascimento de uma pessoa
        /// </summary>

        public DateOnly DataNascimento
        {
            set { dataNascimento = value; }
            get { return dataNascimento; }
        }

        #endregion


        #region ATRIBUTOS
        #endregion


        #region OPERADORES
        #endregion


        #region OVERRIDES
        #endregion


        #region DESTRUIDORES
        #endregion

        #endregion

    }

}