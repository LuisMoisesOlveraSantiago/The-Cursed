using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("conexion")]
public class Conexion : Controller {
    [HttpGet("mongo")]
    public IActionResult ListarThe_CursedMongoDB(){
        return Ok ("Me estoy conectando");
    }
}