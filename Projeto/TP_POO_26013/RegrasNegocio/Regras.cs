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
        public static bool OrdenarMotasBD()
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
        /// Método que define as regras para poder adicionar um Cliente na lista, e retorna true em com sucesso ou false caso o oposto
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static bool AdicionarClienteBD(Cliente cliente)
        {
            if (cliente.CodigoCliente <= 0 || cliente.Nif <= 0 || cliente.NumeroContribuinte < 0 || cliente.Idade < 18 ||
        cliente.Nome == string.Empty || cliente.Saldo >= 0 ) return false;
            else return Clientes.AdicionarCliente(cliente);
        }

        /// <summary>
        /// Método que define as regras para poder remover um Cliente da lista, e retorna true em caso de sucesso ou false caso o oposto
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static bool RemoverClienteBD(Cliente cliente)
        {
            return Clientes.RemoverCliente(cliente);
        }

        /// <summary>
        /// Método que define as regras para poder ordenar a lista de Clientes, e retorna true em caso de sucesso e false caso o oposto
        /// </summary>
        /// <returns></returns>
        public static bool OrdenarClienteBD()
        {
            return Clientes.OrdenarCliente();
        }

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
        /// Método que define as regras para poder adicionar um Vendedor na lista, e retorna true em com sucesso ou false caso o oposto
        /// </summary>
        /// <param name="vendedor"></param>
        /// <returns></returns>
        public static bool AdicionarVendedorBD(Vendedor vendedor)
        {
            if (vendedor.IdVendedor <= 0 || vendedor.CodigoTrabalhador <= 0 || vendedor.Salario < 820 || vendedor.Idade < 18 ||
        vendedor.Nome == string.Empty || vendedor.AnosServico < 0 || vendedor.NivelCargo <0) return false;
            else return Vendedores.AdicionarVendedor(vendedor);
        }

        /// <summary>
        /// Método que define as regras para poder remover um Vendedor da lista, e retorna true em caso de sucesso ou false caso o oposto
        /// </summary>
        /// <param name="vendedor"></param>
        /// <returns></returns>
        public static bool RemoverVendedorBD(Vendedor vendedor)
        {
            return Vendedores.RemoverVendedor(vendedor);
        }

        /// <summary>
        /// Método que define as regras para poder ordenar a lista de Vendedores, e retorna true em caso de sucesso e false caso o oposto
        /// </summary>
        /// <returns></returns>
        public static bool OrdenarVendedorBD()
        {
            return Vendedores.OrdenarVendedor();
        }

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
        /// Método que define as regras para poder adicionar um Administrador na lista, e retorna true em com sucesso ou false caso o oposto
        /// </summary>
        /// <param name="administrador"></param>
        /// <returns></returns>
        public static bool AdicionarAdministradorBD(Administrador administrador)
        {
            if (administrador.IdAdmin <= 0 || administrador.CodigoTrabalhador <= 0 || administrador.Salario < 820 || administrador.Idade < 18 ||
        administrador.Nome == string.Empty || administrador.AnosServico < 0 || administrador.NivelCargo < 0) return false;
            else return Administradores.AdicionarAdministrador(administrador);
        }

        /// <summary>
        /// Método que define as regras para poder remover um Administrador da lista, e retorna true em caso de sucesso ou false caso o oposto
        /// </summary>
        /// <param name="administrador"></param>
        /// <returns></returns>
        public static bool RemoverAdministradorBD(Administrador administrador)
        {
            return Administradores.RemoverAdministrador(administrador);
        }

        /// <summary>
        /// Método que define as regras para poder ordenar a lista de Administradores, e retorna true em caso de sucesso e false caso o oposto
        /// </summary>
        /// <returns></returns>
        public static bool OrdenarAdministradorBD()
        {
            return Administradores.OrdenarAdministrador();
        }

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

        #region REGRAS LIMPADORES

        /// <summary>
        /// Método que define as regras para poder adicionar um Administrador na lista, e retorna true em com sucesso ou false caso o oposto
        /// </summary>
        /// <param name="limpador"></param>
        /// <returns></returns>
        public static bool AdicionarLimpadorBD(Limpador limpador)
        {
            if (limpador.IdLimpador <= 0 || limpador.CodigoTrabalhador <= 0 || limpador.Salario < 820 || limpador.Idade < 18 ||
        limpador.Nome == string.Empty || limpador.AnosServico < 0 || limpador.NivelCargo < 0) return false;
            else return Limpadores.AdicionarLimpador(limpador);
        }

        /// <summary>
        /// Método que define as regras para poder remover um Administrador da lista, e retorna true em caso de sucesso ou false caso o oposto
        /// </summary>
        /// <param name="limpador"></param>
        /// <returns></returns>
        public static bool RemoverLimpadorBD(Limpador limpador)
        {
            return Limpadores.RemoverLimpador(limpador);
        }

        /// <summary>
        /// Método que define as regras para poder ordenar a lista de Limpadores, e retorna true em caso de sucesso e false caso o oposto
        /// </summary>
        /// <returns></returns>
        public static bool OrdenarLimpadoresBD()
        {
            return Limpadores.OrdenarLimpadores();
        }

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

        #region Regras Vendas

        
         
        /// </summary>
        /// Método que permite adicionar uma venda na lista, e retorna true em caso de sucesso ou false em caso o oposto
        /// <returns></returns>
        public static bool AdicionarVendaBD(Venda venda)
        {
            //if () return false;
            //else 
            return true; //Vendas.AdicionarVenda(venda);
        }

        /// <summary>
        /// Método que define as regras para poder remover uma Venda da lista, e retorna true em caso de sucesso ou false caso o oposto
        /// </summary>
        /// <param name="limpador"></param>
        /// <returns></returns>
        public static bool RemoverVendaBD(Venda venda)
        {
            return Vendas.RemoverVenda(venda);
        }

        /// <summary>
        /// Método que define as regras para poder ordenar a lista de Vendas, e retorna true em caso de sucesso e false caso o oposto
        /// </summary>
        /// <returns></returns>
        public static bool OrdenarVendasBD()
        {
            return Vendas.OrdenarVendas();
        }

        /// <summary>
        /// Metodo que define as regras para poder ler o ficheiro com os dados das Vendas, e retorna a lista em caso de sucesso
        /// </summary>
        /// <returns></returns>
        public static bool LerFicheiroVendasBD()
        {
            return Vendas.LerFicheiroVendas();
        }

        /// <summary>
        /// Metodo que define as regras para poder guardar o ficheiro com os dados das Vendas, e retorna true em caso de sucesso e false caso o oposto
        /// </summary>
        /// <returns></returns>
        public static bool GuardarFicheiroVendasBD()
        {
            return Vendas.GuardarFicheiroVendas();
        }

        #endregion
    }
}
