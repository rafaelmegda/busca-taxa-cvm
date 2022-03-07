using BuscaDadosCVM.Data;
using BuscaDadosCVM.Models;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BuscaDadosCVM.Services
{
    public class TaxaService
    {
        private readonly BuscaDadosCVMContext _context;
        private static readonly HttpClient client = new HttpClient();
        private static string uri = "http://dados.cvm.gov.br/dados/FI/DOC/INF_DIARIO/DADOS/inf_diario_fi_201701.csv";

        public TaxaService(BuscaDadosCVMContext context)
        {
            _context = context;
        }

        public async Task<List<Taxa>> InsertTaxa(DataAno data)
        {
            List<Taxa> taxas = new List<Taxa>();

            using (var stream = await client.GetStreamAsync(uri))
            using (var streamReader = new StreamReader(stream))
            using (var csvReader = new CsvReader(streamReader, System.Globalization.CultureInfo.CurrentCulture))
            {

                var records = new List<Taxa>();
                csvReader.Read();
                csvReader.ReadHeader();
                while (csvReader.Read())
                {
                    var record = new Taxa
                    {
                        CNPJ_FUNDO = csvReader.GetField("CNPJ_FUNDO"),
                        DT_COMPTC = csvReader.GetField<DateTime>("DT_COMPTC"),
                        VL_TOTAL = csvReader.GetField<decimal>("VL_TOTAL"),
                        VL_QUOTA = csvReader.GetField<decimal>("VL_QUOTA"),
                        VL_PATRIM_LIQ = csvReader.GetField<decimal>("VL_PATRIM_LIQ"),
                        CAPTC_DIA = csvReader.GetField<decimal>("CAPTC_DIA"),
                        RESG_DIA = csvReader.GetField<decimal>("RESG_DIA"),
                        NR_COTST = csvReader.GetField<decimal>("NR_COTST")
                    };
                    _context.Add(record);
                    await _context.SaveChangesAsync();
                    taxas.Add(record);
                }

                //var records = csvReader.GetRecords<Taxa>();

                //foreach (var taxa in records)
                //{
                //    _context.Add(taxa);
                //    await _context.SaveChangesAsync();
                //    taxas.Add(taxa);
                //}
            }

            return taxas;
        }
    }
}
