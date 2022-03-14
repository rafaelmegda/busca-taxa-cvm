using BuscaDadosCVM.Data;
using BuscaDadosCVM.Models;
using CsvHelper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private static string uri = "http://dados.cvm.gov.br/dados/FI/DOC/INF_DIARIO/DADOS/";

        public TaxaService(BuscaDadosCVMContext context)
        {
            _context = context;
        }

        public string validarEndpoint(DataAno data)
        {
            string complemento = "inf_diario_fi_";
            complemento += data.Ano.ToString();
            complemento += data.Mes.ToString();
            complemento += ".csv";

            string endpoint = uri += complemento;

            return endpoint;
        }

        public async Task<List<Taxa>> InsertTaxa(DataAno data, String uri)
        {
            List<Taxa> taxas = new List<Taxa>();

            uri = validarEndpoint(data);

            int anoMesDivulgacao = int.Parse(data.Ano.ToString() + data.Mes.ToString());

            var importacao = statusImportacao(uri, anoMesDivulgacao, Status.Iniciado, null);

            try
            {
                using (var stream = await client.GetStreamAsync(uri))
                using (var streamReader = new StreamReader(stream))
                using (var csvReader = new CsvReader(streamReader, System.Globalization.CultureInfo.CurrentCulture))
                {
                    csvReader.Read();
                    csvReader.ReadHeader();
                    while (csvReader.Read())
                    {
                        var record = new Taxa
                        {
                            //ImportacaoTaxaId = importacao,
                            AnoMesDivulgacao = anoMesDivulgacao,
                            DataImportacao = DateTime.Now,
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
                }

                importacao = statusImportacao(uri, anoMesDivulgacao, Status.Finalizada, null);

                return taxas;
            }
            catch (Exception)
            {
                importacao = statusImportacao(uri, anoMesDivulgacao, Status.Falhou, null);
                throw;
            }
        }

        public async Task<ImportacaoTaxa> statusImportacao(string uri, int anoMesDivulgacao, Status status, int? id_importacao)
        {
            var importacaoTaxa = new ImportacaoTaxa
            {
                DataImportacao = DateTime.Now,
                StatusImportacao = status.ToString(),
                ArquivoImportado = uri,
                DataDivulgacaoArquivo = anoMesDivulgacao
            };

            _context.Add(importacaoTaxa);
            await _context.SaveChangesAsync();

            var resultadoInsert = _context.ImportacaoTaxa.
            Where(obj => obj.DataDivulgacaoArquivo == anoMesDivulgacao).FirstOrDefault();

            return resultadoInsert;
        }

        public enum Status
        {
            Iniciado,
            Importando,
            Finalizada,
            JaImportado,
            Falhou,
        }
    }
}
