/*
* Descrição: Elaboração da classe Trabalhador
* Nome: Pedro Rei
* Contacto: pedro28rei@gmail.com
* Data: 07/11/2023
* LESI - POO
* 
* 
*/

namespace Pessoas
{
    /// <summary>
    /// Classe Dono, que herda a classe Pessoa
    /// </summary>
    public class Dono : Pessoa
    {
        #region ATRIBUTOS

        int codigoDono;

        #endregion


        #region METODOS


        #region CONSTRUTORES

        /// <summary>
        /// Construtor por omissão que cria um Trabalhador, sem parâmetros definidos 
        /// </summary>
        public Dono()
        {
            codigoDono = 0;
        }

        /// <summary>
        /// Construtor por omissão que cria um Trabalhador, com parâmetros definidos 
        /// </summary>
        /// <param name="codigoDono"></param>
        public Dono(int codigoDono)
        {
            this.codigoDono = codigoDono;
        }

        #endregion

        #region PROPRIEDADES

        /// <summary>
        /// 
        /// </summary>
        public int CodigoDono
        {
            set { codigoDono = value; }
            get { return codigoDono; }
        }

        #endregion

        #region OPERADORES

        /// <summary>
        /// Verificar se um objeto da classe Trabalhador é igual ao outro objeto
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        public static bool operator ==(Dono d1, Dono d2)
        {
            if (d1.codigoDono == d2.codigoDono)
            {
                return true;
            }
            return false;
        }


        /// <summary>
        /// Verificar se um objeto da classe Dono é diferente do outro objeto
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Dono d1, Dono d2)
        {
            if (d1 == d2) { return false; }
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
            return "|Nome: " + Nome + "|Idade: " + Idade + "|Data Nascimento: " + DataNascimento + "|Sexo: " + Sexo + "|Morada: " + Morada + "|Codigo Dono: " + codigoDono;
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
                Dono d = (Dono)obj;
                if (this == d)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Obtém um código hash para a Dono
        /// </summary>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion

        #endregion
    }
}
