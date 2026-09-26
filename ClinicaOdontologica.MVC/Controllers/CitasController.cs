using Microsoft.AspNetCore.Mvc;
using ClinicaOdontologica;
using ClinicaOdontologica.Consumer;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

public class CitasController : Controller
{
    // GET: CITAS
    public IActionResult Index()    
    {
        var citas = CRUD<Cita>.GetAll();
        return View(citas);
    }

    // GET: CITAS/Details/5
    public IActionResult Details(int idcita)
    {
        var cita = CRUD<Cita>.GetById(idcita);
        if (cita == null)
        {
            return NotFound();
        }
        return View(cita);
    }

    // GET: CITAS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: CITAS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Cita cita)
    {
        try
        { 
            CRUD<Cita>.Create(cita);
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            ModelState.AddModelError("Error al crear la cita: ", ex.Message);
            return View(cita);
        }
    }

    // GET: CITAS/Edit/5
    public IActionResult Edit(int idcita)
    {
        var cita = CRUD<Cita>.GetById(idcita);
        if (cita == null)
        {
            return NotFound();
        }
        return View(cita);
    }

    // POST: CITAS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int idcita, Cita cita)
    {
        try
        { 
            CRUD<Cita>.Update(idcita,cita);
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            ModelState.AddModelError("Error al actualizar la cita: ", ex.Message);
            return View(cita);
        }
    }

    // GET: CITAS/Delete/5
    public IActionResult Delete(int idcita)
    {
        var cita = CRUD<Cita>.GetById(idcita);
        if (cita == null)
        {
            return NotFound();
        }
        return View(cita);
    }

    // POST: CITAS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult Delete(int idcita, Cita cita)
    {
        try
        { 
            CRUD<Cita>.Delete(idcita);
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            ModelState.AddModelError("Error al eliminar la cita: ", ex.Message);
            return View(cita);
        }
    }
}
