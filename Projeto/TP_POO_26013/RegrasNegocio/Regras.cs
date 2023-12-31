/*
* Descrição: Criação das regras de negócio
* Nome: Pedro Rei
* Contacto: pedro28rei@gmail.com
* Data: 27/12/2023
* LESI - POO
* 
* 
*/

using ObjetosNegocio;
using BaseDados;
using System.Collections.Generic;

namespace RegrasNegocio
{
    /// <summary>
    /// Classe onde sáo definidas as regras de negócio  que permitem o contacto entre o backend e o frontend
    /// </summary> 
    public class Regras
    {

        #region REGRAS CARROS

        /// <summary>
        /// Metodo que define as regras para poder adicionar um carro na lista, e retorna true em com sucesso ou false caso o oposto
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
        /// Metodo que define as regras para poder remover um carro da lista, e retorna true em caso de sucesso ou false caso o oposto
        /// </summary>
        /// <param name="carro"></param>
        /// <returns></returns>
        public static bool RemoverCarroBD(Carro carro)
        {
            return Carros.RemoverCarro(carro);
        }

        /// <summary>
        /// Metodo que define as regras para poder ordenar a lista de carros, e retorna true em caso de sucesso e false caso o oposto
        /// </summary>
        /// <returns></returns>
        public static bool OrdernarCarroBD()
        {
            return Carros.OrdenarCarro();
        }

        /// <summary>
        /// Metodo que define as regras para poder ler o ficheiro, e retorna a lista em caso de sucesso
        /// </summary>
        /// <returns></returns>
        public static bool LerFicheiroCarrosBD()
        {
            return Carros.LerFicheiroCarros();
        }

        /// <summary>
        /// Metodo que define as regras para poder guardar o ficheiro, e retorna true em caso de sucesso e false caso o oposto
        /// </summary>
        /// <returns></returns>
        public static bool GuardarFicheiroCarrosBD()
        {
            return Carros.GuardarFicheiroCarros();
        }


        #endregion

        #region REGRAS MOTAS

        /// <summary>
        /// Classe que define as regras para poder adicionar uma mota a lista
        /// </summary>
        /// <param name="mota"></param>
        /// <returns></returns>
        public static bool AdicionarMotaBD(Mota mota)
        {
            if (mota.CodigoMota == 0 || mota.Matricula == string.Empty) return false;
            else return Motas.AdicionarMota(mota);
        }

        /// <summary>
        /// Metodo que define as regras para poder ler o ficheiro, e retorna a lista em caso de sucesso
        /// </summary>
        /// <returns></returns>
        public static bool LerFicheiroMotasBD()
        {
            return Motas.LerFicheiroMotas();
        }

        /// <summary>
        /// Metodo que define as regras para poder guardar o ficheiro, e retorna true em caso de sucesso e false caso o oposto
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
