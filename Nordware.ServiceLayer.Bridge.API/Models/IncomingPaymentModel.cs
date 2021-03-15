using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nordware.ServiceLayer.Bridge.API.Models
{
    /// <summary>
    /// Contas a Receber
    /// </summary>
    public class IncomingPaymentModel
    {
        public int DocEntry { get; set; }
        /// <summary>
        /// Nr. Documento
        /// </summary>
        public int DocNum { get; set; }
        /// <summary>
        /// ID Filial (Tabela OBPL)
        /// </summary>
        public int BPLID { get; set; }
        /// <summary>
        /// Data de Lançamento (yyyy-MM-dd)
        /// </summary>
        public string DocDate { get; set; }
        /// <summary>
        /// Data de Vencimento (yyyy-MM-dd)
        /// </summary>
        public string DocDueDate { get; set; }
        /// <summary>
        /// Data do documento (yyyy-MM-dd)
        /// </summary>
        public string TaxDate { get; set; }
        /// <summary>
        /// Cód. Cliente (Tabela OCRD)
        /// </summary>
        public string CardCode { get; set; }
        /// <summary>
        /// Valor Total do pagamento em DINHEIRO
        /// </summary>
        public double CashSum { get; set; }
        /// <summary>
        /// Conta contábil de pagamento em CHEQUE
        /// </summary>
        public string CheckAccount { get; set; }
        /// <summary>
        /// Conta contábil de pagamento em TRANSFERÊNCIA
        /// </summary>
        public string TransferAccount { get; set; }
        /// <summary>
        /// Valor Total do pagamento em TRANSFERÊNCIA
        /// </summary>
        public double TransferSum { get; set; }
        /// <summary>
        /// Data da transferência (yyyy-MM-dd)
        /// </summary>
        public string TransferDate { get; set; }
        //public string Reference1 { get; set; }
        //public string Reference2 { get; set; }
        /// <summary>
        /// Observações
        /// </summary>
        public string Remarks { get; set; }
        /// <summary>
        /// Código do projeto
        /// </summary>
        public string ProjectCode { get; set; }

        /// <summary>
        /// Conta contábil de pagamento em BOLETO
        /// </summary>
        public string BoeAccount { get; set; }
        /// <summary>
        /// Valor Total do pagamento em BOLETO
        /// </summary>
        public double BillOfExchangeAmount { get; set; }
        /// <summary>
        /// Cancelado
        /// </summary>
        public string Cancelled { get; set; }
        /// <summary>
        /// Linhas do documento
        /// </summary>
        public Paymentinvoice[] PaymentInvoices { get; set; }
        /// <summary>
        /// Dados do cartão de crédito
        /// </summary>
        public Paymentcreditcard[] PaymentCreditCards { get; set; }
        /// <summary>
        /// Dados do cartão de boleto
        /// </summary>
        public Billofexchange BillOfExchange { get; set; }
    }

    /// <summary>
    /// Dados do boleto
    /// </summary>
    public class Billofexchange
    {
        /// <summary>
        /// Número do boleto
        /// </summary>
        public int BillOfExchangeNo { get; set; }
        /// <summary>
        /// Data de vencimento do boleto
        /// </summary>
        public string BillOfExchangeDueDate { get; set; }
        /// <summary>
        /// Obsevações
        /// </summary>
        //public string Details { get; set; }
        /// <summary>
        /// Referência
        /// </summary>
        public string ReferenceNo { get; set; }
        /// <summary>
        /// Observações
        /// </summary>
        public string Remarks { get; set; }
        /// <summary>
        /// Forma de pagamento (Tabela OPYM)
        /// </summary>
        public string PaymentMethodCode { get; set; }
    }

    /// <summary>
    /// Linhas do documento
    /// </summary>
    public class Paymentinvoice
    {
        //public int LineNum { get;  }
        /// <summary>
        /// DocEntry do documento que está sendo pago
        /// </summary>
        public int DocEntry { get; set; }
        /// <summary>
        /// Valor pago
        /// </summary>
        public double SumApplied { get; set; }
        /// <summary>
        /// Linha do documento base (em caso de ser LCM - Linha da JDT1)
        /// </summary>
        public int DocLine { get; set; }
        /// <summary>
        /// Tipo de documento - it_Invoice para Nota Fiscal de Saída
        /// </summary>
        public string InvoiceType { get; set; }
        //public double PaidSum { get; set; }
        /// <summary>
        /// Número da parcela (por exemplo tabela INV6)
        /// </summary>
        public int InstallmentId { get; set; }
        /// <summary>
        /// Regra de distribuição 1
        /// </summary>
        public string DistributionRule { get; set; }
        /// <summary>
        /// Regra de distribuição 2
        /// </summary>
        public string DistributionRule2 { get; set; }
        /// <summary>
        /// Regra de distribuição 3
        /// </summary>
        public string DistributionRule3 { get; set; }
        /// <summary>
        /// Regra de distribuição 4
        /// </summary>
        public string DistributionRule4 { get; set; }
        /// <summary>
        /// Regra de distribuição 5
        /// </summary>
        public string DistributionRule5 { get; set; }
    }

    /// <summary>
    /// Dados do cartão de crédito
    /// </summary>
    public class Paymentcreditcard
    {
        /// <summary>
        /// Id do cartão de crédito (Tabela OCRC)
        /// </summary>
        public int CreditCard { get; set; }
        /// <summary>
        /// Conta contábil de pagamento em Cartão de Crédito
        /// </summary>
        public string CreditAcct { get; set; }
        /// <summary>
        /// Número do cartão de crédito
        /// </summary>
        public string CreditCardNumber { get; set; }
        /// <summary>
        /// Validade do cartão (formato dd/yyyy)
        /// </summary>
        public string CardValidUntil { get; set; }
        /// <summary>
        /// Número da TID
        /// </summary>
        public string VoucherNum { get; set; }
        /// <summary>
        /// Forma de pagamento (Tabela OCRP)
        /// </summary>
        public int PaymentMethodCode { get; set; }
        /// <summary>
        /// Quantidade de parcelas
        /// </summary>
        public int NumOfPayments { get; set; }
        /// <summary>
        /// Data do primeiro vencimento
        /// </summary>
        public string FirstPaymentDue { get; set; }
        /// <summary>
        /// Valor da primeira parcela
        /// </summary>
        public double FirstPaymentSum { get; set; }
        /// <summary>
        /// Valor das demais parcelas
        /// </summary>
        public double AdditionalPaymentSum { get; set; }
        /// <summary>
        /// Valor total pago
        /// </summary>
        public double CreditSum { get; set; }
        /// <summary>
        /// Pagamento parcelado (BoYesNoEnum.tYES ou BoYesNoEnum.tNO)
        /// </summary>
        public string SplitPayments { get; set; }
    }
}
