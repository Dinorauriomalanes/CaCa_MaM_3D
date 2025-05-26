using Microsoft.AspNetCore.Mvc;


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
}