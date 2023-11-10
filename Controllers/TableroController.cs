using Microsoft.AspNetCore.Mvc;

namespace tl2_tp09_2023_VelizMiguelC.Controllers;

[ApiController]
[Route("[controller]")]
public class TableroController : ControllerBase
{
    private readonly ILogger<TableroController> _logger;
    private ITableroRepository tableroRepository;
    public TableroController(ILogger<TableroController> logger){
        _logger = logger;
        tableroRepository = new TableroRepository();
    }
    [HttpPost]
    public ActionResult AddTablero(Tablero Tab){
        tableroRepository.addTablero(Tab);
        return Ok();
    }
    [HttpGet]
    public ActionResult<List<Tablero>> ListTableros(){
        var tabs = tableroRepository.GetTableros();
        return Ok(tabs);
    }
}