using Microsoft.AspNetCore.Mvc;
using SG_VacyPer.AppData;
using SG_VacyPer.Models;

namespace SG_VacyPer.Controllers
{
    public class EmpleadosController : Controller
    {
        private readonly ApplicationDbContext _db;
        
        public EmpleadosController(ApplicationDbContext db)
        {
            _db = db;
        }

        // LIST - LISTA DE LOS REGISTROS GRABADOS
        public IActionResult IndexEmpleados()
        {
            IEnumerable<Empleados> objEmpleadosList = _db.Empleados;
            return View(objEmpleadosList);
        }

        // GET - SE LLAMA AL FORMULARIO PARA CREAR EL REGISTRO  
        public IActionResult CreateEmpleado()
        {
            // valores iniciales
            Models.Empleados MyMmodel = new Models.Empleados();
            MyMmodel.ResponsableId = 0;

            return View(MyMmodel);
        }

        // POST - GRABAR UN REGISTRO NUEVO  ----- 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateEmpleado(Empleados obj)
        {

            // ESTO DEBO CAMBIARLO PARA VALIDAR EL DOCUMENTO DE IDENTIDAD
            var id_empleado = obj.IdEmpleado;
            if (obj.DocIdentidad == obj.NombreCompleto)
            {
                ModelState.AddModelError("DocIdentidad", "El documento de identidad ya existe.");
            }

            if (ModelState.IsValid)
            {
                _db.Empleados.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Empleado creado exitosamente";
                return RedirectToAction("IndexEmpleados");
            }
            return View(obj);
        }


        // GET - SE LLAMA AL FORMULARIO PARA CREAR ** EDITAR ** REGISTRO  
        public IActionResult EditEmpleado(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var EmpleadosFromDb = _db.Empleados.Find(id);
            // var EmpleadosFromDbFirst = _db.Empleados.FirstOrDefault(u=>u.Id == id);
            // var EmpleadosFromDbSingle = _db.Empleados.SingleOrDefault(u => u.Id == id);
            
            if (EmpleadosFromDb == null)
            {
                return NotFound();
            }

            return View(EmpleadosFromDb);
        }

        // POST - GRABAR REGISTRO EDITADO  ----- 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditEmpleado(Empleados obj)
        {

            // ESTO DEBO CAMBIARLO PARA VALIDAR EL DOCUMENTO DE IDENTIDAD
            var id_empleado = obj.IdEmpleado;
            if (obj.DocIdentidad == obj.NombreCompleto)
            {
                ModelState.AddModelError("DocIdentidad", "El documento de identidad ya existe.");
            }

            if (ModelState.IsValid)
            {
                _db.Empleados.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Empleado actualizado exitosamente";
                return RedirectToAction("IndexEmpleados");
            }
            return View(obj);
        }

        // POST -------- ELIMINAR REGISTRO -------- 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteEmpleado(int? id)
        {
            var obj = _db.Empleados.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Empleados.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Empleado borrado exitosamente";
            return RedirectToAction("IndexEmpleados");

        }

    }
}
