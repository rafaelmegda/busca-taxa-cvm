using BuscaDadosCVM.Data;
using BuscaDadosCVM.Models;
using BuscaDadosCVM.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuscaDadosCVM.Controllers
{
    public class TaxasController : Controller
    {
        private readonly TaxaService _taxaService;

        public TaxasController(TaxaService taxaService)
        {
            _taxaService = taxaService;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Create(DataAno data)
        {
            _taxaService.InsertTaxa(data);
            return RedirectToAction(nameof(Index));
        }
        

    }
}
