using Microsoft.AspNetCore.Mvc;
using SG_VacyPer.AppData;
using SG_VacyPer.Models;

namespace SG_VacyPer.Controllers
{
    public class SolicitudVacacionesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public SolicitudVacacionesController(ApplicationDbContext db)
        {
            _db = db;
        }

        // LIST - LISTA DE LOS REGISTROS GRABADOS
        public IActionResult IndexSolicitudVacaciones()
        {
            IEnumerable<SolicitudVacaciones> objSolVacList = _db.SolicitudVacaciones;
            return View(objSolVacList);
        }

        // GET - SE LLAMA AL FORMULARIO PARA CREAR EL REGISTRO  
        public IActionResult CreateSolicitudVacaciones()
        {
            // valores iniciales
            Models.SolicitudVacaciones MyMmodel = new Models.SolicitudVacaciones();

            return View(MyMmodel);
        }


        // POST - GRABAR UN REGISTRO NUEVO  ----- 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateSolicitudVacaciones(SolicitudVacaciones obj)
        {
            // 
            var id_SolicitudVacaciones = obj.IdSolicitudVacaciones;
            
            if (ModelState.IsValid)
            {
                _db.SolicitudVacaciones.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Solicitud de Vacaciones creado exitosamente";
                return RedirectToAction("IndexSolicitudVacaciones");
            }
            return View(obj);
        }

        // GET - SE LLAMA AL FORMULARIO PARA CREAR ** EDITAR ** REGISTRO  
        public IActionResult EditSolicitudVacaciones(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var SolicitudVacacionesFromDb = _db.SolicitudVacaciones.Find(id);
            
            if (SolicitudVacacionesFromDb == null)
            {
                return NotFound();
            }

            return View(SolicitudVacacionesFromDb);
        }

        // POST - ACTUALIZAR REGISTRO EDITADO  ----- 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditSolicitudVacaciones(SolicitudVacaciones obj)
        {

            var id_SolicitudVacaciones = obj.IdSolicitudVacaciones;
            
            if (ModelState.IsValid)
            {
                _db.SolicitudVacaciones.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Solicitud de Vacaciones actualizado exitosamente";
                return RedirectToAction("IndexSolicitudVacaciones");
            }
            return View(obj);
        }

        // POST -------- ELIMINAR REGISTRO -------- 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteSolicitudVacaciones(int? id)
        {
            var obj = _db.SolicitudVacaciones.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.SolicitudVacaciones.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Solicitud de Vacaciones borrado exitosamente";
            return RedirectToAction("IndexSolicitudVacaciones");

        }

    }
}
