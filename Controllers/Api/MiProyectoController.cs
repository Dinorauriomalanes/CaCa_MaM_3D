using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;


[Route("mi-proyecto")]
public class MiProyectoController : ControllerBase{

    [HttpGet("integrante")]
    public IActionResult Integrantes() {
        Integrantes proyecto = new Integrantes
        {
            NombreIntegrante1 = "Daniel Barrón Agundis",
            NombreIntegrante2 = "EMMANUEL ALEJANDRO HERNÁNDEZ BARRIOS "
        };
        return Ok(proyecto);
    }

    [HttpGet("presentacion")]
    public IActionResult Presentacion(){
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Escuela_Daniel_Emmanuel");
        var collection = db.GetCollection<Equipo>("Equipo");

        var item = collection.Find(FilterDefinition<Equipo>.Empty).FirstOrDefault();

        return Ok(item);
    }

}