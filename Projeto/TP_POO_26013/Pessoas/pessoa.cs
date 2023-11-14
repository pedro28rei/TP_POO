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
    public class Pessoa
    {

            #region ATRIBUTOS

            private string nome;
            private int idade;
            private DateTime dataNascimento;


            #endregion


            #region METODOS


            #region CONSTRUTORES

            /// <summary>
            /// Construtor por omissão que cria uma Pessoa,sem parâmetros definidos 
            /// </summary>
            public Pessoa()
            {
                nome = "";
                idade = 0;
            }


            /// <summary>
            /// Construtor por omissão que cria uma Pessoa, com parâmetros definidos
            /// </summary>
            /// <param name="nome"></param>
            /// <param name="idade"></param>
            /// <param name="dataNascimento"></param>
            public Pessoa(string nome, int idade, DateTime dataNascimento)
            {
                this.nome = nome;
                this.idade = idade;
                this.dataNascimento = dataNascimento;
            }

            #endregion


            #region PRORIEDADES

            /// <summary>
            /// Propriedade da idade de uma Pessoa
            /// </summary>
            public int Idade
            {
                set { idade = value; }
                get { return idade; }
            }

            /// <summary>
            /// Propriedade do nome de uma Pessoa
            /// </summary>
            public string Nome
            {
                set { nome = value; }
                get { return nome; }
            }
            /// <summary>
            /// Propriedade da dataNascimento de uma Pessoa
            /// </summary>

            public DateTime DataNascimento
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
