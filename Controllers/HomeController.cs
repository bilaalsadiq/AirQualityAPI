using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using AirQualityAPI.Models;
using Newtonsoft.Json;

namespace AirQualityAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult LoadCountryData()
        {
            Country country = new Country();
            return Json(country.LoadCountries(), JsonRequestBehavior.AllowGet);
        }


        public ActionResult LocationDetails(int? Id)
        {

            try
            {
                if (Id == null)
                {
                    return HttpNotFound();
                }

                string url = string.Format("https://u50g7n0cbj.execute-api.us-east-1.amazonaws.com/v2/locations/{0}?limit=100&page=1&offset=0&sort=desc&radius=1000&order_by=lastUpdated&dumpRaw=false", Id);

                using (WebClient client = new WebClient())
                {
                    string jsonString = client.DownloadString(url);

                    //Converting to OBJECT from JSON string.  

                    var myDeserializedClass = JsonConvert.DeserializeObject<RootObject>(jsonString);

                    if (myDeserializedClass.results.Count == 0)
                    {
                        return HttpNotFound();
                    }

                    else
                    {
                        return View(myDeserializedClass);
                    }


                }
            }

            catch (Exception ex)
            {
                return View(ex);
            }
        }
    }
}