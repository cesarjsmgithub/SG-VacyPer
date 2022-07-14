using Microsoft.AspNetCore.Mvc;
using SG_VacyPer.AppData;
using SG_VacyPer.Models;

namespace SG_VacyPer.Controllers
{
    public class CalendarioController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CalendarioController(ApplicationDbContext db)
        {
            _db = db;
        }

        // LIST - LISTA DE LOS REGISTROS GRABADOS
        public IActionResult IndexCalendario()
        {
            IEnumerable<Calendario> objCalendarioList = _db.Calendario;
            return View(objCalendarioList);
        }

        // GET - SE LLAMA AL FORMULARIO PARA CREAR EL REGISTRO  
        public IActionResult CreateCalendario()
        {

            return View();
        }


        // POST - GRABAR UN REGISTRO NUEVO  ----- 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateCalendario(Calendario obj)
        {

            // 
            var id_Calendario = obj.IdCalendario;
            
            if (ModelState.IsValid)
            {
                _db.Calendario.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Tipo de Calendario creado exitosamente";
                return RedirectToAction("IndexCalendario");
            }
            return View(obj);
        }

        // GET - SE LLAMA AL FORMULARIO PARA CREAR ** EDITAR ** REGISTRO  
        public IActionResult EditCalendario(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var CalendarioFromDb = _db.Calendario.Find(id);
            
            if (CalendarioFromDb == null)
            {
                return NotFound();
            }

            return View(CalendarioFromDb);
        }

        // POST - GRABAR REGISTRO EDITADO  ----- 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditCalendario(Calendario obj)
        {

            var id_Calendario = obj.IdCalendario;
            
            if (ModelState.IsValid)
            {
                _db.Calendario.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Calendario actualizado exitosamente";
                return RedirectToAction("IndexCalendario");
            }
            return View(obj);
        }

        // POST -------- ELIMINAR REGISTRO -------- 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteCalendario(int? id)
        {
            var obj = _db.Calendario.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Calendario.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Calendario borrado exitosamente";
            return RedirectToAction("IndexCalendario");

        }

    }
}
