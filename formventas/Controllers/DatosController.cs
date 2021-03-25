using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using formventas.Models;

namespace formventas.Controllers
{
    public class DatosController : Controller
    {
        private readonly ILogger<DatosController> _logger;

        public DatosController(ILogger<DatosController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Message"] = "";
            return View();
        }
        [HttpPost]

        public IActionResult MiMetodoExecute(Datos objDatos)
        {
            Double basetotal =0.0;
            Double baseigv=0.0;
            Double igv=0.18;
            Double preciototal=0.0;
            String mensaje ="";
        basetotal= objDatos.Cantidad * objDatos.Precio;
        baseigv=basetotal*igv;

        preciototal=basetotal+baseigv;
        mensaje="El precio es S/."+ preciototal;
            ViewData["Message"] = mensaje;
            return View("Index");
        }
      

      
    }
}