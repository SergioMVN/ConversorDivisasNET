using Conversor_de_Divisas.Models;
using Microsoft.AspNetCore.Mvc;



public class ConvertidorController : Controller
{
    // La tasa de cambio ficticia, debes reemplazarla con datos reales
    private readonly decimal TasaCambioUSDToCLP = 925.15m; // Ejemplo: 1 USD = 800 CLP

    public IActionResult Index()
    {
        return View(new ConversionModels());
    }

    [HttpPost]
    public IActionResult Convertir(ConversionModels model)
    {
        if (ModelState.IsValid)
        {
            // Lógica de conversión: Multiplicar el monto ingresado por la tasa de cambio
            model.Resultado = model.Monto * TasaCambioUSDToCLP;
        }


        return View("~/Views/Home/Index.cshtml", model);
    }

    [HttpPost]
    public IActionResult Limpiar()
    {
        // Crea un nuevo modelo vacío
        ConversionModels modeloInicial = new ConversionModels();

        // Redirige a la vista principal con el nuevo modelo
        return RedirectToAction("Index", "Home", modeloInicial);
    }


}
