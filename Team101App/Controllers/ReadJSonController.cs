using System.Web;
using System.Web.Mvc;
using Team101App.Models;
using System.Web.Script.Serialization; // for serialize and deserialize  
using System.IO; // for File operation  
namespace Team101App.Controllers
{
    public class ReadJsonController : Controller
    {
        // GET: ReadJson  
        public ActionResult Index()
        {
            //get the Json filepath  
            string file = Server.MapPath("~/App_Data/output.json");
            //deserialize JSON from file  
            string Json = System.IO.File.ReadAllText(file);
            JavaScriptSerializer ser = new JavaScriptSerializer();
            var recordlist = ser.Deserialize <System.Collections.Generic.List<Record>> (Json);
            return View(recordlist);
        }
    }
}