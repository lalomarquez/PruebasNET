using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace Log4NetMVC.Controllers
{
    public class InicioController : Controller
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        //static InicioController()
        //{
        //    XmlConfigurator.Configure();
        //}


        // GET: Inicio
        public ActionResult Index()
        {                        
            try
            {
                //SqlConnection myConnection = new SqlConnection(@"Data Source=LALOMARQUEZ-PC\SQLEXPRESSLALO;Initial Catalog=PruebasDB;Integrated Security=True;");
                //myConnection.Open();

                log.Info("Inicio ActionResult");
                int x, y, z;
                x = 5; y = 0;
                z = x / y;
            }
            catch (Exception ex)
            {
                log.Error("Exception", ex);
            }
            return View();
        }
    }
}