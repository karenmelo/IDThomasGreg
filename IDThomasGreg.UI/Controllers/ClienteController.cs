using Microsoft.AspNetCore.Mvc;

namespace IDThomasGreg.UI.Controllers
{
    public class ClienteController : Controller
    {
        [HttpGet("buscar_cliente")]
        public async Task<IActionResult> Get()
        {
            return View();
        }

        [HttpPost("criar_cliente")]
        public async Task<IActionResult> Post()
        {
            return View();
        }

        [HttpPut("alterar_cliente")]
        public async Task<IActionResult> Put()
        {
            return View();
        }

        [HttpDelete("remover_cliente")]
        public async Task<IActionResult> Delete()
        {
            return View();
        }
    }
}
