using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VPO.App.ViewModels;

namespace VPO.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("erro/{id:length(3,3)}")]
        public IActionResult Error(int id)
        {
            var errorModel = new ErrorViewModel();

            if (id == 500)
            {
                errorModel.Message = "Ocorreu um erro! Tente novamente mais tarde ou contate nosso suporte.";
                errorModel.Title = "Ocorreu um erro!";
                errorModel.Code = id;
            }
            else if (id == 404)
            {
                errorModel.Message = "A página que está procurando não existe! <br />Em caso de dúvidas entre em contato com nosso suporte";
                errorModel.Title = "Ops! Página não encontrada.";
                errorModel.Code = id;
            }
            else if (id == 403)
            {
                errorModel.Message = "Você não tem permissão para fazer isto.";
                errorModel.Title = "Acesso Negado";
                errorModel.Code = id;
            }
            else
            {
                return StatusCode(500);
            }

            return View("Error", errorModel);
        }
    }
}
