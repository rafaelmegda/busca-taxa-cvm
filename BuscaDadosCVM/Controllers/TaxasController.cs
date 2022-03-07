using BuscaDadosCVM.Data;
using BuscaDadosCVM.Models;
using BuscaDadosCVM.Services;
using CsvHelper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace BuscaDadosCVM.Controllers
{
    public class TaxasController : Controller
    {
        private static readonly HttpClient client = new HttpClient();
        private static string uri = "http://dados.cvm.gov.br/dados/FI/DOC/INF_DIARIO/DADOS/";

        private readonly BuscaDadosCVMContext _context;

        public TaxasController(BuscaDadosCVMContext context)
        {
            _context = context;
        }


        //private readonly TaxaService _taxaService;

        //public TaxasController(TaxaService taxaService)
        //{
        //    _taxaService = taxaService;
        //}

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult CreateTaxa(DataAno data)
        {
            DataAno dataAno = new DataAno();
            dataAno.Ano = data.Ano;
            string uri = validarEndpoint(data);

            //await _taxaService.InsertTaxa(data, uri);
            return RedirectToAction(nameof(Index));
        }

        public string validarEndpoint(DataAno data)
        {
            string complemento = "inf_diario_fi_";
            complemento += data.Ano.ToString();
            complemento += data.Mes.ToString();

            string endpoint = uri += complemento;

            return endpoint;
        }

        //public async Task<List<Taxa>> InsertTaxa(DataAno data, String uri)
        //{
        //    List<Taxa> taxas = new List<Taxa>();

        //    using (var stream = await client.GetStreamAsync(uri))
        //    using (var streamReader = new StreamReader(stream))
        //    using (var csvReader = new CsvReader(streamReader, System.Globalization.CultureInfo.CurrentCulture))
        //    {

        //        var records = new List<Taxa>();
        //        csvReader.Read();
        //        csvReader.ReadHeader();
        //        while (csvReader.Read())
        //        {
        //            var record = new Taxa
        //            {
        //                CNPJ_FUNDO = csvReader.GetField("CNPJ_FUNDO"),
        //                DT_COMPTC = csvReader.GetField<DateTime>("DT_COMPTC"),
        //                VL_TOTAL = csvReader.GetField<decimal>("VL_TOTAL"),
        //                VL_QUOTA = csvReader.GetField<decimal>("VL_QUOTA"),
        //                VL_PATRIM_LIQ = csvReader.GetField<decimal>("VL_PATRIM_LIQ"),
        //                CAPTC_DIA = csvReader.GetField<decimal>("CAPTC_DIA"),
        //                RESG_DIA = csvReader.GetField<decimal>("RESG_DIA"),
        //                NR_COTST = csvReader.GetField<decimal>("NR_COTST")
        //            };
        //            _context.Add(record);
        //            await _context.SaveChangesAsync();
        //            taxas.Add(record);
        //        }

        //        //var records = csvReader.GetRecords<Taxa>();

        //        //foreach (var taxa in records)
        //        //{
        //        //    _context.Add(taxa);
        //        //    await _context.SaveChangesAsync();
        //        //    taxas.Add(taxa);
        //        //}
        //    }

        //    return taxas;
        //}


    }
}
