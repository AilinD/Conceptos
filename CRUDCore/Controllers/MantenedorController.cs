using Microsoft.AspNetCore.Mvc;
using CRUDCore.Datos;
using CRUDCore.Models;

namespace CRUDCore.Controllers
{
    public class MantenedorController : Controller
    {
        ContactoDatos _ContactoDatos = new ContactoDatos();
        public IActionResult Listar()
        {
            var oLista= _ContactoDatos.Listar();
            return View(oLista);
        }

        public IActionResult Guardar()
        {//metodo solo para devoler vista
            return View();
        }

        [HttpPost]
        public IActionResult Guardar(ContactoModel oContacto)
        {
            //metodo recibe objeto para guardarlo
            //en bd

            if(!ModelState.IsValid)
            {
                return View();
                // si es falso retorna la modificaciones de danger en eñ guardar
            }
            var respuesta = _ContactoDatos.Guardar(oContacto);
            if (respuesta)
                return RedirectToAction("Listar");
            else            
                return View();
                  
        }

        //este metodo es para ver el formulario
        public IActionResult Editar(int IdContacto)
        {//metodo solo para devoler vista
            var oContacto= _ContactoDatos.Obtener(IdContacto);
            return View(oContacto);
        }

        /// <summary>
        /// este metodo sirve para poder recibir el objeto que hemos modificado
        /// </summary>
        /// <param name="IdContacto"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Editar(ContactoModel oContacto)
        {//metodo solo para devoler vista
            if (!ModelState.IsValid)
            {
                return View();
                // si es falso retorna la modificaciones de danger en eñ guardar
            }
            var respuesta = _ContactoDatos.Editar(oContacto);
            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }



        //este metodo es para ver el formulario
        public IActionResult Eliminar(int IdContacto)
        {//metodo solo para devoler vista
            var oContacto = _ContactoDatos.Obtener(IdContacto);
            return View(oContacto);
        }

        /// <summary>
        /// este metodo sirve para poder recibir el objeto que hemos modificado
        /// </summary>
        /// <param name="IdContacto"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Eliminar(ContactoModel oContacto)
        {//metodo solo para devoler vista
           
            var respuesta = _ContactoDatos.Eliminar(oContacto.IdContacto);
            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }
    }
}
