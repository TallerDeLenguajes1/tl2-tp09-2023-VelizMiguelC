using Microsoft.AspNetCore.Mvc;

namespace tl2_tp09_2023_VelizMiguelC.Controllers;

[ApiController]
[Route("[controller]")]
public class TareaController : ControllerBase
{
    private readonly ILogger<TareaController> _logger;
    private ITareaRepository tareaRepository;
    public TareaController(ILogger<TareaController> logger){
        _logger = logger;
        tareaRepository = new TareaRepository();
    }
    [HttpPost]
    public ActionResult addTarea(Tarea Tar){
        tareaRepository.addTarea(Tar.Id_Tablero,Tar);
        return Ok();
    }
    [HttpPut("{id}/Nombre/{Nombre}")]
    public ActionResult putTarea(int id,string Nombre){

        var tareas = tareaRepository.GetAllTareas().FirstOrDefault(t => t.Id==id);
        if (tareas != null)
        {
            tareas.Nombre=Nombre;
            tareaRepository.PutTarea(id,tareas);
        }
        return Ok();
    }
    [HttpPut ("{id}/Estado/{estado}")]
    public ActionResult putEstadoTarea(int id,EstadoTarea estado){
        tareaRepository.PutEstadoTarea(id,estado);
        return Ok();
    }
    [HttpDelete("{id}")]
    public ActionResult DeleteTarea(int id){
        tareaRepository.DeleteTarea(id);
        return Ok();
    }
    [HttpGet("{estado}")]
    public ActionResult<List<Tarea>> GetAllTareasInEstado(EstadoTarea estado){
        var Tareas = tareaRepository.GetAllTareas();
        var cant = Tareas.Count(t => t.Estado == estado);
        return Ok(cant);
    }
    [HttpGet("Usuario/{id}")]
    public ActionResult<List<Tarea>> GetAllTareasInUsu(int id){
        var tareas = tareaRepository.GetTareasUsu(id);
        return Ok(tareas);
    }
    [HttpGet("Tablero/{id}")]
    public ActionResult<List<Tarea>> GetAllTareasInTab(int id){
        var tareas = tareaRepository.GetTareasTab(id);
        return Ok(tareas);
    }
}