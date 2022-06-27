using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Return_Order_Portal.DataContext;
using Return_Order_Portal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Return_Order_Portal.Controllers
{
    public class UserController : Controller
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(UserController));
        static string TokenForLogin;
        private readonly ProcessContext db;
        public static ProcessRequest Req = new ProcessRequest();
        public static ProcessResponse Res = new ProcessResponse();
        private IConfiguration _config;



        public UserController(ProcessContext context, IConfiguration config)
        {
            db = context;
            _config = config;
        }

        public IActionResult Login()
        {
            _log4net.Info("Login initiated");


            var user = new Login();

            return View("Login", user);



        }


        //Token is being generated using Authorization MicroService
        public ActionResult Authentication(Login user)
        {
            try
            {


                _log4net.Info("Authentication initiated");
             
                TokenForLogin = GetToken(_config["Links:AuthorizationMicroService"] + "/Auth", user);
             
                _log4net.Info("Token recieved From Authentication MicroService");

                if (TokenForLogin == null)
                {
                    _log4net.Info("Login Failed");
                    ViewBag.Message = String.Format("Invalid Username Or Password");
                    return View("Login", user);
                }
                //return Content("Login Successful");
                _log4net.Info("Authentication Successful And Login Completed");
                var ComponentModel = new ProcessRequest();
                return View("ComponentProcessing");
            }
            catch (Exception ex)
            {
                _log4net.Info("Exception In Authentication ActionResult");
                return View("Error1", ex);
            }
        }

        //Form is being filled by the user and the form data is being sent to Component Microservice
        public async Task<ActionResult> ComponentProcessing(ProcessRequest component)
        {
            try
            {


                _log4net.Info("ComponentProcessingMicroservice initiated");
                string Results;
                using (var client = new HttpClient())
                {
                    ProcessRequest components = new ProcessRequest
                    {
                        Name = component.ComponentName,
                        ContactNumber = component.ContactNumber,
                        CreditCardNumber = component.CreditCardNumber,
                        CreditLimit = component.CreditLimit,
                        ComponentType = component.ComponentType,
                        ComponentName = component.ComponentName,
                        Quantity = component.Quantity,
                        IsPriorityRequest = component.IsPriorityRequest
                    };
                    Req = components;
                   

                    _log4net.Info("Token added to header");
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + TokenForLogin);
                 
                    var myJSON = JsonConvert.SerializeObject(components);
                    var httpContent = new StringContent(myJSON, Encoding.UTF8, "application/json");

                
                    _log4net.Info("Component Microservice uri invoked https://localhost:44308/api/ComponentProcessing/GetResponse");
                    var response = await client.PostAsync("https://localhost:44308/api/ComponentProcessing/GetResponse", httpContent);
                    if (response.Content!=null)
                    {
                        Results = await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        Results = null;
                    }
                }
                _log4net.Info("Response Received From Component Microservice");
                Res = JsonConvert.DeserializeObject<ProcessResponse>(Results);
                Res.RequestId = db.ProcessDb.Count() + 1;

                return View("ProcessResponse", Res);
            }
            catch (Exception ex)
            {
                _log4net.Info("Exception In Component ActionResult");
                return View("Error1", ex);
            }


        }


        public async Task<ActionResult> Confirmation()
        {
            try
            {


                _log4net.Info("Payment Confirmation initiated");
                Submission res = new Submission()
                {
                    Result = 0
                };
             

             
                string Result;
               
                string uri = string.Format("https://localhost:44308/api/ComponentProcessing/CompleteProcessing/{0},{1},{2},{3}", Res.RequestId, Req.CreditCardNumber, Req.CreditLimit, Res.ProcessingCharge);
                using (var client = new HttpClient())
                {

                    _log4net.Info("Confirmation sent to Component Microservice For Payment");
                     var response = await client.GetAsync(uri);
             

                    _log4net.Info("Component Microservice uri invoked https://localhost:44308/api/ComponentProcessing/CompleteProcessing");

                    if (response.Content != null)
                        Result = await response.Content.ReadAsStringAsync();
                    else
                        Result = null;


                }
                res.Result = int.Parse(JsonConvert.DeserializeObject<string>(Result));
                _log4net.Info("Success or failed Message received from Component Moicroservice");
         
                if (Result !=null)
                {
                    _log4net.Info("Respose added to db ");
                    db.ProcessDb.Add(Res);
                    db.SaveChanges();
                    return View("Confirmation", res);
                }
                else
                    return View("Failed");
            }
            catch (Exception ex)
            {
                _log4net.Info("Exception In Confirmation ActionResult");
                return View("Error1", ex);
            }

        }

        



        static string GetToken(string url, Login user)
        {

            var json = JsonConvert.SerializeObject(user);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                var response = client.PostAsync(url, data).Result;
                string name = response.Content.ReadAsStringAsync().Result;
                dynamic details = JObject.Parse(name);
                return details.token;
            }
        }
    }
}
