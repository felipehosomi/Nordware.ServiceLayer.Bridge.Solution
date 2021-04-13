using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Nordware.ServiceLayer.Bridge.API.Models;
using SBO.Hub.SBOHelpers;

namespace Nordware.ServiceLayer.Bridge.API.Controllers
{
    /// <summary>
    /// Adiantamento - Tabela ODPI
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DownPaymentController : Controller
    {
        private readonly IOptions<ServiceLayerConnection> ServiceLayerConnection;

        public DownPaymentController(IOptions<ServiceLayerConnection> serviceLayerConnection)
        {
            ServiceLayerConnection = serviceLayerConnection;
        }

        /// <summary>
        /// Insere Adiantamento
        /// </summary>
        /// <param name="model">DocumentModel</param>
        /// <returns>DocEntry Documento gerado</returns>
        [HttpPost]
        public string Post([FromBody] DocumentModel model)
        {
            model.DownPaymentType = "dptInvoice";

            //Remove valores de lote/série se não ocorre erro
            foreach (var item in model.DocumentLines)
            {
                item.BatchNumbers = null;
                item.SerialNumbers = null;
                item.DocumentLinesBinAllocations = null;
            }

            ServiceLayerUtil serviceLayerUtil = new ServiceLayerUtil(ServiceLayerConnection.Value);
            model = serviceLayerUtil.PostAndGetAdded<DocumentModel>("DownPayments", "DocEntry", model);

            return model.DocEntry.ToString();
        }
    }
}