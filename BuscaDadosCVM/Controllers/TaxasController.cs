using BuscaDadosCVM.Data;
using BuscaDadosCVM.Models;
using CsvHelper;
using ExcelDataReader;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BuscaDadosCVM.Controllers
{
    public class TaxasController : Controller
    {
        private static readonly HttpClient client = new HttpClient();
        private static string uri = "http://dados.cvm.gov.br/dados/FI/DOC/INF_DIARIO/DADOS/inf_diario_fi_201701.csv";

        private readonly BuscaDadosCVMContext _context;

        public TaxasController(BuscaDadosCVMContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            //var stringTask = client.GetStreamAsync("http://dados.cvm.gov.br/dados/FI/DOC/INF_DIARIO/DADOS/inf_diario_fi_201701.csv");
            //var msg = stringTask;
            //Console.Write(msg);

            Task<List<Taxa>> taxas = buscarTaxa();


            return View(await taxas);
        }

        public async Task<List<Taxa>> buscarTaxa()
        {
            List<Taxa> taxas = new List<Taxa>();

            using (var stream = await client.GetStreamAsync(uri))
            using (var streamReader = new StreamReader(stream)) 
            using (var csvReader = new CsvReader(streamReader, System.Globalization.CultureInfo.CurrentCulture))
            {
                var records = csvReader.GetRecords<Taxa>();

                foreach (var taxa in records)
                {
                    taxas.Add(taxa);
                }
            }

            //var request = client.GetAsync(uri);

            //using (var stream = await client.GetStreamAsync(uri))
            //using (var streamReader = new StreamReader(stream))
            //using (var csv = new CsvReader(streamReader, System.Globalization.CultureInfo.CurrentCulture))
            //{
            //    csv.Configuration.Delimiter = ";";

            //    //await _sqlRepository.UpdateNorwegianCompaniesTable(csv.GetRecords<Taxa>());

            //}

            return taxas;
        }

    }
}
