using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WS
{
    /// <summary>
    /// Description résumée de sws_chat
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class sws_chat : System.Web.Services.WebService
    {

        [WebMethod]
        public bool Participer(string pseudo)
        {
            bool valable = !Outil.Exists(pseudo);

            if (valable)
            {
                Outil.insertParticipant(pseudo);
                return true;
            }
            return false;
        }

        [WebMethod]
        public List<participant> Participants()
        {
            return Outil.GetParticipants();
        }

        [WebMethod]
        public List<Message> Messages()
        {
            return Outil.GetMessages();
        }

        [WebMethod]
        public void DeleteParticipants(string pseudo, int id)
        {
            Outil.delete(pseudo, id);
        }

        [WebMethod]
        public void InsertMessage(string message, int id)
        {
            Outil.Insert(message, id);
        }

        [WebMethod]
        public int getParticipantByPseudo(string pseudo)
        {
            return Outil.getByPseudo(pseudo);
        }

        [WebMethod]
        public string getParticipantById(int id)
        {
            return Outil.getById(id);
        }


    }
}
