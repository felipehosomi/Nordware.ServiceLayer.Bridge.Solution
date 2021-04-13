using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace Nordware.ServiceLayer.Bridge.API.Models
{
    /// <summary>
    /// Documento de Marketing
    /// </summary>
    public class DocumentModel
    {
        public int DocEntry { get; set; }
        /// <summary>
        /// Nr. Documento
        /// </summary>
        public int DocNum { get; set; }
        /// <summary>
        /// ID Filial (Tabela OBPL)
        /// </summary>
        [Required]
        [Range(1, int.MaxValue)]
        public int BPL_IDAssignedToInvoice { get; set; }
        /// <summary>
        /// Data de Lançamento (yyyy-MM-dd)
        /// </summary>
        [Required]
        public string DocDate { get; set; }
        /// <summary>
        /// Data de Vencimento (yyyy-MM-dd)
        /// </summary>
        [Required]
        public string DocDueDate { get; set; }
        /// <summary>
        /// Data do documento (yyyy-MM-dd)
        /// </summary>
        [Required]
        public string TaxDate { get; set; }
        /// <summary>
        /// Cód. Cliente (Tabela OCRD)
        /// </summary>
        [Required]
        public string CardCode { get; set; }
        /// <summary>
        /// Nome Cliente
        /// </summary>
        public string CardName { get; set; }

        public string DownPaymentType { get; set; }
        //public string NumAtCard { get; set; }
        //public double DocTotal { get; set; }
        //public string DocCurrency { get; set; }
        //public double DocRate { get; set; }
        /// <summary>
        /// Observações
        /// </summary>
        public string Comments { get; set; }
        //public string JournalMemo { get; set; }
        /// <summary>
        /// Condição de pagamento (Tabela OCTG)
        /// </summary>
        public int? PaymentGroupCode { get; set; }
        /// <summary>
        /// Id Vendedor (Tabela OSLP)
        /// </summary>
        public int SalesPersonCode { get; set; }
        //public int Series { get; set; }
        /// <summary>
        /// Porcentagem de Desconto
        /// </summary>
        public double DiscountPercent { get; set; }

        /// <summary>
        /// Modelo NF (Tabela NFN1) - Obrigatório para NOTA FISCAL
        /// </summary>
        public int SequenceCode { get; set; }
        /// <summary>
        /// Número da NF
        /// </summary>
        /// [Range(1, int.MaxValue)]
        public int SequenceSerial { get; set; }
        /// <summary>
        /// Número de Série
        /// </summary>
        public string SeriesString { get; set; }
        //public string SubSeriesString { get; set; }
        /// <summary>
        /// Modelo NF (Tabela ONFM)
        /// </summary>
        public string SequenceModel { get; set; }
        //public double TotalDiscount { get; set; }
        /// <summary>
        /// Observações Iniciais
        /// </summary>
        public string OpeningRemarks { get; set; }
        /// <summary>
        /// Observações Finais
        /// </summary>
        public string ClosingRemarks { get; set; }
        /// <summary>
        /// Cancelado
        /// </summary>
        public string Cancelled { get; set; }
        /// <summary>
        /// Forma de Pagamento (Tabela OPYM)
        /// </summary>
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Itens
        /// </summary>
        [Required]
        public Documentline[] DocumentLines { get; set; }
        /// <summary>
        /// Despesas Adicionais
        /// </summary>
        public Documentadditionalexpens[] DocumentAdditionalExpenses { get; set; }
        /// <summary>
        /// Parcelas
        /// </summary>
        public Documentinstallment[] DocumentInstallments { get; set; }
        //public string[] DownPaymentsToDraw { get; set; }
        public Taxextension TaxExtension { get; set; }
        //public Addressextension AddressExtension { get; set; }
    }

    public class Taxextension
    {
        //public string TaxId0 { get; set; }
        //public string TaxId1 { get; set; }
        //public string TaxId2 { get; set; }
        //public string TaxId3 { get; set; }
        //public string TaxId4 { get; set; }
        //public string TaxId5 { get; set; }
        //public string TaxId6 { get; set; }
        //public string TaxId7 { get; set; }
        //public string TaxId8 { get; set; }
        //public string TaxId9 { get; set; }
        //public string State { get; set; }
        //public string County { get; set; }
        /// <summary>
        /// Incoterms
        /// </summary>
        public string Incoterms { get; set; }
        //public string Vehicle { get; set; }
        //public string VehicleState { get; set; }
        //public string NFRef { get; set; }
        //public string Carrier { get; set; }
        /// <summary>
        /// Quantidade Embalagens
        /// </summary>
        public int? PackQuantity { get; set; }
        /// <summary>
        /// Descrição Embalagem
        /// </summary>
        public string PackDescription { get; set; }
        //public string Brand { get; set; }
        //public string ShipUnitNo { get; set; }
        //public double NetWeight { get; set; }
        //public double GrossWeight { get; set; }
        //public string StreetS { get; set; }
        //public string BlockS { get; set; }
        //public string BuildingS { get; set; }
        //public string CityS { get; set; }
        //public string ZipCodeS { get; set; }
        //public string CountyS { get; set; }
        //public string StateS { get; set; }
        //public string CountryS { get; set; }
        //public string StreetB { get; set; }
        //public string BlockB { get; set; }
        //public string BuildingB { get; set; }
        //public string CityB { get; set; }
        //public string ZipCodeB { get; set; }
        //public string CountyB { get; set; }
        //public string StateB { get; set; }
        //public string CountryB { get; set; }
        //public string ImportOrExport { get; set; }
        /// <summary>
        /// ID Utilização Principal (Tabela OUSG)
        /// </summary>
        public int? MainUsage { get; set; }
        //public string GlobalLocationNumberS { get; set; }
        //public string GlobalLocationNumberB { get; set; }
        //public string TaxId12 { get; set; }
        //public string TaxId13 { get; set; }
        //public string BillOfEntryNo { get; set; }
        //public string BillOfEntryDate { get; set; }
        //public string OriginalBillOfEntryNo { get; set; }
        //public string OriginalBillOfEntryDate { get; set; }
        //public string ImportOrExportType { get; set; }
        //public string PortCode { get; set; }
    }

    public class Addressextension
    {
        public string ShipToStreet { get; set; }
        public string ShipToStreetNo { get; set; }
        public string ShipToBlock { get; set; }
        public string ShipToBuilding { get; set; }
        public string ShipToCity { get; set; }
        public string ShipToZipCode { get; set; }
        public string ShipToCounty { get; set; }
        public string ShipToState { get; set; }
        public string ShipToCountry { get; set; }
        public string ShipToAddressType { get; set; }
        public string BillToStreet { get; set; }
        public string BillToStreetNo { get; set; }
        public string BillToBlock { get; set; }
        public string BillToBuilding { get; set; }
        public string BillToCity { get; set; }
        public string BillToZipCode { get; set; }
        public string BillToCounty { get; set; }
        public string BillToState { get; set; }
        public string BillToCountry { get; set; }
        public string BillToAddressType { get; set; }
        public string ShipToGlobalLocationNumber { get; set; }
        public string BillToGlobalLocationNumber { get; set; }
        public string ShipToAddress2 { get; set; }
        public string ShipToAddress3 { get; set; }
        public string BillToAddress2 { get; set; }
        public string BillToAddress3 { get; set; }
        public string PlaceOfSupply { get; set; }
    }

    /// <summary>
    /// Itens do documento
    /// </summary>
    public class Documentline
    {
        //public int LineNum { get; set; }
        /// <summary>
        /// Código do item (Tabela OITM)
        /// </summary>
        [Required]
        public string ItemCode { get; set; }
        /// <summary>
        /// Descrição do item (Não obrigatório)
        /// </summary>
        public string ItemDescription { get; set; }
        /// <summary>
        /// Quantidade
        /// </summary>
        [Required]
        public double Quantity { get; set; }
        //public string ShipDate { get; set; }
        /// <summary>
        /// Preço unitário
        /// </summary>
        [Required]
        public double Price { get; set; }
        //public string Currency { get; set; }
        /// <summary>
        /// Percentual de desconto
        /// </summary>
        public double DiscountPercent { get; set; }
        /// <summary>
        /// Código depósito (Tabela OWHS)
        /// </summary>
        public string WarehouseCode { get; set; }
        //public double CommisionPercent { get; set; }
        /// <summary>
        /// Centro de Custo
        /// </summary>
        public string CostingCode { get; set; }
        /// <summary>
        /// Projeto
        /// </summary>
        public string ProjectCode { get; set; }
        //public string VatGroup { get; set; }
        //public double Height1 { get; set; }
        //public int? Hight1Unit { get; set; }
        //public double Lengh1 { get; set; }
        //public int? Lengh1Unit { get; set; }
        //public double? Weight1 { get; set; }
        //public int? Weight1Unit { get; set; }
        public int? BaseType { get; set; }
        public string BaseEntry { get; set; }
        public int? BaseLine { get; set; }
        //public double Volume { get; set; }
        //public int? VolumeUnit { get; set; }
        //public double? Width1 { get; set; }
        //public int? Width1Unit { get; set; }
        /// <summary>
        /// Código do Imposto (Tabela OSTC)
        /// </summary>
        public string TaxCode { get; set; }
        //public string TaxLiable { get; set; }
        /// <summary>
        /// Texto Livre
        /// </summary>
        public string FreeText { get; set; }
        //public string MeasureUnit { get; set; }
        //public double? UnitsOfMeasurment { get; set; }
        /// <summary>
        /// Valor total da linha (Não obrigatório)
        /// </summary>
        public double? LineTotal { get; set; }
        /// <summary>
        /// Código CFOP
        /// </summary>
        public string CFOPCode { get; set; }
        /// <summary>
        /// CST
        /// </summary>
        public string CSTCode { get; set; }
        /// <summary>
        /// Utilização (Tabela OUSG)
        /// </summary>
        [Required]
        public int Usage { get; set; }
        //public string TaxOnly { get; set; }
        //public int? VisualOrder { get; set; }
        //public double UnitPrice { get; set; }
        //public double? PackageQuantity { get; set; }

        //public string CostingCode2 { get; set; }
        //public string CostingCode3 { get; set; }
        //public string CostingCode4 { get; set; }
        //public string CostingCode5 { get; set; }
        //public string ItemDetails { get; set; }

        //public string[] WithholdingTaxLines { get; set; }
        //public string[] SerialNumbers { get; set; }
        /// <summary>
        /// Lotes
        /// </summary>
        public Batchnumber[] BatchNumbers { get; set; }
        /// <summary>
        /// Números de Série
        /// </summary>
        public SerialNumber[] SerialNumbers { get; set; }
        /// <summary>
        /// Localização dos lotes/séries
        /// </summary>
        public Documentlinesbinallocation[] DocumentLinesBinAllocations { get; set; }
    }

    public class Linetaxjurisdiction
    {
        public string JurisdictionCode { get; set; }
        public int JurisdictionType { get; set; }
        public double TaxAmount { get; set; }
        public double TaxAmountSC { get; set; }
        public double TaxAmountFC { get; set; }
        public double TaxRate { get; set; }
        public int DocEntry { get; set; }
        public int LineNumber { get; set; }
        public int RowSequence { get; set; }
        public double U_Base { get; set; }
        public double U_Isento { get; set; }
        public double U_Outros { get; set; }
        public double U_Minimo { get; set; }
        public double U_Unidades { get; set; }
        public string U_Medida { get; set; }
        public double U_PrecoMin { get; set; }
        public string U_Moeda { get; set; }
        public double U_Lucro { get; set; }
        public double U_Reducao1 { get; set; }
        public double U_Reducao2 { get; set; }
        public double U_ReduICMS { get; set; }
        public double U_PrecoFix { get; set; }
        public double U_FatorPrc { get; set; }
        public double U_ExcAmtL { get; set; }
        public double U_ExcAmtF { get; set; }
        public double U_ExcAmtS { get; set; }
        public double U_OthAmtL { get; set; }
        public double U_OthAmtF { get; set; }
        public double U_OthAmtS { get; set; }
        public double U_TotalBL { get; set; }
        public double U_TotalBF { get; set; }
        public double U_TotalBS { get; set; }
        public double U_BaseDifL { get; set; }
        public double U_BaseDifF { get; set; }
        public double U_BaseDifS { get; set; }
        public double U_IncIPIL { get; set; }
        public double U_IncIPIF { get; set; }
        public double U_IncIPIS { get; set; }
        public double U_AdValL { get; set; }
        public double U_AdValF { get; set; }
        public double U_AdValS { get; set; }
        public double U_ValDifL { get; set; }
        public double U_ValDifF { get; set; }
        public double U_ValDifS { get; set; }
        public double U_AliqDifL { get; set; }
        public double U_AliqDifF { get; set; }
        public double U_AliqDifS { get; set; }
        public double U_DeducaoL { get; set; }
        public double U_DeducaoF { get; set; }
        public double U_DeducaoS { get; set; }
        public double U_MateriaL { get; set; }
        public double U_MateriaF { get; set; }
        public double U_MateriaS { get; set; }
        public double U_QtdBCL { get; set; }
        public double U_QtdBCF { get; set; }
        public double U_QtdBCS { get; set; }
        public double U_ValDesL { get; set; }
        public double U_ValDesF { get; set; }
        public double U_ValDesS { get; set; }
        public double U_ValCrSNL { get; set; }
        public double U_ValCrSNF { get; set; }
        public double U_ValCrSNS { get; set; }
        public double U_AliqMaj { get; set; }
        public double U_PercDeso { get; set; }
        public double U_PercCrSN { get; set; }
        public double U_AliqDest { get; set; }
        public double U_IntPart { get; set; }
        public double U_TaxAmt2L { get; set; }
        public double U_TaxAmt2F { get; set; }
        public double U_TaxAmt2S { get; set; }
        public double U_SkExcPCL { get; set; }
        public double U_SkExcPCF { get; set; }
        public double U_SkExcPCS { get; set; }
        public double U_pIFCP { get; set; }
        public double U_vIFCPL { get; set; }
        public double U_vIFCPF { get; set; }
        public double U_vIFCPS { get; set; }
        public string U_SkBCMod { get; set; }
    }

    public class Exportprocess
    {
        public int LineNumber { get; set; }
        public int ExportationDocumentTypeCode { get; set; }
        public string ExportationDeclarationNumber { get; set; }
        public string ExportationDeclarationDate { get; set; }
        public int ExportationNatureCode { get; set; }
        public string ExportationRegistryNumber { get; set; }
        public string ExportationRegistryDate { get; set; }
        public string LadingBillNumber { get; set; }
        public string LadingBillDate { get; set; }
        public string MerchandiseLeftCustomsDate { get; set; }
        public int LadingBillTypeCode { get; set; }
    }

    /// <summary>
    /// Lotes
    /// </summary>
    public class Batchnumber
    {
        /// <summary>
        /// Número do lote
        /// </summary>
        public string BatchNumber { get; set; }
        //public string ManufacturerSerialNumber { get; set; }
        //public string InternalSerialNumber { get; set; }
        //public string ExpiryDate { get; set; }
        //public string ManufacturingDate { get; set; }
        //public string AddmisionDate { get; set; }
        //public string Location { get; set; }
        //public string Notes { get; set; }
        public double Quantity { get; set; }
        /// <summary>
        /// Número da linha
        /// </summary>
        public int BaseLineNumber { get; set; }
    }

    /// <summary>
    /// Números de Série
    /// </summary>
    public class SerialNumber
    {
        /// <summary>
        /// Número de Série
        /// </summary>
        public string InternalSerialNumber { get; set; }
        //public int SystemSerialNumber { get; set; }
        public int BaseLineNumber { get; set; }
        public float Quantity { get; set; }
    }


    /// <summary>
    /// Localização do lote/série
    /// </summary>
    public class Documentlinesbinallocation
    {
        /// <summary>
        /// Id da localização no depósito (Tabela OBIN)
        /// </summary>
        public int BinAbsEntry { get; set; }
        public double Quantity { get; set; }
        //public string AllowNegativeQuantity { get; set; }
        /// <summary>
        /// Linha base do LOTE/SÉRIE
        /// </summary>
        public int SerialAndBatchNumbersBaseLine { get; set; }
        /// <summary>
        /// Linha do item
        /// </summary>
        public int BaseLineNumber { get; set; }
    }

    /// <summary>
    /// Despesas Adicionais
    /// </summary>
    public class Documentadditionalexpens
    {
        /// <summary>
        /// ID da despesa (Tabela OEXD)
        /// </summary>
        public int ExpenseCode { get; set; }
        /// <summary>
        /// Valor total da despesa
        /// </summary>
        public double LineTotal { get; set; }
        /// <summary>
        /// Observações
        /// </summary>
        public string Remarks { get; set; }
        /// <summary>
        /// Cód. Imposto (Tabela OSTC)
        /// </summary>
        public string TaxCode { get; set; }
        public int LineNum { get; set; }
    }

    /// <summary>
    /// Parcelas
    /// </summary>
    public class Documentinstallment
    {
        /// <summary>
        /// Data de vencimento
        /// </summary>
        public string DueDate { get; set; }
        /// <summary>
        /// Porcentagem da parcela em relação ao valor total do documento
        /// </summary>
        public double Percentage { get; set; }
        /// <summary>
        /// Valor da parcela
        /// </summary>
        public double Total { get; set; }
        /// <summary>
        /// ID da parcela
        /// </summary>
        public int InstallmentId { get; set; }
    }
}
