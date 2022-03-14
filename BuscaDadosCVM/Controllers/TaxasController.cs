using BuscaDadosCVM.Data;
using BuscaDadosCVM.Models;
using BuscaDadosCVM.Services;
using CsvHelper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace BuscaDadosCVM.Controllers
{
    public class TaxasController : Controller
    {
        private static readonly HttpClient client = new HttpClient();
        private static string uri = "http://dados.cvm.gov.br/dados/FI/DOC/INF_DIARIO/DADOS/";

        private readonly TaxaService _taxaService;
        private readonly BuscaDadosCVMContext _context;

        public TaxasController(TaxaService taxaService, BuscaDadosCVMContext context)
        {
            _taxaService = taxaService;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.ImportacaoTaxa.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> CreateTaxa(DataAno data)
        {
            int anoMesDivulgacao = int.Parse(data.Ano.ToString() + data.Mes.ToString());
            var registroTaxa = await _context.Taxa.FirstOrDefaultAsync(obj => obj.AnoMesDivulgacao == anoMesDivulgacao);

            if (registroTaxa != null)
            {
                return RedirectToAction(nameof(Index));
            }

            await _taxaService.InsertTaxa(data, uri);

            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

