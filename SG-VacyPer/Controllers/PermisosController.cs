using Microsoft.AspNetCore.Mvc;
using SG_VacyPer.AppData;
using SG_VacyPer.Models;

namespace SG_VacyPer.Controllers
{
    public class PermisosController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PermisosController(ApplicationDbContext db)
        {
            _db = db;
        }

        // LIST - LISTA DE LOS REGISTROS GRABADOS
        public IActionResult IndexPermisos()
        {
            IEnumerable<Permisos> objPermisosList = _db.Permisos;
            return View(objPermisosList);
        }

        // GET - SE LLAMA AL FORMULARIO PARA CREAR EL REGISTRO  
        public IActionResult CreatePermiso()
        {

            return View();
        }


        // POST - GRABAR UN REGISTRO NUEVO  ----- 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatePermiso(Permisos obj)
        {

            // 
            var id_permisos = obj.IdPermisos;
            
            if (ModelState.IsValid)
            {
                _db.Permisos.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Tipo de permiso creado exitosamente";
                return RedirectToAction("IndexPermisos");
            }
            return View(obj);
        }

        // GET - SE LLAMA AL FORMULARIO PARA CREAR ** EDITAR ** REGISTRO  
        public IActionResult EditPermiso(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var PermisosFromDb = _db.Permisos.Find(id);
            
            if (PermisosFromDb == null)
            {
                return NotFound();
            }

            return View(PermisosFromDb);
        }

        // POST - GRABAR REGISTRO EDITADO  ----- 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditPermiso(Permisos obj)
        {

            var id_permisos = obj.IdPermisos;
            
            if (ModelState.IsValid)
            {
                _db.Permisos.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Tipo de permiso actualizado exitosamente";
                return RedirectToAction("IndexPermisos");
            }
            return View(obj);
        }

        // POST -------- ELIMINAR REGISTRO -------- 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePermiso(int? id)
        {
            var obj = _db.Permisos.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Permisos.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Tipo de permiso borrado exitosamente";
            return RedirectToAction("IndexPermisos");

        }

    }
}
