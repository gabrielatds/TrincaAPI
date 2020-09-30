using ChurrasMVC.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChurrasMVC.Controllers
{
    public class ChurrascosController : Controller
    {
        private readonly IChurrascoService _churrascoService;

        public ChurrascosController(IChurrascoService churrascoService)
        {
            _churrascoService = churrascoService ??
                throw new ArgumentNullException();
        }

        public async Task<IActionResult> Index()
        
        {
            var churrascos = await _churrascoService.GetAllChurrascos();
            return View(churrascos);
        }

        [HttpGet("details/{id}")]
        public async Task<IActionResult> Details(int? id)
        
        {
            var churrasco = await _churrascoService.GetChurrascoById(id.Value);
            return View(churrasco);
        }
    }
}
