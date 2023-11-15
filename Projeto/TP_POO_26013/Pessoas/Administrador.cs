/*
* Descrição: Elaboração da classe Administrador
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
    /// <summary>
    /// Classe Administrador
    /// </summary>
    public class Administrador : Trabalhador
    {
        #region ATRIBUTOS

        int idAdmin;
        float salario;
        int nivelCargo;
        string funcoes;


        #endregion


        #region METODOS

        #region CONSTRUTORES
        /// <summary>
        /// Construtor por omissão que cria um Administrador, com parâmetros não definidos
        /// </summary>
        public Administrador()
        {
            idAdmin = 0;
            salario = 800;
            nivelCargo = 1;
            funcoes = string.Empty;
        }

        /// <summary>
        /// Construtor por omissão que cria um Trabalhador, com parâmetros definidos
        /// </summary>
        /// <param name="nomeExterno"></param>
        /// <param name="idadeExterno"></param>
        /// <param name="dataNascimentoExterno"></param>
        /// <param name="sexoExterno"></param>
        /// <param name="moradaExterno"></param>
        /// <param name="codigoTrabalhadorExterno"></param>
        /// <param name="standExterno"></param>
        /// <param name="anosServicoExterno"></param>
        /// <param name="salario"></param>
        /// <param name="nivelCargo"></param>
        /// <param name="funcoes"></param>
        public Administrador(string nomeExterno, int idadeExterno, DateTime dataNascimentoExterno, string sexoExterno, string moradaExterno, int codigoTrabalhadorExterno, string standExterno, int anosServicoExterno, int idAdmin, float salario, int nivelCargo, string funcoes)
            : base(nomeExterno, idadeExterno, dataNascimentoExterno, sexoExterno, moradaExterno, codigoTrabalhadorExterno, standExterno, anosServicoExterno)
        {
            this.idAdmin = idAdmin;
            this.salario = salario;
            this.nivelCargo = nivelCargo;
            this.funcoes = funcoes;
        }
        #endregion

        #region PROPRIEDADES


        /// <summary>
        /// Propiedade do id de adminstador 
        /// </summary>
        public int IdAdmin
        {
            set { idAdmin = value; }
            get { return idAdmin; }
        }

        /// <summary>
        /// Propiedade salario de um administrador
        /// </summary>
        public float Salario
        {
            set { salario = value; }
            get { return salario; }
        }

        /// <summary>
        /// Propiedade do salario de um administrador
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

        /// <summary>
        /// Verificar se um objeto da classe Administrador é igual ao outro objeto, através do idAdmin
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        #region OPERADORES
        public static bool operator ==(Administrador a1, Administrador a2)
        {
            if (a1.idAdmin == a2.idAdmin)
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
        public static bool operator !=(Administrador a1, Administrador a2)
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
            return "|Nome: " + Nome + "|Idade: " + Idade + "|Data Nascimento: " + DataNascimento + "|Sexo: " + Sexo + "|Morada: " + Morada + "|Codigo Trabalhador: " + CodigoTrabalhador + "|Stand: " + Stand + "|Anos Serviço: " + AnosServico + "|ID Administrador: "+ idAdmin + "|Salario: " + salario + "|Nivel Cargo: "+ nivelCargo + "|Funções: "+ funcoes;
        }

        /// <summary>
        /// Verificar se os dois objetos são do mesmo tipo
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Administrador)
            {
                Administrador t = (Administrador)obj;
                if (this == t)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Obtém um código hash para a Administrador
        /// </summary>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #endregion

        #endregion
    }
}
