using System.Diagnostics;
using googlemaps.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace googlemaps.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var Transportes = new Dictionary<string, string>
        {
            { "DRIVING", "Automóvil" },
            { "WALKING", "Caminando" },
            { "BICYCLING", "Bicicleta" },
            { "TRANSIT", "Transporte público" }
        };
        var selectList = new SelectList(Transportes, "Key", "Value");

        var model = new UbicacionViewModel { Transportes = selectList, MostrarRuta = true };
        return View(model);
    }
}
