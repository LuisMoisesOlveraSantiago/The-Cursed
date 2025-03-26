using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
[ApiController]
[Route("conexion")]
public class Conexion : Controller {
    [HttpGet("mongo")]
    public IActionResult ListarThe_CursedMongoDB(){
        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Practica2_Alejandro_Luis");
        var collection = db.GetCollection<TheCursed>("The_Cursed");

        var lista = collection.Find(FilterDefinition<TheCursed>.Empty).ToList();

        return Ok (lista);

    }
}