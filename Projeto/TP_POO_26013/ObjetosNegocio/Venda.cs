/*
* Descrição: Desenvolvimento classe Venda
* Nome: Pedro Rei
* Contacto: pedro28rei@gmail.com
* Data: 29/12/2023
* LESI - POO
* 
*/


namespace ObjetosNegocio
{
    /// <summary>
    /// Classe da venda de um automóvel
    /// </summary>
    public class Venda
    {
        #region ATRIBUTOS     

        int codigoVenda;
        float valorVenda;
        string data;
        int anosGarantia;

        #endregion

        #region METODOS                                                                         

        #region CONSTRUTORES

        /// <summary>
        /// Construtor por omissão sem parâmetros definidos
        /// </summary>
        public Venda()
        {
            codigoVenda = 0;
            valorVenda = 0;
            data = string.Empty;
            anosGarantia = 0;
        }

        /// <summary>
        /// Construtor por omissão com parâmetros definidos
        /// </summary>
        /// <param name="valorVenda"></param>
        /// <param name="data"></param>
        /// <param name="anosGarantia"></param>
        public Venda(int codigoVenda, float valorVenda, string data, int anosGarantia)
        {
            this.codigoVenda = codigoVenda;
            this.valorVenda = valorVenda;
            this.data = data;
            this.anosGarantia = anosGarantia;
        }

        #endregion

        #region PROPRIEDADES
        
        /// <summary>
        /// Propriedade do codigo de venda de uma venda
        /// </summary>
        public int CodigoVenda
        {
            set { codigoVenda = value; }
            get { return codigoVenda; }
        }

        /// <summary>
        /// Propriedade do Valor da Venda de um automóvel
        /// </summary>
        public float ValorVenda
        {
            set { valorVenda = value; }
            get { return valorVenda; }
        }

        /// <summary>
        /// Propriedade da data de uma venda de um automóvel
        /// </summary>
        public string Data
        {
            set { data = value; }
            get { return data; }
        }  

        /// <summary>
        /// Propriedade dos anos de garantia de uma venda
        /// </summary>
        public int AnosGarantia
        {
            set { anosGarantia = value; }
            get { return anosGarantia; }
        }
        #endregion

        #region OPERADORES

        /// <summary>
        /// Verificar se um objeto da classe Venda é igual ao outro objeto
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Venda p1, Venda p2)
        {
            if ((p1.codigoVenda == p2.codigoVenda))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Verificar se um objeto da classe Venda é diferente do outro objeto
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Venda p1, Venda p2)
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
            return "|CodigoVenda: " + codigoVenda + "|Valor: " + valorVenda + "|Data Venda: " + data +"|Anos de Garantia: " + anosGarantia;
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
                Venda p = (Venda)obj;
                if (this == p)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Obtém um código hash para a venda.
        /// </summary>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion

        #region OUTROSMETODOS
        #endregion

        #endregion
    }
}
