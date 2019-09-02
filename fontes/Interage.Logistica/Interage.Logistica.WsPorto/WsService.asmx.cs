using System.Web.Services;

namespace Interage.Logistica.WsEcoPorto
{
    /// <summary>
    /// Summary description for WsService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WsService : WebService
    {

        [WebMethod]
        public string HelloWorld(string nome)
        {
            return $"Hello {nome}";
        }

        [WebMethod]
        public string GeraProgramacao (string Usuario, string Senha, string Container, long CodOrigem, string NomeOrigem, long CodDestino, string NomeDestino)
        {
            return $"Ola {Usuario}";
        }

        [WebMethod]
        public string FinalizaMonitor(string Usuario, string Senha, string TransportadorCnpj, string Container, long CodOrigem, long DataHora)
        {
            return $"Ola {Usuario}";
        }


    }
    public class Usuario
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
    }

}
