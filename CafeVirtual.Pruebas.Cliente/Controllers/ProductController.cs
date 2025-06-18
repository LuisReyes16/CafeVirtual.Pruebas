using Microsoft.AspNetCore.Mvc;
using CafeVirtual.Pruebas.Data.Models;
using CafeVirtual.Pruebas.Utilidades.Model;

namespace CafeVirtual.Pruebas.Cliente.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(string? txtBusqueda, int pageNumber = 1)
        {
            // Crear un modelo vacío pero compatible con la vista
            var productos = new List<TblProducto>(); // Lista vacía por ahora

            // Crear la paginación con datos vacíos
            var paginatedList = new PaginatedList<TblProducto>(productos, productos.Count, pageNumber, 5);

            // Crear el ResponseViewModel
            var response = new ResponseViewModel<PaginatedList<TblProducto>>
            {
                Success = true,
                Message = "Módulo en construcción",
                Data = paginatedList
            };

            ViewBag.Busqueda = txtBusqueda;

            return View(response);
        }

        public IActionResult AgregarProduct()
        {
            return View();
        }

        public IActionResult EditarProduct(int id)
        {
            ViewBag.IdProducto = id;
            return View();
        }

        public IActionResult EliminarProduct(int id)
        {
            ViewBag.IdProducto = id;
            return View();
        }
    }
}