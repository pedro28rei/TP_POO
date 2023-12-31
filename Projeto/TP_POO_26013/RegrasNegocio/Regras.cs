/*
* Descrição: Criação das regras de negócio
* Nome: Pedro Rei
* Contacto: pedro28rei@gmail.com
* Data: 27/12/2023
* LESI - POO
* 
*/

using BaseDados;
using ObjetosNegocio;


namespace RegrasNegocio
{
    /// <summary>
    /// Classe onde sáo definidas as regras de negócio que permitem o contacto entre o backend e o frontend
    /// </summary> 
    public class Regras
    {

        #region REGRAS CARROS

        /// <summary>
        /// Método que define as regras para poder adicionar um carro na lista, e retorna true em com sucesso ou false caso o oposto
        /// </summary>
        /// <param name="carro"></param>
        /// <returns></returns>
        public static bool AdicionarCarroBD(Carro carro)
        {
            if (carro.CodigoAutomovel <=0 || carro.CodigoCarro <= 0 || carro.Cavalos < 20 || carro.Matricula == string.Empty || 
        carro.Preco <= 100 ||  carro.DataFabrico == string.Empty) return false;
            else return Carros.AdicionarCarro(carro);
        }

        /// <summary>
        /// Método que define as regras para poder remover um carro da lista, e retorna true em caso de sucesso ou false caso o oposto
        /// </summary>
        /// <param name="carro"></param>
        /// <returns></returns>
        public static bool RemoverCarroBD(Carro carro)
        {
            return Carros.RemoverCarro(carro);
        }

        /// <summary>
        /// Método que define as regras para poder ordenar a lista de carros, e retorna true em caso de sucesso e false caso o oposto
        /// </summary>
        /// <returns></returns>
        public static bool OrdernarCarroBD()
        {
            return Carros.OrdenarCarro();
        }

        /// <summary>
        /// Método que define as regras para poder ler o ficheiro, e retorna true em caso de sucesso e  false em caso do oposto
        /// </summary>
        /// <returns></returns>
        public static bool LerFicheiroCarrosBD()
        {
            return Carros.LerFicheiroCarros();
        }

        /// <summary>
        /// Método que define as regras para poder guardar o ficheiro, e retorna true em caso de sucesso e false caso o oposto
        /// </summary>
        /// <returns></returns>
        public static bool GuardarFicheiroCarrosBD()
        {
            return Carros.GuardarFicheiroCarros();
        }


        #endregion

        #region REGRAS MOTAS

        /// <summary>
        /// Método que define as regras para poder adicionar uma Mota á lista, e retorna true em caso de sucesso ou false caso o oposto
        /// </summary>
        /// <param name="mota"></param>
        /// <returns></returns>
        public static bool AdicionarMotaBD(Mota mota)
        {
            if (mota.CodigoMota <= 0 || mota.CodigoAutomovel <= 0 || mota.Matricula == string.Empty || mota.DataFabrico == string.Empty
        || mota.Potencia < 15 || mota.Preco < 100) return false;
            else return Motas.AdicionarMota(mota);
        }


        /// <summary>
        /// Método que define as regras para poder remover uma Mota da lista, e retorna true em caso de sucesso ou false caso o oposto
        /// </summary>
        /// <param name="mota"></param>
        /// <returns></returns>
        public static bool RemoverMotaBD(Mota mota)
        {
            return Motas.RemoverMota(mota);
        }

        /// <summary>
        /// Metodo que define as regras para poder ordenar a lista de Motas, e retorna true em caso de sucesso e false caso o oposto
        /// </summary>
        /// <returns></returns>
        public static bool OrdernarMotasBD()
        {
            return Motas.OrdenarMotas();
        }


        /// <summary>
        /// Metodo que define as regras para poder ler o ficheiro com os dados das Motas, e retorna true em caso de sucesso e false caso o oposto
        /// </summary>
        /// <returns></returns>
        public static bool LerFicheiroMotasBD()
        {
            return Motas.LerFicheiroMotas();
        }

        /// <summary>
        /// Metodo que define as regras para poder guardar o ficheiro com os dados das Motas, e retorna true em caso de sucesso e false caso o oposto
        /// </summary>
        /// <returns></returns>
        public static bool GuardarFicheiroMotasBD()
        {
            return Motas.GuardarFicheiroMotas();
        }

        #endregion

        #region REGRAS CLIENTES


        /// <summary>
        /// Metodo que define as regras para poder ler o ficheiro com os dados dos Clientes, e retorna a lista em caso de sucesso
        /// </summary>
        /// <returns></returns>
        public static bool LerFicheiroClientesBD()
        {
            return Clientes.LerFicheiroClientes();
        }

        /// <summary>
        /// Metodo que define as regras para poder guardar o ficheiro com os dados dos Clientes, e retorna true em caso de sucesso e false caso o oposto
        /// </summary>
        /// <returns></returns>
        public static bool GuardarFicheiroClientesBD()
        {
            return Clientes.GuardarFicheiroClientes();
        }


        #endregion

        #region REGRAS VENDEDORES

        /// <summary>
        /// Metodo que define as regras para poder ler o ficheiro com os dados dos Vendedores, e retorna a lista em caso de sucesso
        /// </summary>
        /// <returns></returns>
        public static bool LerFicheiroVendedoresBD()
        {
            return Vendedores.LerFicheiroVendedores();
        }

        /// <summary>
        /// Metodo que define as regras para poder guardar o ficheiro com os dados dos Vendedores, e retorna true em caso de sucesso e false caso o oposto
        /// </summary>
        /// <returns></returns>
        public static bool GuardarFicheiroVendedoresBD()
        {
            return Vendedores.GuardarFicheiroVendedores();
        }

        #endregion

        #region REGRAS ADMINISTRADORES


        /// <summary>
        /// Metodo que define as regras para poder ler o ficheiro com os dados dos Administradores, e retorna a lista em caso de sucesso
        /// </summary>
        /// <returns></returns>
        public static bool LerFicheiroAdministradoresBD()
        {
            return Administradores.LerFicheiroAdministradores();
        }

        /// <summary>
        /// Metodo que define as regras para poder guardar o ficheiro com os dados dos Administradores, e retorna true em caso de sucesso e false caso o oposto
        /// </summary>
        /// <returns></returns>
        public static bool GuardarFicheiroAdministradoresBD()
        {
            return Administradores.GuardarFicheiroAdministradores();
        }

        #endregion

        #region REGRAS VENDEDORES


        /// <summary>
        /// Metodo que define as regras para poder ler o ficheiro com os dados dos Limpadores, e retorna a lista em caso de sucesso
        /// </summary>
        /// <returns></returns>
        public static bool LerFicheiroLimpadoresBD()
        {
            return Limpadores.LerFicheiroLimpadores();
        }

        /// <summary>
        /// Metodo que define as regras para poder guardar o ficheiro com os dados dos Limpadores, e retorna true em caso de sucesso e false caso o oposto
        /// </summary>
        /// <returns></returns>
        public static bool GuardarFicheiroLimpadoresBD()
        {
            return Limpadores.GuardarFicheiroLimpadores();
        }
        #endregion

    }
    }
