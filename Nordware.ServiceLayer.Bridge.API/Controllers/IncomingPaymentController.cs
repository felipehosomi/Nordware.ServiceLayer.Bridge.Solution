using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Nordware.ServiceLayer.Bridge.API.Models;
using SBO.Hub.SBOHelpers;

namespace Nordware.ServiceLayer.Bridge.API.Controllers
{
    /// <summary>
    /// Contas a receber
    /// </summary>
    [Route("api/[controller]")]
    public class IncomingPaymentController : Controller
    {
        private readonly IOptions<ServiceLayerConnection> ServiceLayerConnection;

        public IncomingPaymentController(IOptions<ServiceLayerConnection> serviceLayerConnection)
        {
            ServiceLayerConnection = serviceLayerConnection;
        }

        /// <summary>
        /// Insere Contas a Receber
        /// </summary>
        /// <param name="model">IncomingPaymentModel</param>
        /// <returns>DocEntry CR gerado</returns>
        [HttpPost]
        public string Post([FromBody] IncomingPaymentModel model)
        {
            ServiceLayerUtil serviceLayerUtil = new ServiceLayerUtil(ServiceLayerConnection.Value);
            model = serviceLayerUtil.PostAndGetAdded<IncomingPaymentModel>("IncomingPayments", "DocEntry", model);

            return model.DocEntry.ToString();
        }
    }
}