/*
* Descrição: Elaboração da classe Pessoa
* Nome: Pedro Rei
* Contacto: pedro28rei@gmail.com
* Data: 7/11/2023
* LESI - POO
* 
* 
*/

using System;

namespace Pessoas
{
    /// <summary>
    /// Classe Cliente, que herda a classe Pessoa
    /// </summary>
    public class Cliente : Pessoa
    {

        #region ATRIBUTOS

        private int codigoCliente;
        private int nif;
        private int numeroContribuinte;
        private int contacto;
        private string email;
        private float saldo;

        #endregion


        #region METODOS

        #region CONSTRUTORES

        /// <summary>
        /// Construtor por omissão que cria um Cliente, sem parâmetros definidos 
        /// </summary>
        public Cliente()
        {
            codigoCliente = 0;
            nif = 0;
            numeroContribuinte = 0;
            contacto = 0;
            email = string.Empty;
            saldo = 0;
        }

        /// <summary>
        /// Construtor por omissão que cria um Cliente, parâmetros definidos 
        /// </summary>
        public Cliente(string nomeExterno, int idadeExterno, DateTime dataNascimentoExterno, string sexoExterno, string moradaExterno, int codigoCliente, int nif, int numeroContribuinte,int contacto, string email, float saldo)
            : base(nomeExterno, idadeExterno, dataNascimentoExterno, sexoExterno, moradaExterno)
        {
            this.codigoCliente = codigoCliente;
            this.nif = nif;
            this.numeroContribuinte = numeroContribuinte;
            this.contacto = contacto;
            this.email = email;
            this.saldo = saldo;
        }




        #endregion

        #region PROPRIEDADES

        /// <summary>
        /// Propriedade do codigo Cliente de um Cliente
        /// </summary>
        public int CodigoCliente
        {
            set { codigoCliente = value; }
            get { return codigoCliente; }
        }

        /// <summary>
        /// Propriedade nif de um Cliente
        /// </summary>
        public int Nif
        {
            set { nif = value; }
            get { return nif; }
        }

        /// <summary>
        /// Propriedade do codigo Cliente de um Cliente
        /// </summary>
        public int NumeroContribuinte
        {
            set { numeroContribuinte = value; }
            get { return numeroContribuinte; }
        }

        /// <summary>
        /// Propriedade do contacto de um Cliente
        /// </summary>
        public int Contacto
        {
            set { contacto = value; }
            get { return contacto; }
        }

        /// <summary>
        /// Propriedade do email de um Cliente
        /// </summary>
        public string Email
        {
            set { email = value; }
            get { return email; }
        }

        /// <summary>
        /// Propriedade do saldo de um Cliente
        /// </summary>
        public float Saldo 
        {  
            set { saldo = value; }
            get { return saldo; }
        }


        #endregion

        #region OPERADORES

        /// <summary>
        /// Verificar se um objeto da classe Cliente é igual ao outro objeto
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        #region OPERADORES
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            if (c1.codigoCliente == c2.codigoCliente)
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
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            if (c1 == c2) { return false; }
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
            return "|Nome: " + Nome + "|Idade: " + Idade + "|Data Nascimento: " + DataNascimento + "|Sexo: " + Sexo + "|Morada: " + Morada + "|Codigo Cliente: " + codigoCliente + "|Nif: " + nif + "|Numero Contribuinte: " + numeroContribuinte + "|Contacto: " + contacto + "|Email: " + email + "|Saldo: "+ saldo;
        }

        /// <summary>
        /// Verificar se os dois objetos são do mesmo tipo
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Cliente)
            {
                Cliente c = (Cliente)obj;
                if (this == c)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Obtém um código hash para a Cliente.
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