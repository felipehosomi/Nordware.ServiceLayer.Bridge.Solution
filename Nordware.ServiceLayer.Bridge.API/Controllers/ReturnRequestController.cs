using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Nordware.ServiceLayer.Bridge.API.Models;
using SBO.Hub.SBOHelpers;

namespace Nordware.ServiceLayer.Bridge.API.Controllers
{
    /// <summary>
    /// Pedido de Devolução - Tabela ORRR
    /// </summary>
    [Route("api/[controller]")]
    public class ReturnRequestController : Controller
    {
        private readonly IOptions<ServiceLayerConnection> ServiceLayerConnection;

        public ReturnRequestController(IOptions<ServiceLayerConnection> serviceLayerConnection)
        {
            ServiceLayerConnection = serviceLayerConnection;
        }

        /// <summary>
        /// Insere Pedido de Devolução
        /// </summary>
        /// <param name="model">DocumentModel</param>
        /// <returns>DocEntry Documento gerado</returns>
        [HttpPost]
        public string Post([FromBody] DocumentModel model)
        {
            ServiceLayerUtil serviceLayerUtil = new ServiceLayerUtil(ServiceLayerConnection.Value);
            model = serviceLayerUtil.PostAndGetAdded<DocumentModel>("ReturnRequest", "DocEntry", model);

            return model.DocEntry.ToString();
        }
    }
}