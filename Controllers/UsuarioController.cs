using Microsoft.AspNetCore.Mvc;

namespace tl2_tp09_2023_VelizMiguelC.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
    private readonly ILogger<UsuarioController> _logger;
    private IUsuarioRepository usuarioRepository;
    public UsuarioController(ILogger<UsuarioController> logger){
        _logger = logger;
        usuarioRepository = new UsuarioRepository();
    }
    [HttpPost]
    public ActionResult AddUsuario(Usuario usu){
        usuarioRepository.addUsuario(usu);
        return Ok();
    }
    [HttpGet]
    public ActionResult<List<Usuario>> ListUsuarios(){
        var usuarios = usuarioRepository.ListUsuarios();
        return Ok(usuarios);
    }
    [HttpGet("{id}")]
    public ActionResult<Usuario> GetUsuario(int id){
        var usuario = usuarioRepository.GetUsuario(id);
        return Ok(usuario);
    }
    [HttpPut ("{id}/Nombre")]
    public ActionResult ModUsuario(int id,Usuario usu){
        usuarioRepository.PutUsuario(id,usu);
        return Ok();
    }
}