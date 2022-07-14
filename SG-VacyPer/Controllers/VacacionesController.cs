using Microsoft.AspNetCore.Mvc;
using SG_VacyPer.AppData;
using SG_VacyPer.Models;

namespace SG_VacyPer.Controllers
{
    public class VacacionesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public VacacionesController(ApplicationDbContext db)
        {
            _db = db;
        }

        // LIST - LISTA DE LOS REGISTROS GRABADOS
        public IActionResult IndexVacaciones()
        {
            IEnumerable<Vacaciones> objVacacionesList = _db.Vacaciones;
            return View(objVacacionesList);
        }

        // GET - SE LLAMA AL FORMULARIO PARA CREAR EL REGISTRO  
        public IActionResult CreateVacaciones()
        {
            // valores iniciales
            Models.Vacaciones MyMmodel = new Models.Vacaciones();
            MyMmodel.DiasOficiales = 22;
            MyMmodel.DiasAdicionales = 0;

            return View(MyMmodel);
        }


        // POST - GRABAR UN REGISTRO NUEVO  ----- 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateVacaciones(Vacaciones obj)
        {
            // 
            var id_Vacaciones = obj.IdVacaciones;
            
            if (ModelState.IsValid)
            {
                _db.Vacaciones.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Tipo de Vacaciones creado exitosamente";
                return RedirectToAction("IndexVacaciones");
            }
            return View(obj);
        }

        // GET - SE LLAMA AL FORMULARIO PARA CREAR ** EDITAR ** REGISTRO  
        public IActionResult EditVacaciones(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var VacacionesFromDb = _db.Vacaciones.Find(id);
            
            if (VacacionesFromDb == null)
            {
                return NotFound();
            }

            return View(VacacionesFromDb);
        }

        // POST - ACTUALIZAR REGISTRO EDITADO  ----- 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditVacaciones(Vacaciones obj)
        {

            var id_Vacaciones = obj.IdVacaciones;
            
            if (ModelState.IsValid)
            {
                _db.Vacaciones.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Tipo de Vacaciones actualizado exitosamente";
                return RedirectToAction("IndexVacaciones");
            }
            return View(obj);
        }

        // POST -------- ELIMINAR REGISTRO -------- 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteVacaciones(int? id)
        {
            var obj = _db.Vacaciones.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Vacaciones.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Tipo de Vacaciones borrado exitosamente";
            return RedirectToAction("IndexVacaciones");

        }

    }
}
