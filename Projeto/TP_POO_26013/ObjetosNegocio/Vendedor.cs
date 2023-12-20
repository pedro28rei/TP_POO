/*
* Descrição: Elaboração da classe Vendedor
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
    /// Classe Vendedor, que herda a classe Pessoa
    /// </summary>
    public class Vendedor : Trabalhador
    {

        #region ATRIBUTOS

        int idVendedor;
        float salario;
        int nivelCargo;
        string funcoes;
        #endregion


        #region METODOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor por omissão que cria um Vendedor, sem parâmetros definidos 
        /// </summary>
        public Vendedor()
        {
            idVendedor = 0;
            salario = 0;
            nivelCargo = 0;
            funcoes = string.Empty;
        }

        /// <summary>
        /// Construtor por omissão que cria um Trabalhador, com parâmetros definidos 
        /// </summary>
        public Vendedor(string nomeExterno, int idadeExterno, DateTime dataNascimentoExterno, string sexoExterno, string moradaExterno, int CodigoTrabalhadorExterno, String standExterno, int AnosServicoExterno, int idVendedor, float salario, int nivelCargo, string funcoes)
            : base(nomeExterno, idadeExterno, dataNascimentoExterno, sexoExterno, moradaExterno, CodigoTrabalhadorExterno, standExterno, AnosServicoExterno)
        {
            this.idVendedor = idVendedor;
            this.salario = salario;
            this.nivelCargo = nivelCargo;
            this.funcoes = funcoes;
        }


        #endregion

        #region PROPRIEDADES

        /// <summary>
        /// Propiedade idVendedor de um Vendedor
        /// </summary>
        public int IdVendedor
        {
            set { idVendedor = value; }
            get { return idVendedor; }
        }

        /// <summary>
        /// Propiedade salario de um Vendedor
        /// </summary>
        public float Salario
        {
            set { salario = value; }
            get { return salario; }
        }

        /// <summary>
        /// Propiedade Nivel Cargo de um Vendedor
        /// </summary>
        public int NivelCargo
        {
            set { nivelCargo = value; }
            get { return nivelCargo; }
        }

        /// <summary>
        /// Propiedade Funcoes de um Vendedor
        /// </summary>
        public string Funcoes
        {
            set {  funcoes = value; }
            get { return funcoes; }
        }


        #endregion


        #region OPERADORES
        /// <summary>
        /// Verificar se um objeto da classe Vendedor é igual ao outro objeto, através do idVendedor
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vendedor v1, Vendedor v2)
        {
            if (v1.idVendedor == v2.idVendedor)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Verificar se um objeto da classe Vendedor é diferente do outro objeto
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Vendedor v1, Vendedor v2)
        {
            if (v1 == v2) { return false; }
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
            return "|Nome: " + Nome + "|Idade: " + Idade + "|Data Nascimento: " + DataNascimento + "|Sexo: " + Sexo + "|Morada: " + Morada + "|Codigo Trabalhador: " + CodigoTrabalhador + "|Stand: " + Stand + "|Anos Serviço: " + AnosServico + "|ID Vendedor: " + idVendedor + "|Salario: " + salario + "|Nivel Cargo: " + nivelCargo + "|Funções: " + funcoes;
        }


        /// <summary>
        /// Verificar se os dois objetos são do mesmo tipo
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Vendedor)
            {
                Vendedor t = (Vendedor)obj;
                if (this == t)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Obtém um código hash para a Vendedor
        /// </summary>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #endregion
    }
}
