using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceL
{
    /// <summary>
    /// Descripción breve de wsL
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsL : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        //Create
        [WebMethod]
        public Informe CreateInforme(string usuario, string evento, string lugar)
        {
            dataLE data = new dataLE();
            return data.AddInforme(usuario, evento, lugar);
        }

        // READ ALL
        [WebMethod]
        public List<Informe> GetAllInformes()
        {
            dataLE data = new dataLE();
            return data.GetAllInformes();
        }

        // UPDATE
        [WebMethod]
        public bool UpdateInforme(int id, string usuario, string evento, string lugar)
        {
            dataLE data = new dataLE();
            return data.UpdateInforme(id, usuario, evento, lugar);
        }

        // DELETE
        [WebMethod]
        public bool DeleteInforme(int id)
        {
            dataLE data = new dataLE();
            return data.DeleteInforme(id);
        }
    }
}
