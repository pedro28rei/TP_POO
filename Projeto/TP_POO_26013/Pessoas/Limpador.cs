/*
* Descrição: Elaboração da classe Pessoas
* Nome: Pedro Rei
* Contacto: pedro28rei@gmail.com
* Data: 08/11/2023
* LESI - POO
* 
* 
*/

using System;

namespace Pessoas
{
    public class Limpador : Trabalhador
    {
        #region ATRIBUTOS

        int idLimpador;
        float salario;
        int nivelCargo;
        string funcoes;

        #endregion


        #region METODOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor por omissão que cria um Limpador, com parâmetros não definidos
        /// </summary>
        public Limpador()
        {
            idLimpador = 0;
            salario = 800;
            nivelCargo = 1;
            funcoes = string.Empty;
        }

        /// <summary>
        /// Construtor por omissão que cria um LLimpador, com parâmetros definidos
        /// </summary>
        /// <param name="nomeExterno"></param>
        /// <param name="idadeExterno"></param>
        /// <param name="dataNascimentoExterno"></param>
        /// <param name="sexoExterno"></param>
        /// <param name="moradaExterno"></param>
        /// <param name="codigoTrabalhadorExterno"></param>
        /// <param name="standExterno"></param>
        /// <param name="anosServicoExterno"></param>
        /// <param name="idLimpador"></param>
        /// <param name="salario"></param>
        /// <param name="nivelCargo"></param>
        /// <param name="funcoes"></param>
        public Limpador(string nomeExterno, int idadeExterno, DateTime dataNascimentoExterno, string sexoExterno, string moradaExterno, int codigoTrabalhadorExterno, string standExterno, int anosServicoExterno, int idLimpador, float salario, int nivelCargo, string funcoes)
           : base(nomeExterno, idadeExterno, dataNascimentoExterno, sexoExterno, moradaExterno, codigoTrabalhadorExterno, standExterno, anosServicoExterno)
        {
            this.idLimpador = idLimpador;
            this.salario = salario;
            this.nivelCargo = nivelCargo;
            this.funcoes = funcoes;
        }
        #endregion

        #region PROPRIEDADES

        /// <summary>
        /// Propiedade do id de limpador
        /// </summary>
        public int IdLimpador
        {
            set { idLimpador = value; }
            get { return idLimpador; }
        }

        /// <summary>
        /// Propiedade salario de um limpador
        /// </summary>
        public float Salario
        {
            set { salario = value; }
            get { return salario; }
        }

        /// <summary>
        /// Propiedade do salario de um limpador
        public int NivelCargo
        {
            set { nivelCargo = value; }
            get { return nivelCargo; }
        }

        /// <summary>
        /// Propiedade funções de um administrador
        /// </summary>
        public string Funcoes
        {
            set { funcoes = value; }
            get { return funcoes; }
        }
        #endregion

        #region OPERADORES
        #endregion

        #region OVERRIDES
        /// <summary>
        /// Conversão do objeto numa string, mostrando os seus dados
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "|Nome: " + Nome + "|Idade: " + Idade + "|Data Nascimento: " + DataNascimento + "|Sexo: " + Sexo + "|Morada: " + Morada + "|Codigo Trabalhador: " + CodigoTrabalhador + "|Stand: " + Stand + "|Anos Serviço: " + AnosServico + "|ID Vendedor: " + idLimpador + "|Salario: " + salario + "|Nivel Cargo: " + nivelCargo + "|Funções: " + funcoes;
        }

        /// <summary>
        /// Verificar se os dois objetos são do mesmo tipo
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Limpador)
            {
                Limpador t = (Limpador)obj;
                if (this == t)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Obtém um código hash para o Limpador
        /// </summary>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #endregion
    }
}
