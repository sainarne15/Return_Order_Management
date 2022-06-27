using Component_Processing.Models;
using Component_Processing.Repositry;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Component_Processing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComponentProcessingController : ControllerBase
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(ComponentProcessingController));

        private readonly IComponentRepo _repo;
        /// <summary>
        /// Dependency Injection
        /// </summary>
        /// <param name="iConfig"></param>
        public ComponentProcessingController(IComponentRepo repo)
        {
            _repo = repo;
        }

        [Route("GetResponse")]
        [HttpPost]
        public IActionResult ComponentProcessing(ProcessRequest processRequest)
        {
            _log4net.Info("Component details invoked from User Input");
            

            try
            {
                return Ok(_repo.GetResponse(processRequest.Name, processRequest.ContactNumber, processRequest.CreditCardNumber,processRequest.CreditLimit,
                    processRequest.ComponentType, processRequest.ComponentName, processRequest.Quantity, processRequest.IsPriorityRequest));
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpGet]
        [Route("CompleteProcessing/{RequestId},{CreditCardNumber},{CreditLimit},{ProcessingCharge}")]
        public IActionResult CompleteProcessing(int RequestId, long CreditCardNumber, double CreditLimit, double ProcessingCharge)
        {
            try
            {
                _log4net.Info("Process Confirmation invoked by user");

                return Ok(_repo.GetCompletion(RequestId, CreditCardNumber, CreditLimit, ProcessingCharge));
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
