using MyMvc.Models;
using System.Web.Mvc;

namespace MyMvc.Controllers
{
    public class AlunoController : Controller
    {
        public ActionResult Index()
        {
            var aluno = new AlunoViewModel();
            aluno.AlunoID = 1;
            aluno.Nome = "Douglas";

            return View(aluno);
        }
    }
}