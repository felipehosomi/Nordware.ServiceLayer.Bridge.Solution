using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Nordware.ServiceLayer.Bridge.API.Models;
using SBO.Hub.SBOHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nordware.ServiceLayer.Bridge.API.Controllers
{
    /// <summary>
    /// Nota Fiscal de Saída
    /// </summary>
    [Route("api/[controller]")]
    public class InvoiceController : Controller
    {
        private readonly IOptions<ServiceLayerConnection> ServiceLayerConnection;

        public InvoiceController(IOptions<ServiceLayerConnection> serviceLayerConnection)
        {
            ServiceLayerConnection = serviceLayerConnection;
        }

        /// <summary>
        /// Retorna dados NF
        /// </summary>
        /// <returns>NF</returns>
        [HttpGet]
        public DocumentModel Get(int docEntry)
        {
            ServiceLayerUtil serviceLayerUtil = new ServiceLayerUtil(ServiceLayerConnection.Value);
            DocumentModel model = serviceLayerUtil.GetByID<DocumentModel>("Invoices", docEntry);

            return model;
        }

        /// <summary>
        /// Insere NF
        /// </summary>
        /// <returns>DocEntry NF gerada</returns>
        [HttpPost]
        public string Post([FromBody] DocumentModel model)
        {
            ServiceLayerUtil serviceLayerUtil = new ServiceLayerUtil(ServiceLayerConnection.Value);
            model = serviceLayerUtil.PostAndGetAdded<DocumentModel>("Invoices", "DocEntry", model);

            return model.DocEntry.ToString();
        }
    }
}
