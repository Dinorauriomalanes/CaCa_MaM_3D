using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using MongoDB.Bson;

[ApiController]
[Route("api/usuarios")]
public class ApiUsuarioController : ControllerBase{

    private readonly IMongoCollection<Usuario> collection;

    public ApiUsuarioController(){
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Escuela_Daniel_Emmanuel");
        this.collection = db.GetCollection<Usuario>("Usuarios");
    }

    [HttpGet]
    public IActionResult ListarUsuarios(){
        var filter = FilterDefinition<Usuario>.Empty;
        var list = this.collection.Find(filter).ToList();

        return Ok(list);
    }
}